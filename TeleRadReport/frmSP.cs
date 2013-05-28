using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using DicomObjects;
using System.Data.Odbc;

namespace TeleRadReport
{
    public partial class frmSP : Form
    {
        public frmSP()
        {
            InitializeComponent();
        }

        string Requests;
        string Received;
        string Info;
        string Images;
        string Attributes;
        DicomImage SelectedImage;
        bool isSelectedImage;
        DicomImage ScrolledImage;
        bool isScrolledImage;
        DicomImage WindowedImage;
        bool inOnDisplay;
        float BaseX;
        float BaseY;
        DicomLabel CurrentLabel;
        DicomLabel InfoLabel;
        bool LabelDrawing;
        int ClickNum;
        DicomLabel InfLabel;
        RetrieveDialogType RetrieveDialog;
        bool isInitializing;
        int[] XYCoord = new int[7];
        double[] CobbCoord = new double[9];
        int OldIMIndex;
        int InitialVOILUT;
        int InitialMINMOD;
        int InitialMAGMOD;
        bool LabelSelected;
        float InitialTop;
        float InitialHeight;
        float InitialWidth;
        float InitialLeft;
        float InitialX;
        float InitialY;
        DicomImage ZoomImage;
        DicomImage BaseImage;
        int ZoomHeight;
        int ZoomWidth;
        int ZoomScrollX;
        int ZoomScrollY;
        bool Zooming;
        DicomLabelCollection LabelList;
        Array LabelPoints;
        Array Pixels;
        DicomServer server = new DicomServer();
        System.Drawing.Printing.PrintDocument printDoc;
        int PixelsNumber;
        int ZoomIndex;
        double x1;
        double y1;
        double x2;
        double y2;
        DicomObjects.Enums.FilterMode MiniMode;
        DicomObjects.Enums.FilterMode MagMode;
        //Dim viewer As DicomObjects.DicomViewer
        DicomObjects.DicomQuery q;
        DicomObjects.DicomDataSetCollection s;
        long n = 0;
        Myconnectionclass CN = new Myconnectionclass();
        OdbcCommand Cmd;
        OdbcDataReader Rs1;

        bool nowConnected = false;
        public enum MouseFunctionEnums
        {
            None = 0,
            SelectImage = 1,
            Windowing = 2,
            Scroll = 3,
            AddAnnotation = 4,
            Measure = 5,
            EditAnnotation = 6,
            MagnifyingGlass = 7,
            PixelValues = 8,
            CropImage = 9,
            CobbMeasurement = 10,
            Protractor = 11
        }

        MouseFunctionEnums MouseFunction;
        public enum LabelEdgeType
        {
            TopLeft,
            TopRight,
            BottomRight,
            BottomLeft
        }

        LabelEdgeType LabelEdge;
        LabelFormType LabelForm = new LabelFormType();

        AttributeFormType AttributeForm = new AttributeFormType();
        RetrieveDialogType frmRet = new RetrieveDialogType();

        public DicomImage GetSelectedImage()
        {
            DicomImage functionReturnValue = default(DicomImage);

            if (isInitializing)
            {
                functionReturnValue = new DicomImage(); return null;
            }

            if (isSelectedImage)
            {
                functionReturnValue = SelectedImage;
            }
            else if (Viewer.Images.Count > 0)
            {
                functionReturnValue = Viewer.CurrentImage;
            }
            else
            {
                Interaction.MsgBox("No Images to manipulate!");
                // make a trivial image, just to prevent errors
                SelectedImage = new DicomImage();
                functionReturnValue = SelectedImage;
                isSelectedImage = true;
            }
            return functionReturnValue;
        }

        private void ImageRead_Click(System.Object sender, System.EventArgs e)
        {
            OpenFileDialog.Multiselect = true;
            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in OpenFileDialog.FileNames)
                {
                    Viewer.Images.Read(filename);
                }
                CImageIndex.Maximum = Viewer.Images.Count - 1;
                CImageIndex.Minimum = 0;
            }
        }

        private void ImageWrite_Click(System.Object sender, System.EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GetSelectedImage().Write(SaveFileDialog.FileName, DicomObjects.DicomUIDs.TransferSyntaxes.ExplicitVRLittleEndian);
            }
        }

        private void PrintDICOM_Click(System.Object sender, System.EventArgs e)
        {
            //DicomPrint printer = new DicomPrint();

            //printer.Colour = OptionsBox.PrintInColour.Checked;
            //printer.Format = OptionsBox.PrintFormat.Text;
            //printer.Orientation = OptionsBox.PrintOrientation.Text;
            //printer.FilmSize = OptionsBox.FilmSize.Text;

            //printer.Open(OptionsBox.PrintNode.Text, OptionsBox.PrintPort.Text, OptionsBox.PrintAE.Text, OptionsBox.PrintCallingAE.Text);

            //printer.FilmBox.Add(0x2010, 0x60, OptionsBox.Magnification.Text);
            //printer.PrintImage(Viewer.CurrentImage, true, true);

            //printer.Close();
        }

        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            server.UnlistenAll();
            this.Hide();
        }

        private void frmSP_GotFocus(object sender, System.EventArgs e)
        {
            txtReports.Refresh();
        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            RetrieveDialog = new RetrieveDialogType();
            NewData();
            lblImgCount.Text = Viewer.Images.Count.ToString();
            this.Text = "Study of " + modMain.PatName + " (" + GetSelectedImage().StudyUID + ")";
            //Show_Notes()
        }

        private void ExitOption_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void LevelSlider_Scroll(System.Object sender, System.EventArgs e)
        {
            //int i = 0;
            //if (OptionsBox.WindowAll.Checked)
            //{
            //    for (i = 0; i <= Viewer.Images.Count - 1; i++)
            //    {
            //        Viewer.Images[i].Level = LevelSlider.Value;
            //    }
            //}
            //else
            //{
            GetSelectedImage().Level = LevelSlider.Value;
            //}

            Level1.Text = LevelSlider.Value.ToString();
            Level1.Refresh();
        }

        private void WidthSlider_Scroll(System.Object sender, System.EventArgs e)
        {
            //int i = 0;
            //if (OptionsBox.WindowAll.Checked)
            //{
            //    for (i = 1; i <= Viewer.Images.Count; i++)
            //    {
            //        Viewer.Images(i).Width = WidthSlider.Value;
            //    }
            //}
            //else
            //{
            GetSelectedImage().Width = WidthSlider.Value;
            //}

            Width1.Text = WidthSlider.Value.ToString();
            Width1.Refresh();
        }

        private void EndMagnifier()
        {
            if (Zooming)
            {
                //Zooming = false;
                Viewer.Images.Remove(Viewer.Images[Viewer.Images.Count - 1]);
                ZoomImage = null;
                ZoomIndex = -1;
            }
        }

        private void SetNewMagnifier(Point p)
        {
            if (!Zooming)
                return;

            int Index = Viewer.ImageIndex(p);
            if (Index >= 0 && Index < Viewer.Images.Count)
            {
                ZoomIndex = Index;
                ZoomImage = Viewer.Images[Index].Clone(true) as DicomImage;
                ZoomImage.StretchMode = DicomObjects.Enums.StretchModes.None;
                Viewer.Images.Add(ZoomImage);
                ZoomImage.Zoom = DicomGlobal.Zoom(Viewer.Images[Index].Matrix(Viewer)) * 6;
            }
        }

        private void SetMagnifier(Point p)
        {
            if (!Zooming)
                return;

            int IMIndex = Viewer.ImageIndex(p);
            float sizef = 0.3F;
            System.Drawing.Drawing2D.Matrix mx;
            System.Drawing.Drawing2D.Matrix mZoom;

            if (IMIndex == Viewer.Images.Count - 1)
            {
                IMIndex = Viewer.ImageIndices(p)[1];
            }

            //check if you//ve moved onto a new Image
            if (IMIndex != ZoomIndex)
            {
                EndMagnifier();
                SetNewMagnifier(p);
            }

            if (IMIndex >= 0)
            {
                RectangleF Rect = new RectangleF(((float)p.X / (float)Viewer.ClientSize.Width) - (sizef / 2), ((float)p.Y / (float)Viewer.ClientSize.Height) - (sizef / 2), sizef, sizef);
                ZoomImage.Area = Rect;

                mx = Viewer.Matrix(IMIndex);
                mx.Invert();
                Point[] pts = new Point[1];
                pts[0] = p;
                mx.TransformPoints(pts);

                mZoom = Viewer.Matrix(Viewer.Images.IndexOf(ZoomImage));
                mZoom.TransformPoints(pts);

                ZoomImage.Scroll = new Point(p.X - pts[0].X + ZoomImage.Scroll.X, p.Y - pts[0].Y + ZoomImage.Scroll.Y);
            }
        }

        private void LabelUpdate()
        {
            LabelForm.ShowDialog();
            if ((MouseFunction == MouseFunctionEnums.Measure))
            {
                LabelForm.ImageScale.Checked = true;
            }
        }

        private void Level1_Leave(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Level1.Text))
            {
                LevelSlider.Value = Convert.ToInt16(Level1.Text);
            }
        }

        private void width1_Leave(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Width1.Text))
            {
                WidthSlider.Value = Convert.ToInt16(Width1.Text);
            }
        }

        private void ZoomSlider_Scroll(System.Object sender, System.EventArgs e)
        {
            double z;
            z = System.Math.Pow(2, (double)ZoomSlider.Value / (double)10);
            Zoom1.Text = z.ToString();
            Zoom1.Refresh();
            GetSelectedImage().Zoom = (float)z;
            Zoom1.Refresh();
        }

        private void Zoom_Leave(System.Object sender, System.EventArgs e)
        {
            ZoomSlider.Text = (Math.Log(Convert.ToDouble(Zoom1.Text)) / Math.Log(2) * 10).ToString();
            GetSelectedImage().Zoom = (float)Convert.ToDouble(Zoom1.Text);
        }

        private void StretchToFit_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (StretchToFit.Checked)
            {
                GetSelectedImage().StretchMode = DicomObjects.Enums.StretchModes.StretchCentred;
                ZoomSlider.Visible = false;
                ZoomLabel.Visible = false;
                Zoom1.Visible = false;
            }
            else
            {
                GetSelectedImage().StretchMode = DicomObjects.Enums.StretchModes.None;
                ZoomSlider.Visible = true;
                ZoomLabel.Visible = true;
                Zoom1.Visible = true;
            }
        }

        private void SelectBTN_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (SelectBTN.Checked)
                MouseFunction = MouseFunctionEnums.SelectImage;
        }

        private void WindowBTN_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (WindowBTN.Checked)
                MouseFunction = MouseFunctionEnums.Windowing;
        }

        private void ScrollBTN_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ScrollBTN.Checked)
                MouseFunction = MouseFunctionEnums.Scroll;
            CImageIndex.Focus();
        }

        private void AddAnnoBTN_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (AddAnnoBTN.Checked)
            {
                MouseFunction = MouseFunctionEnums.AddAnnotation;
                LabelUpdate();
            }
        }

        private void EditAnnoBTN_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (EditAnnoBTN.Checked)
                MouseFunction = MouseFunctionEnums.EditAnnotation;
        }

        private void MagnifyBTN_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (MagnifyBTN.Checked)
                MouseFunction = MouseFunctionEnums.MagnifyingGlass;
        }

        private void CropBTN_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (CropBTN.Checked)
                MouseFunction = MouseFunctionEnums.CropImage;
        }

        private void CobbBTN_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (CobbBTN.Checked)
                MouseFunction = MouseFunctionEnums.CobbMeasurement;
            ClickNum = 1;
        }

        private void ProtractorBTN_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ProtractorBTN.Checked)
                MouseFunction = MouseFunctionEnums.Protractor;
            ClickNum = 1;
        }

        private void MeasureButton_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (MeasureButton.Checked)
            {
                MouseFunction = MouseFunctionEnums.Measure;
                LabelUpdate();
            }
        }

        private void PixelButton_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (PixelButton.Checked)
                MouseFunction = MouseFunctionEnums.PixelValues;
        }

        private void NewData()
        {
            System.Text.StringBuilder g = default(System.Text.StringBuilder);
            g = new System.Text.StringBuilder(256);

            AttributeForm.AttributeList.Text = "";

            if ((Viewer.Images.Count > 0))
            {
                AppendAttributes(g, "", GetSelectedImage().DataSet);
                AttributeForm.AttributeList.Text = g.ToString();
                AttribList.Text = g.ToString();
            }
            else
            {
                AttributeForm.AttributeList.Text = "No Image available";
                AttribList.Text = "No Image available";
            }
        }

        private void LabelDrawInf(DicomObjects.DicomViewer v, DicomLabel l)
        {
            bool OrigRev = false;

            OrigRev = l.Reversible;
            l.Reversible = false;
            l.Pen = new Pen(LabelForm.ForeColour.BackColor);
            v.DrawLabel(l);
            l.Reversible = OrigRev;
        }

        private void LabelDraw(DicomObjects.DicomViewer v, DicomLabel l, double zoom)
        {
            bool OrigRev = false;
            OrigRev = l.Reversible;
            DicomObjects.Enums.LabelType OrigLabelType = default(DicomObjects.Enums.LabelType);
            OrigLabelType = l.LabelType;

            if (l.LabelType == DicomObjects.Enums.LabelType.Text)
            {
                l.LabelType = DicomObjects.Enums.LabelType.Rectangle;
            }
            l.Reversible = true;

            l.Pen = new Pen(LabelForm.ForeColour.BackColor, (float)(Convert.ToSingle(LabelForm.LineWidth.Text) / zoom));

            v.DrawLabel(l);
            l.Reversible = OrigRev;
            l.LabelType = OrigLabelType;
        }

        private double ImagezoomX(DicomImage Image)
        {

            double xratio = 0;
            double yratio = 0;
            double ZoomX = 0;
            Array Ratiovalues = default(Array);

            if (Image.DataSet[0x28, 0x34].Exists)
            {
                Ratiovalues = (Array)Image.DataSet[0x28, 0x34].Value;
                //pixel aspect ratio - variant holding the X&Y ratio values
                yratio = double.Parse(Ratiovalues.GetValue(1).ToString());
                xratio = double.Parse(Ratiovalues.GetValue(2).ToString());
                if ((xratio > yratio))
                {
                    ZoomX = Image.Zoom * (yratio / xratio);
                }
                else
                {
                    ZoomX = Image.Zoom;
                }
            }

            if (!Image.DataSet[0x28, 0x34].Exists)
            {
                ZoomX = Image.Zoom;
            }

            return ZoomX;
        }

        private double ImagezoomY(DicomImage Image)
        {
            double xratio = 0;
            double yratio = 0;
            double ZoomY = 0;
            Array Ratiovalues = default(Array);


            if (Image.DataSet[0x28, 0x34].Exists)
            {
                //First value in the variant is Y followed by X
                Ratiovalues = (Array)Image.DataSet[0x28, 0x34].Value;
                //pixel aspect ratio - variant holding the X&Y ratio values
                yratio = double.Parse(Ratiovalues.GetValue(1).ToString());
                xratio = double.Parse(Ratiovalues.GetValue(2).ToString());

                if ((xratio < yratio))
                {
                    ZoomY = Image.Zoom * (yratio / xratio);
                }
                else
                {
                    ZoomY = Image.Zoom;
                }

            }

            if (!Image.DataSet[0x28, 0x34].Exists)
            {
                ZoomY = Image.Zoom;
            }
            return ZoomY;
        }

        private double CalculateCobb(double[] CobbXYCoord)
        {
            double t1 = 0;
            double t2 = 0;
            double angle = 0;

            t1 = (CobbXYCoord[5] - CobbXYCoord[7]) / (CobbXYCoord[4] - CobbXYCoord[6]);
            t2 = (CobbXYCoord[1] - CobbXYCoord[3]) / (CobbXYCoord[0] - CobbXYCoord[2]);
            angle = Math.Atan((t1 - t2) / (1 + t1 * t2));
            if ((double.IsNaN(angle)))
            {
                angle = 90.0;
            }
            else
            {
                angle = Math.Abs((180 / Math.PI) * (angle));
                angle = Math.Round(angle, 2);
            }

            return angle;

        }

        private void AppendAttributes(System.Text.StringBuilder list, string prefix, DicomDataSet ob)
        {
            DicomObjects.DicomAttribute at;
            DicomObjects.DicomDataSetCollection s = new DicomDataSetCollection();
            int gg;
            int i;
            object v;

            for (int j = 0; j < ob.Count; j++)
            {
                at = ob[j];
                gg = at.Element;
                list.Append(prefix).Append("(").Append(at.Group.ToString("X4")).Append(",").Append(at.Element.ToString("X4")).Append(") : ");
                list.Append(at.Description.PadRight(30)).Append(": ");
                if ((at.Group == 0x7FE0)) // pixel data;

                    list.Append("Pixel data").Append("\r\n");
                else
                {
                    if (Microsoft.VisualBasic.Information.VarType(at.Value) == VariantType.Object)  // i.e. a sequence;
                    {
                        s = (DicomObjects.DicomDataSetCollection)at.Value;
                        if (s != null)
                        {
                            list.Append("Sequence of ").Append(s.Count).Append(" items:").Append("\r\n");
                            for (i = 0; i < s.Count; i++)
                            {
                                list.Append(prefix).Append(">---------------").Append("\r\n");
                                AppendAttributes(list, prefix + ">", s[i]);
                            }
                            list.Append(prefix).Append(">---------------");
                            list.Append("\r\n");
                        }
                        else
                        {
                            list.Append("\r\n");
                        }
                    }
                    else
                    {
                        v = at.Value; // could be variant or array;
                        if ((Microsoft.VisualBasic.Information.VarType(v) >= VariantType.Array))  // i.e. an array;
                        {
                            Array a = v as Array;
                            list.Append("Multiple values :");
                            list.Append("\r\n");
                            list.Append("              ");

                            if (Microsoft.VisualBasic.Information.UBound(a, 1) > 32)
                            {
                                list.Append("Array of ").Append(Microsoft.VisualBasic.Information.UBound(a, 1)).Append(" elements");
                            }
                            else
                            {
                                for (i = Microsoft.VisualBasic.Information.LBound(a, 1); i <= Microsoft.VisualBasic.Information.UBound(a, 1); i++)
                                {
                                    list.Append(a.GetValue(i));
                                    if (i != Microsoft.VisualBasic.Information.UBound(a, 1)) list.Append(" : ");
                                }
                            }
                            list.Append("\r\n");
                        }
                        else
                        {
                            if (at.VR == "DA" && Microsoft.VisualBasic.Information.VarType(v) != VariantType.Null)
                            {
                                DateTime d;
                                d = (DateTime)v;
                                list.Append(d.ToShortDateString());
                                list.Append("\r\n");
                            }
                            else
                            {
                                if (at.VR == "TM" && Microsoft.VisualBasic.Information.VarType(v) != VariantType.Null)
                                {
                                    DateTime d;
                                    d = (DateTime)v;
                                    list.Append(d.ToShortTimeString());
                                    list.Append("\r\n");
                                }
                                else
                                {
                                    list.Append(v);
                                    list.Append("\r\n");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ImageInformation_Click(System.Object sender, System.EventArgs e)
        {
            NewData();
            AttributeForm.ShowDialog();
        }

        public DicomLabel MarkerLabel(DicomImage Image)
        {

            DicomLabel label = new DicomLabel();
            label = Image.Labels.AddNew();
            RectangleF A = default(RectangleF);
            SizeF S = default(SizeF);

            label.LabelType = DicomObjects.Enums.LabelType.Special;

            label.ScaleMode = DicomObjects.Enums.ScaleMode.Image;
            label.ScaleFontSize = false;
            A = new RectangleF();
            S.Width = 200;
            S.Height = 200;
            A.Size = S;
            label.Area = A;

            label.TextBrush = Brushes.Red;
            label.Margin = 2;
            return label;
        }

        private void UpdateMarkers()
        {
            DicomLabel l;

            foreach (DicomImage Image in Viewer.Images)
            {
                // remove existing markers
                for (int i = Image.Labels.Count - 1; i > 0; i--)
                {
                    l = Image.Labels[i];
                    if (l.LabelType == DicomObjects.Enums.LabelType.Special)
                    {
                        Image.Labels.Remove(l);
                    }
                }

                if (AnatomicMarkers.Checked)
                {
                    l = MarkerLabel(Image);
                    l.Left = 0;
                    l.Top = Image.Size.Height / 2;
                    l.Text = "LEFT";

                    l = MarkerLabel(Image);
                    l.Left = Image.Size.Width / 2;
                    l.Top = 0;
                    l.Text = "TOP";

                    l = MarkerLabel(Image);
                    l.Left = Image.Size.Width - 30;
                    l.Top = Image.Size.Height / 2;
                    l.Text = "RIGHT";

                    l = MarkerLabel(Image);
                    l.Left = Image.Size.Width / 2;
                    l.Top = Image.Size.Height - 50;
                    l.Text = "BOTTOM";

                    Image.Update();
                }
            }
        }

        private void MakeNewImage_Click(System.Object sender, System.EventArgs e)
        {
            DicomObjects.DicomImage Image = new DicomImage();
            int s = 513;
            int r = 256;
            byte[,] Pixel = new byte[s, s];
            int i, j;

            Image.Name = "Test Image";
            Image.InstanceUID = DicomObjects.DicomGlobal.NewUID();
            Image.PatientID = "Test Image 001";
            Image.AccessionNumber = "1";

            Image.DataSet.Add(0x0008, 0x0016, DicomObjects.DicomUIDs.SOPClasses.SecondaryCapture);
            Image.DataSet.Add(0x0028, 0x0002, 1);			  //  samples/pixel
            Image.DataSet.Add(0x0028, 0x0004, "MONOCHROME2"); // photometric interpreation
            Image.DataSet.Add(0x0028, 0x0010, s);			  // X
            Image.DataSet.Add(0x0028, 0x0011, s);			  // Y
            Image.DataSet.Add(0x0028, 0x0100, 8);			  // bits allocated;
            Image.DataSet.Add(0x0028, 0x0101, 8);			  // bits stored;
            Image.DataSet.Add(0x0028, 0x0102, 7);			  // high bit;

            for (i = 1; i < s; i++)
            {
                for (j = 1; j < s; j++)
                {
                    Pixel[i, j] = Convert.ToByte(((i + j) / 2) / 256);
                }
            }

            for (i = -r; i <= r; i++)
            {
                for (j = -r; j <= r; j++)
                {
                    if ((i * i + j * j) < (r * r))
                    {
                        Pixel[i + s / 2, j + s / 2] = Convert.ToByte(Math.Sqrt(((double)(i * i + j * j)) / ((double)(r * r))) * 255);
                    }
                }
            }
            Image.DataSet.Add(0x7FE0, 0x0010, Pixel);
            Viewer.Images.Add(Image);
        }

        private void Rows_ValueChanged(System.Object sender, System.EventArgs e)
        {
            if (!isInitializing)
            {
                Viewer.MultiRows = (short)Convert.ToInt32(Rows.Value);
            }
        }

        private void Columns_ValueChanged(System.Object sender, System.EventArgs e)
        {
            if (!isInitializing)
            {
                Viewer.MultiColumns = (short)Convert.ToInt32(Columns.Value);
            }
        }

        private void UnSmoothedMin_Click(System.Object sender, System.EventArgs e)
        {
            if (Viewer.Images.Count > 0)
            {
                //Viewer.CurrentImage.MinificationMode = doFilterMode.doFilterReplicate
            }
        }

        private void MAverage_Click(System.Object sender, System.EventArgs e)
        {
            if (Viewer.Images.Count > 0)
            {
                //Viewer.CurrentImage.MinificationMode = doFilterMode.doFilterMovingAverage
            }
        }

        private void UnSmoothedMag_Click(System.Object sender, System.EventArgs e)
        {
            if (Viewer.Images.Count > 0)
            {
                //Viewer.CurrentImage.MagnificationMode = doFilterMode.doFilterReplicate
            }
        }

        private void CSpline_Click(System.Object sender, System.EventArgs e)
        {
            if (Viewer.Images.Count > 0)
            {
                //Viewer.CurrentImage.MagnificationMode = doFilterMode.doFilterCubicSpline
            }
        }

        private void BSpline_Click(System.Object sender, System.EventArgs e)
        {
            if (Viewer.Images.Count > 0)
            {
                //Viewer.CurrentImage.MagnificationMode = doFilterMode.doFilterBSpline
            }
        }

        private void Import_Click(System.Object sender, System.EventArgs e)
        {
            OpenFileDialog.FileName = "";
            OpenFileDialog.Filter = "Pictures & Cine (*.bmp,*.dib,*.jpg,*.avi)|*.bmp;*.dib;*.jpg;*.avi";
            if ((OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                DicomImage i = new DicomImage();

                i.Import(OpenFileDialog.FileName);
                Viewer.Images.Add(i);
            }
        }

        private void Export_Click(System.Object sender, System.EventArgs e)
        {
            string Filename = null;
            SaveFileDialog.FileName = "";

            if ((GetSelectedImage().FrameCount > 1))
            {
                SaveFileDialog.Filter = "AVI (*.avi)|*.avi|Windows Bitmap(*.bmp)|*.bmp|JPeg(*.jpg)|*.jpg";
            }
            else
            {
                SaveFileDialog.Filter = "Windows Bitmap(*.bmp)|*.bmp|JPeg(*.jpg)|*.jpg";
            }

            if ((SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                Filename = SaveFileDialog.FileName;
                if ((Filename.Substring(Filename.Length - 3, 3).ToUpper() == "AVI"))
                {
                    // AVI output is NOT quite yet working at the moment
                    //GetSelectedImage().WriteAVI(Filename, 1, GetSelectedImage().FrameCount, 1, "", 90, True)
                }
                else
                {
                    // Save as JPEG for example
                    GetSelectedImage().Bitmap().Save(Filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void Copy_Click(System.Object sender, System.EventArgs e)
        {
            if (Viewer.Images.Count > 0)
            {
                //GetSelectedImage().Copy()
            }
        }

        private void Paste_Click(System.Object sender, System.EventArgs e)
        {
            DicomImage i = new DicomImage();
            //i.Paste()
            Viewer.Images.Add(i);
        }

        private void DeleteSelected_Click(System.Object sender, System.EventArgs e)
        {

            if (Viewer.Images.Count > 0)
            {
                if (CImageIndex.Value > 0)
                {
                    CImageIndex.Value = CImageIndex.Value - 1;
                }
                else
                {
                    CImageIndex.Value = 0;
                }
                Viewer.Images.Remove(GetSelectedImage());
                CImageIndex.Maximum = Viewer.Images.Count - 1;
                SelectedImage = null;
                isSelectedImage = false;
            }
        }

        private void DeleteAll_Click(System.Object sender, System.EventArgs e)
        {
            Viewer.Images.Clear();
            CImageIndex.Maximum = 0;
            PatientName.Text = "";
            WidthSlider.Visible = false;
            LevelSlider.Visible = false;
            WidthLabel.Visible = false;
            LevelLabel.Visible = false;
            Width1.Visible = false;
            Level1.Visible = false;
            Zoom1.Visible = false;
            ZoomSlider.Visible = false;
            ZoomLabel.Visible = false;
            StretchToFit.Visible = false;
            Viewer.Refresh();
        }

        private void Verify_Click(System.Object sender, System.EventArgs e)
        {
            int result = 0;

            //result = DicomGlobal.Echo(strSCU.IP, Convert.ToInt32(strSCU.Port), SCU.locAET, strSCU.AET);
            MessageBox.Show("Connected to Server", "TeleRad - Client", MessageBoxButtons.OK);
            return;
        E1:

            MessageBox.Show("A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond", "TeleRad - Client", MessageBoxButtons.OK);
        }

        private void SendSelected_Click(System.Object sender, System.EventArgs e)
        {
            int Status = 0;
            if (GetSelectedImage().DataSet[0x7fe0, 0x10].Exists)
            {
                //Status = GetSelectedImage().Send(OptionsBox.StorageNode.Text, Convert.ToInt32(OptionsBox.StoragePort.Text), OptionsBox.CallingAE.Text, OptionsBox.StorageAE.Text);
                MessageBox.Show("Returned Status = " + Status.ToString());
            }
        }

        private void Options_Click(System.Object sender, System.EventArgs e)
        {
            //OptionsBox.ServerOpt = server;
            //OptionsBox.TabControl1.SelectedTab = OptionsBox.TabControl1.TabPages(3);
            //OptionsBox.ShowDialog();
        }

        private void SendAll_Click(System.Object sender, System.EventArgs e)
        {
            int res = 0;
            int i = 0;
            DicomImage im = default(DicomImage);
            if (Viewer.Images.Count == 0)
            {
                MessageBox.Show("No Images to Manipulate");
            }
            else
            {
                for (i = 0; i <= Viewer.Images.Count - 1; i++)
                {
                    im = Viewer.Images[i];
                    //res = im.Send(OptionsBox.StorageNode.Text, Convert.ToInt32(OptionsBox.StoragePort.Text), OptionsBox.CallingAE.Text, OptionsBox.StorageAE.Text)
                    //res = im.Send(strSCU.IP, Convert.ToInt32(strSCU.Port), SCU.locAET, strSCU.AET);
                    //If (res <> 0) Then
                    //    MessageBox.Show("Send failed - code " + res.ToString("X4"))
                    //    Exit Sub
                    //End If
                }
            }
        }

        private void Retrieve_Click(System.Object sender, System.EventArgs e)
        {
            //RetrieveDialog.LoadPatient(OptionsBox, Viewer);
        }

        private void DisplayNormal_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().RotateState = DicomObjects.Enums.RotateState.Normal;
            GetSelectedImage().FlipState = DicomObjects.Enums.FlipState.Normal;
        }

        private void FlipHorizontal_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().FlipState = GetSelectedImage().FlipState ^ DicomObjects.Enums.FlipState.Horizontal;
        }

        private void FlipVertical_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().FlipState = GetSelectedImage().FlipState ^ DicomObjects.Enums.FlipState.Vertical;
        }

        private void RotateClockwise_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().RotateState = (DicomObjects.Enums.RotateState)((int)GetSelectedImage().RotateState + (int)DicomObjects.Enums.RotateState.Right);
        }

        private void RotateAntiClockwise_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().RotateState = (DicomObjects.Enums.RotateState)((int)GetSelectedImage().RotateState + (int)DicomObjects.Enums.RotateState.Left);
        }

        private void ApplyPresentationState_Click(System.Object sender, System.EventArgs e)
        {
            DicomDataSetCollection Ps = new DicomDataSetCollection();

            OpenFileDialog.Multiselect = false;
            if ((OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                GetSelectedImage().PresentationState = Ps.Read(OpenFileDialog.FileName);
                Viewer_DataChanged(this);
                // to update sliders
            }
        }

        private void SavePresentationState_Click(System.Object sender, System.EventArgs e)
        {
            SaveFileDialog.FileName = "";
            if ((SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                GetSelectedImage().PresentationState.Write(SaveFileDialog.FileName, "1.2.840.10008.1.2.1", true);
            }
        }

        private void CurrentToPresentationState_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().CurrentToPresentationState(GetSelectedImage().Size, true);
        }

        private void PresentationStateToCurrent_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().PresentationStateToCurrent();
        }

        private void LogLocation_Click(System.Object sender, System.EventArgs e)
        {
            //OptionsBox.TabControl1.SelectedTab = OptionsBox.TabControl1.TabPages(5);
            //OptionsBox.ShowDialog();
        }

        private void CImageIndex_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (Viewer.Images.Count > 0 & CImageIndex.Value > -1)
            {
                Viewer.CurrentIndex = Convert.ToInt32(CImageIndex.Value);
                PatientName.Text = Viewer.Images[Viewer.CurrentIndex].Name + "";
            }
        }

        private void Rows_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Viewer.MultiRows = (short)Convert.ToInt32(Rows.Value);
        }

        private void Columns_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Viewer.MultiColumns = (short)Convert.ToInt32(Columns.Value);
        }

        private void AnatomicMarkers_Click(object sender, System.EventArgs e)
        {
            UpdateMarkers();
            Viewer.Refresh();
        }

        private void PixelValue_Click(System.Object sender, System.EventArgs e)
        {
            Viewer.CurrentImage.MinificationMode = DicomObjects.Enums.FilterMode.Replicate;
        }

        private void MovingAverage_Click(System.Object sender, System.EventArgs e)
        {
            Viewer.CurrentImage.MinificationMode = DicomObjects.Enums.FilterMode.MovingAverage;
        }

        private void Replicate_Click(System.Object sender, System.EventArgs e)
        {
            Viewer.CurrentImage.MagnificationMode = DicomObjects.Enums.FilterMode.Replicate;
        }

        private void BSpine_Click(System.Object sender, System.EventArgs e)
        {
            Viewer.CurrentImage.MagnificationMode = DicomObjects.Enums.FilterMode.BSpline;
        }

        private void CubicSpine_Click(System.Object sender, System.EventArgs e)
        {
            Viewer.CurrentImage.MagnificationMode = DicomObjects.Enums.FilterMode.CubicSpline;
        }

        private void server_InstanceReceived(object sender, DicomObjects.DicomServer.InstanceReceivedArgs e)
        {
            Viewer.Images.Add(e.Instance);
            e.Status = 0;
            Interaction.MsgBox("Image Received");
        }

        private void PrintWindows_Click(System.Object sender, System.EventArgs e)
        {
            printDoc = new System.Drawing.Printing.PrintDocument();
            printDoc.OriginAtMargins = false;
            printDoc.DefaultPageSettings.Landscape = true;
            printDoc.PrinterSettings.Copies = 1;
            printDoc.Print();
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DicomImage pImage = default(DicomImage);
            Rectangle area = new Rectangle(0, 0, 0, 0);
            pImage = Viewer.CurrentImage.PrinterImage(Convert.ToInt32(Viewer.CurrentImage.DataSet[0x28, 0x100].Value), 1, true, (float)(0.75), area, true);
            System.Drawing.Image printimage = pImage.Bitmap();
            e.Graphics.DrawImage(printimage, 0, 0);
        }

        private void CineModeForward_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().CineMode = DicomObjects.Enums.CineMode.Forward;
        }

        private void CineModeRepeat_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().CineMode = DicomObjects.Enums.CineMode.Repeat;
        }

        private void CineModeOscillate_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().CineMode = DicomObjects.Enums.CineMode.Oscillate;
        }

        private void CineModeRepeatReverse_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().CineMode = DicomObjects.Enums.CineMode.RepeatReverse;
        }

        private void CineModeReverse_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().CineMode = DicomObjects.Enums.CineMode.Reverse;
        }

        private void CineModeStatic_Click(System.Object sender, System.EventArgs e)
        {
            GetSelectedImage().CineMode = DicomObjects.Enums.CineMode.Static;
        }

        private void Viewer_DataChanged(object sender)
        {
            bool PreState;
            Rows.Value = Viewer.MultiRows;
            Columns.Value = Viewer.MultiColumns;
            CImageIndex.Maximum = Viewer.Images.Count - 1;

            if (Viewer.Images.Count > 0)
            {
                CImageIndex.Value = Viewer.CurrentIndex;
                PatientName.Text = GetSelectedImage().Name + "";
                PreState = !(GetSelectedImage().PresentationState == null);
                Zoom1.Visible = (!PreState) && (GetSelectedImage().StretchMode == DicomObjects.Enums.StretchModes.None);
                ZoomSlider.Visible = Zoom1.Visible;
                ZoomLabel.Visible = ZoomSlider.Visible;
                StretchToFit.Visible = !PreState;
                StretchToFit.Checked = GetSelectedImage().StretchMode != DicomObjects.Enums.StretchModes.None;

                DicomImage im;
                im = GetSelectedImage();

                if (PreState || im.DataSet[0x0028, 0x3010].Exists)
                {
                    WidthSlider.Visible = false;
                    LevelSlider.Visible = false;
                    WidthLabel.Visible = false;
                    LevelLabel.Visible = false;
                    Width1.Visible = false;
                    Level1.Visible = false;

                }
                else
                {
                    WidthSlider.Visible = true;
                    LevelSlider.Visible = true;
                    WidthLabel.Visible = true;
                    LevelLabel.Visible = true;
                    Width1.Visible = true;
                    Level1.Visible = true;

                    float max, min;
                    float cen = 0;
                    im.GetMinAndMax(out min, out max, cen, true);

                    WidthSlider.Maximum = (int)((max - min) * 1.5);
                    WidthSlider.Minimum = (int)min;
                    WidthSlider.Value = (int)GetSelectedImage().Width;
                    Width1.Text = WidthSlider.Value.ToString();

                    LevelSlider.Maximum = (int)max;
                    LevelSlider.Minimum = (int)min;
                    LevelSlider.Value = (int)GetSelectedImage().Level;
                    Level1.Text = LevelSlider.Value.ToString();
                }
            }
            else
            {
                WidthSlider.Visible = false;
                WidthLabel.Visible = false;
                Width1.Visible = false;
                LevelSlider.Visible = false;
                LevelLabel.Visible = false;
                Level1.Visible = false;
                ZoomSlider.Visible = false;
                Zoom1.Visible = false;
                ZoomLabel.Visible = false;
                StretchToFit.Visible = false;
                PatientName.Text = "";
            }
            NewData();
            UpdateMarkers();
        }

        private void Viewer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            bool ViewerLabels = false;
            bool ImageCellLabels = false;
            bool ImageTiedLabels = false;
            double crossproduct = 0;
            double cosang = 0;
            double diffx1 = 0;
            double diffy1 = 0;
            double diffy3 = 0;
            double diffx3 = 0;
            double ang = 0;
            bool leftoflabel = false;
            bool abovelabel = false;
            int labelcentreX = 0;
            int labelcentreY = 0;
            RectangleF A = default(RectangleF);
            SizeF S = default(SizeF);
            Point p = new Point(e.X, e.Y);
            int i = 0;
            i = Viewer.ImageIndex(p);

            switch (MouseFunction)
            {

                case MouseFunctionEnums.SelectImage:
                    if ((i < 0))
                    {
                        if (isSelectedImage)
                        {
                            isSelectedImage = false;
                            SelectedImage.BorderPen.Width = 0;
                            SelectedImage = null;
                        }
                    }

                    if ((i >= 0 & i < Viewer.Images.Count))
                    {
                        if ((isSelectedImage))
                        {
                            SelectedImage.BorderPen.Width = 0;
                        }
                        SelectedImage = Viewer.Images[i];
                        isSelectedImage = true;
                        SelectedImage.BorderPen.Width = 1;
                        SelectedImage.BorderPen.Color = Color.Red;
                    }
                    Viewer.Refresh();

                    break;
                case MouseFunctionEnums.Windowing:
                    if (Viewer.Images.Count > 0)
                    {
                        if ((i >= 0 & i <= Viewer.Images.Count - 1))
                        {
                            WindowedImage = Viewer.Images[i];
                            BaseX = WindowedImage.Width - e.X;
                            BaseY = WindowedImage.Level + e.Y;
                            MiniMode = GetSelectedImage().MinificationMode;
                            MagMode = GetSelectedImage().MagnificationMode;
                            GetSelectedImage().MinificationMode = DicomObjects.Enums.FilterMode.Replicate;
                            GetSelectedImage().MagnificationMode = DicomObjects.Enums.FilterMode.Replicate;
                        }
                    }

                    break;
                case MouseFunctionEnums.Scroll:
                    if ((i >= 0 & i <= Viewer.Images.Count - 1))
                    {
                        ScrolledImage = Viewer.Images[i];
                        BaseX = e.X - ScrolledImage.Scroll.X;
                        BaseY = e.Y - ScrolledImage.Scroll.Y;
                    }

                    break;
                case MouseFunctionEnums.AddAnnotation:
                case MouseFunctionEnums.Measure:
                    if ((LabelSelected))
                    {
                        CurrentLabel.SelectMode = DicomObjects.Enums.SelectMode.None;
                        LabelSelected = false;
                    }

                    CurrentLabel = new DicomLabel();
                    CurrentLabel.LabelType = LabelForm.labelType;
                    CurrentLabel.TextBrush = new SolidBrush(LabelForm.ForeColour.BackColor);
                    CurrentLabel.Font = LabelForm.fontDialog1.Font;

                    CurrentLabel.Pen = new Pen(LabelForm.ForeColour.BackColor, Convert.ToInt16(LabelForm.LineWidth.Text));

                    string ss = LabelForm.ForeColour.ForeColor.ToString();
                    CurrentLabel.ShowTextBox = false;

                    if (!LabelForm.Transparent.Checked)
                    {
                        CurrentLabel.Brush = new SolidBrush(LabelForm.BackColour.BackColor);
                    }

                    LabelDrawing = true;

                    CurrentLabel.Left = e.X;
                    CurrentLabel.Top = e.Y;

                    x1 = e.X;
                    y1 = e.Y;
                    CurrentLabel.AddPoint(e.X, e.Y);

                    InfoLabel = new DicomLabel();
                    Viewer.Labels.Add(CurrentLabel);
                    Viewer.Labels.Add(InfoLabel);

                    break;
                case MouseFunctionEnums.EditAnnotation:
                    // Left Mouse button Pressed
                    if ((e.Button == System.Windows.Forms.MouseButtons.Left))
                    {
                        ViewerLabels = true;
                        ImageCellLabels = true;
                        ImageTiedLabels = true;

                        DicomLabelCollection LabelList = new DicomLabelCollection();
                        SelectedImage = Viewer.Images[i];

                        LabelList = Viewer.LabelHits(p, false, true);

                        if ((LabelSelected))
                        {
                            CurrentLabel.SelectMode = DicomObjects.Enums.SelectMode.None;
                            CurrentLabel = new DicomLabel();
                            LabelSelected = false;
                        }

                        if ((LabelList.Count > 0))
                        {
                            //The line below can be modified to refer to any label within the collection
                            //This example selects the first label within the collection
                            CurrentLabel = LabelList[0];
                            CurrentLabel.SelectPen = Pens.Green;

                            if (CurrentLabel.LabelType == DicomObjects.Enums.LabelType.Polygon || CurrentLabel.LabelType == DicomObjects.Enums.LabelType.PolyLine)
                                CurrentLabel.SelectMode = DicomObjects.Enums.SelectMode.AllHandles;
                            else
                                CurrentLabel.SelectMode = DicomObjects.Enums.SelectMode.AllHandles | DicomObjects.Enums.SelectMode.Box | DicomObjects.Enums.SelectMode.BoxHandles;

                            LabelSelected = true;
                            LabelPoints = CurrentLabel.Points;
                        }
                    }

                    //right mouse button. Initialise conditions for Resizelabel
                    if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    {
                        InitialX = e.X;
                        InitialY = e.Y;

                        // record the initial position
                        InitialHeight = CurrentLabel.Area.Size.Height;
                        InitialWidth = CurrentLabel.Area.Size.Width;
                        InitialLeft = CurrentLabel.Area.X;
                        InitialTop = CurrentLabel.Area.Y;

                        // defining the centre of a label not tied to the image
                        labelcentreX = (int)(CurrentLabel.Area.X + CurrentLabel.Area.Size.Width / 2);
                        labelcentreY = (int)(CurrentLabel.Area.Y + CurrentLabel.Area.Size.Height / 2);

                        leftoflabel = false;
                        abovelabel = false;

                        if (e.X < labelcentreX)
                            leftoflabel = true;

                        if (e.Y > labelcentreY)
                            abovelabel = true;

                        if (CurrentLabel.Width < 0)
                            leftoflabel = !leftoflabel;

                        if (CurrentLabel.Height < 0)
                            abovelabel = !abovelabel;

                        if (leftoflabel && !abovelabel)
                            LabelEdge = LabelEdgeType.TopLeft;

                        if (leftoflabel && abovelabel)
                            LabelEdge = LabelEdgeType.BottomLeft;

                        if (!leftoflabel && !abovelabel)
                            LabelEdge = LabelEdgeType.TopRight;

                        if (!leftoflabel && abovelabel)
                            LabelEdge = LabelEdgeType.BottomRight;
                    }

                    //Middle mouse button pressed
                    if ((e.Button == System.Windows.Forms.MouseButtons.Middle))
                    {
                        InitialX = e.X;
                        InitialY = e.Y;
                        LabelPoints = CurrentLabel.Points;
                    }

                    break;
                case MouseFunctionEnums.MagnifyingGlass:

                    if ((i >= 0 & i < Viewer.Images.Count))
                    {
                        Zooming = true;
                        Point p1 = new Point(e.X, e.Y);
                        SetNewMagnifier(p1);
                        SetMagnifier(p1);
                    }

                    break;
                case MouseFunctionEnums.CropImage:
                    // Specifies a rectangular area on image.
                    //An image matching the area encaptured by the rectangle is created and added to the viewer as a new image. 
                    CurrentLabel = new DicomLabel();
                    SelectedImage = Viewer.Images[i];
                    LabelDrawing = true;
                    CurrentLabel.LabelType = DicomObjects.Enums.LabelType.Rectangle;
                    CurrentLabel.Pen = new Pen(Color.Red, Convert.ToInt16(LabelForm.LineWidth.Text));
                    CurrentLabel.Left = e.X;
                    CurrentLabel.Top = e.Y;
                    CurrentLabel.AddPoint(e.X, e.Y);
                    Viewer.Labels.Add(CurrentLabel);

                    break;
                case MouseFunctionEnums.CobbMeasurement:
                    //records the x,y position values of the mouse pointer when the Viewer's been clicked
                    //works if aspect ratio is 1/1
                    switch (ClickNum)
                    {
                        case 1:
                            {
                                CobbCoord[0] = e.X;
                                CobbCoord[1] = e.Y;
                                ClickNum = 2;
                                break;
                            }

                        case 2:
                            {
                                CobbCoord[2] = e.X;
                                CobbCoord[3] = e.Y;
                                ClickNum = 3;
                                // draw line1
                                CurrentLabel = new DicomLabel();
                                CurrentLabel.LabelType = DicomObjects.Enums.LabelType.Line;
                                CurrentLabel.Top = (short)CobbCoord[1];
                                CurrentLabel.Left = (short)CobbCoord[0];
                                CurrentLabel.Height = (short)(CobbCoord[3] - CobbCoord[1]);
                                CurrentLabel.Width = (short)(CobbCoord[2] - CobbCoord[0]);
                                CurrentLabel.Pen = new Pen(System.Drawing.Color.Red, 1);
                                Viewer.Labels.Add(CurrentLabel);
                                Viewer.Refresh();
                                break;
                            }

                        case 3:
                            {
                                CobbCoord[4] = e.X;
                                CobbCoord[5] = e.Y;
                                ClickNum = 4;
                                break;
                            }

                        case 4:
                            {
                                CobbCoord[6] = e.X;
                                CobbCoord[7] = e.Y;
                                ClickNum = 1;
                                // draw line2
                                CurrentLabel = new DicomLabel();
                                CurrentLabel.LabelType = DicomObjects.Enums.LabelType.Line;
                                CurrentLabel.Top = (short)CobbCoord[5];
                                CurrentLabel.Left = (short)CobbCoord[4];
                                CurrentLabel.Height = (short)(CobbCoord[7] - CobbCoord[5]);
                                CurrentLabel.Width = (short)(CobbCoord[6] - CobbCoord[4]);
                                CurrentLabel.Pen = new Pen(System.Drawing.Color.Red, 1);
                                Viewer.Labels.Add(CurrentLabel);
                                Viewer.Refresh();
                                // calculate the angle between line1 and line2
                                double ang1;

                                ang1 = CalculateCobb(CobbCoord);
                                MessageBox.Show("The angle is " + ang1.ToString() + "°");
                                break;
                            }
                    }

                    break;
                case MouseFunctionEnums.Protractor:
                    //records the x,y position values of the mouse pointer when the mouse button is clicked on the image
                    //first(Point)

                    if ((LabelSelected))
                    {
                        CurrentLabel.SelectMode = DicomObjects.Enums.SelectMode.None;
                        LabelSelected = false;
                    }

                    switch (ClickNum)
                    {
                        case 1:
                            XYCoord[0] = e.X;
                            XYCoord[1] = e.Y;
                            ClickNum = 2;
                            break;

                        //second point
                        case 2:
                            XYCoord[2] = e.X;
                            XYCoord[3] = e.Y;
                            //draws a line between the first and second point
                            CurrentLabel = new DicomLabel();
                            CurrentLabel.LabelType = DicomObjects.Enums.LabelType.Line;
                            CurrentLabel.Top = (short)XYCoord[1];
                            CurrentLabel.Left = (short)XYCoord[0];
                            CurrentLabel.Height = (short)(XYCoord[3] - XYCoord[1]);
                            CurrentLabel.Width = (short)(XYCoord[2] - XYCoord[0]);
                            CurrentLabel.Pen = Pens.Red;
                            Viewer.Labels.Add(CurrentLabel);
                            Viewer.Refresh();
                            ClickNum = 3;
                            break;

                        //third point
                        case 3:

                            XYCoord[4] = e.X;
                            XYCoord[5] = e.Y;
                            //draws a line between the second and third point
                            CurrentLabel = new DicomLabel();
                            CurrentLabel.LabelType = DicomObjects.Enums.LabelType.Line;
                            CurrentLabel.Top = (short)XYCoord[5];
                            CurrentLabel.Left = (short)XYCoord[4];
                            CurrentLabel.Height = (short)(XYCoord[3] - XYCoord[5]);
                            CurrentLabel.Width = (short)(XYCoord[2] - XYCoord[4]);
                            CurrentLabel.Pen = Pens.Red;
                            Viewer.Labels.Add(CurrentLabel);
                            Viewer.Refresh();
                            //creates two vector cooridnates
                            diffx1 = (double)(XYCoord[0] - XYCoord[2]);
                            diffy1 = (double)(XYCoord[1] - XYCoord[3]);
                            diffx3 = (double)(XYCoord[4] - XYCoord[2]);
                            diffy3 = (double)(XYCoord[5] - XYCoord[3]);

                            //calculates the angle between the two vectors
                            crossproduct = (double)((diffx1 * diffx3) + (diffy1 * diffy3));
                            cosang = (double)(crossproduct / (Math.Sqrt((diffx1 * diffx1) + (diffy1 * diffy1)) * Math.Sqrt((diffx3 * diffx3) + (diffy3 * diffy3))));

                            //calculates the inverse cosine and converts the ang from radians into degrees
                            ang = (double)((180 / Math.PI) * (Math.Atan(-cosang / Math.Sqrt(1 - cosang * cosang)) + 2 * Math.Atan(1)));

                            //displayes the angle between the 2 vectors as a label that is positioned between the vectors.
                            CurrentLabel = new DicomLabel();
                            CurrentLabel.LabelType = DicomObjects.Enums.LabelType.Text;
                            CurrentLabel.TextBrush = Brushes.Yellow;

                            CurrentLabel.Top = (short)((XYCoord[1] + XYCoord[5]) / 2);
                            CurrentLabel.Left = (short)(((XYCoord[0] + XYCoord[4]) / 2) - 53);
                            CurrentLabel.Height = 20;
                            CurrentLabel.Width = 100;
                            CurrentLabel.Text = String.Format("{0:F2}", ang) + "  Deg";
                            Viewer.Labels.Add(CurrentLabel);
                            Viewer.Refresh();
                            ClickNum = 1;
                            break;
                    }
                    break;
            }
        }

        private void Viewer_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            int Index = Viewer.ImageIndex(p);

            if (Index < 0) return;

            float OffsetX, OffsetY;
            OffsetY = e.Y - InitialY;
            OffsetX = e.X - InitialX;

            if (e.Button > 0)
            {
                switch (MouseFunction)
                {
                    case MouseFunctionEnums.Windowing:
                        if (WindowedImage != null)
                        {
                            WindowedImage.Width = BaseX + e.X * 3;
                            WindowedImage.Level = BaseY + e.Y * 3;
                        }
                        break;

                    case MouseFunctionEnums.Scroll:
                        Point sp = new Point(e.X - (int)BaseX, e.Y - (int)BaseY);
                        ScrolledImage.Scroll = sp;
                        break;

                    case MouseFunctionEnums.AddAnnotation:
                    case MouseFunctionEnums.Measure:
                    case MouseFunctionEnums.CropImage:
                        if (LabelDrawing)
                        {
                            RectangleF A = new RectangleF();
                            SizeF S = new SizeF();
                            A = CurrentLabel.Area;
                            S.Width = e.X - A.Left;
                            S.Height = e.Y - A.Top;
                            A.Size = S;
                            CurrentLabel.Area = A;

                            CurrentLabel.AddPoint(e.X, e.Y);

                            if (MouseFunction == MouseFunctionEnums.Measure)
                            {
                                Point labeltop = new Point(Convert.ToInt32(CurrentLabel.Left), Convert.ToInt32(CurrentLabel.Top));

                                // Get the current image
                                DicomImage tempDI = Viewer.Images[Viewer.ImageIndex(labeltop)];

                                if (CurrentLabel.LabelType == DicomObjects.Enums.LabelType.Line || CurrentLabel.LabelType == DicomObjects.Enums.LabelType.PolyLine)
                                    InfoLabel.Text = CurrentLabel.ROILength(Viewer, Viewer.ImageIndex(labeltop)).ToString("####.#") + " " + CurrentLabel.ROIDistanceUnits(Viewer, Viewer.ImageIndex(labeltop));
                                else
                                    InfoLabel.Text = "";

                                InfoLabel.TextBrush = new SolidBrush(LabelForm.ForeColour.BackColor);
                                InfoLabel.Font = LabelForm.fontDialog1.Font;

                                InfoLabel.Pen = new Pen(LabelForm.ForeColour.ForeColor, Convert.ToInt16(LabelForm.LineWidth.Text));
                                InfoLabel.ShowTextBox = false;

                                if (!LabelForm.Transparent.Checked)
                                    InfoLabel.Brush = new SolidBrush(LabelForm.BackColour.BackColor);

                                InfoLabel.Width = 100;
                                InfoLabel.Height = 100;
                                InfoLabel.Top = e.Y - 10;
                                InfoLabel.Left = e.X;

                                InfoLabel.AddPoint(e.X, e.Y);
                            }
                        }
                        break;
                    case MouseFunctionEnums.EditAnnotation:
                        if (!LabelSelected)
                            return;

                        OffsetX = e.X - InitialX;
                        OffsetY = e.Y - InitialY;
                        if (e.Button == MouseButtons.Right)
                        {
                            // To move polyline and polygone within the viewer all points forming the label have to be read into a variant
                            //if label is a polyline(4) or Polygone(5) then each of the points forming the label need to be moved. 
                            if (CurrentLabel.LabelType == DicomObjects.Enums.LabelType.PolyLine || CurrentLabel.LabelType == DicomObjects.Enums.LabelType.Polygon)
                            {
                                for (int i = 0; i < CurrentLabel.Points.Length; i++)
                                {
                                    CurrentLabel.Points[i].X = CurrentLabel.Points[i].X + OffsetX;
                                    CurrentLabel.Points[i].Y = CurrentLabel.Points[i].Y + OffsetY;
                                }
                            }
                            else // other label types, text, rectangle, etc.
                            {
                                CurrentLabel.Left = CurrentLabel.Left + OffsetX;
                                CurrentLabel.Top = CurrentLabel.Top + OffsetY;
                            }

                            InitialX = e.X;
                            InitialY = e.Y;
                            Viewer.Refresh();
                        }

                        if (e.Button == MouseButtons.Middle)
                        {
                            switch (LabelEdge)
                            {
                                case LabelEdgeType.BottomRight:
                                    RectangleF A = new RectangleF();
                                    SizeF S = new SizeF();
                                    A = CurrentLabel.Area;
                                    S.Width = InitialWidth + OffsetX;
                                    S.Height = InitialHeight + OffsetY;
                                    A.Size = S;
                                    CurrentLabel.Area = A;
                                    break;

                                case LabelEdgeType.BottomLeft:
                                    RectangleF A1 = new RectangleF();
                                    SizeF S1 = new SizeF();
                                    A1 = CurrentLabel.Area;
                                    A1.X = InitialLeft + OffsetX;
                                    S1.Width = InitialWidth - OffsetX;
                                    S1.Height = InitialHeight + OffsetY;
                                    A1.Size = S1;
                                    CurrentLabel.Area = A1;
                                    break;

                                case LabelEdgeType.TopRight:
                                    RectangleF A2 = new RectangleF();
                                    SizeF S2 = new SizeF();
                                    A2 = CurrentLabel.Area;
                                    A2.Y = InitialTop + OffsetY;
                                    S2.Width = InitialWidth + OffsetX;
                                    S2.Height = InitialHeight - OffsetY;
                                    A2.Size = S2;
                                    CurrentLabel.Area = A2;
                                    break;

                                case LabelEdgeType.TopLeft:
                                    RectangleF A3 = new RectangleF();
                                    SizeF S3 = new SizeF();
                                    A3 = CurrentLabel.Area;
                                    A3.Y = InitialTop + OffsetY;
                                    A3.X = InitialLeft + OffsetX;
                                    S3.Width = InitialWidth - OffsetX;
                                    S3.Height = InitialHeight - OffsetY;
                                    A3.Size = S3;
                                    CurrentLabel.Area = A3;
                                    break;
                            }
                        }
                        break;
                    case MouseFunctionEnums.MagnifyingGlass:
                        Point p3 = new Point(e.X, e.Y);
                        SetMagnifier(p3);
                        break;

                    case MouseFunctionEnums.PixelValues:
                        DicomLabel l = new DicomLabel();
                        l.LabelType = DicomObjects.Enums.LabelType.Rectangle;

                        l.Left = e.X;
                        l.Top = e.Y;
                        l.Width = 1;
                        l.Height = 1;

                        l.Rescale(Viewer, Index, DicomObjects.Enums.ScaleMode.Image);
                        Displayvalues.Text = "[X : " + e.X.ToString() + ",  Y : " + e.Y.ToString() + "] -- Pixel Value : " + l.ROIMean(Viewer.Images[Index], true).ToString();
                        Displayvalues.Refresh();
                        break;
                } // end switch
            }
        }

        private void Viewer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            WindowedImage = null;
            ScrolledImage = null;
            Displayvalues.Text = "";

            if (MouseFunction == MouseFunctionEnums.Windowing)
            {
                Viewer.CurrentImage.MinificationMode = MiniMode;
                Viewer.CurrentImage.MagnificationMode = MagMode;
            }

            if (MouseFunction == MouseFunctionEnums.MagnifyingGlass && Zooming)
            {
                EndMagnifier();
                Zooming = false;
            }

            if (MouseFunction == MouseFunctionEnums.CropImage)
            {
                LabelDrawing = false;
                Point offset = new Point((int)CurrentLabel.Left, (int)CurrentLabel.Top);
                Size pSize = new Size((int)CurrentLabel.Width, (int)CurrentLabel.Height);
                DicomImage CroppedImage = SelectedImage.SubImage(offset, pSize, 1.0F, 1);
                Viewer.Images.Add(CroppedImage);
                Viewer.Labels.Clear();
            }

            if (MouseFunction == MouseFunctionEnums.EditAnnotation && LabelSelected)
            {
                // Important for labelmove, re-initialises label positions after a label move event
                InitialTop = CurrentLabel.Area.Y;
                InitialLeft = CurrentLabel.Area.X;
                InitialHeight = CurrentLabel.Area.Size.Height;
                InitialWidth = CurrentLabel.Area.Size.Width;
                LabelPoints = (CurrentLabel.Points);
            }

            if (MouseFunction == MouseFunctionEnums.AddAnnotation || MouseFunction == MouseFunctionEnums.Measure)
            {
                LabelDrawing = false;
                Point p1 = new Point((int)CurrentLabel.Left, (int)CurrentLabel.Top);

                if (LabelForm.Control.Checked) // Attach CurrentLabel to Viewer
                {
                    Viewer.Labels.Add(CurrentLabel);
                }
                else // Attach CurrentLabel to Target Image
                {
                    Point p = new Point((int)CurrentLabel.Left, (int)CurrentLabel.Top);
                    DicomImage im = Viewer.Images[Viewer.ImageIndex(p)];
                    Viewer.Labels.Remove(CurrentLabel);
                    CurrentLabel.Rescale(Viewer, Viewer.ImageIndex(p), LabelForm.ScaleMode);

                    im.Labels.Add(CurrentLabel);

                    if (MouseFunction == MouseFunctionEnums.Measure)
                    {
                        if (CurrentLabel.LabelType == DicomObjects.Enums.LabelType.Line || CurrentLabel.LabelType == DicomObjects.Enums.LabelType.PolyLine)
                        {
                            Point labeltop = new Point(Convert.ToInt32(CurrentLabel.Left), Convert.ToInt32(CurrentLabel.Top));
                            InfoLabel.Text = CurrentLabel.ROILength(Viewer, Viewer.ImageIndex(labeltop)).ToString("####.#") + " " + CurrentLabel.ROIDistanceUnits(Viewer, Viewer.ImageIndex(labeltop));
                            InfoLabel.AddPoint(InfoLabel.Top, InfoLabel.Left);
                            InfoLabel.ScaleMode = DicomObjects.Enums.ScaleMode.Image;
                        }
                        else
                        {
                            if (CurrentLabel.LabelType == DicomObjects.Enums.LabelType.Polygon || CurrentLabel.LabelType == DicomObjects.Enums.LabelType.Rectangle || CurrentLabel.LabelType == DicomObjects.Enums.LabelType.Ellipse)
                            {
                                MessageBox.Show(CurrentLabel.ROIArea(Viewer, Viewer.CurrentIndex) + " square " + CurrentLabel.ROIDistanceUnits(im).ToString());
                                MessageBox.Show("Mean value = " + CurrentLabel.ROIMean(im, true).ToString());
                            }
                        }
                    }
                }

                if (CurrentLabel.LabelType == DicomObjects.Enums.LabelType.Text)
                {
                    CurrentLabel.Font = LabelForm.fontDialog1.Font;
                    CurrentLabel.Text = Microsoft.VisualBasic.Interaction.InputBox("Enter Label Text", "TeleRad - Report Client", "", 500, 500);
                }
                CurrentLabel = null;
            }
        }

        private void server_VerifyReceived(object sender, DicomObjects.DicomServer.VerifyReceivedArgs e)
        {
            e.Status = 0;
        }

        private void LevelSlider_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MiniMode = GetSelectedImage().MinificationMode;
            MagMode = GetSelectedImage().MagnificationMode;
            GetSelectedImage().MinificationMode = DicomObjects.Enums.FilterMode.Replicate;
            GetSelectedImage().MagnificationMode = DicomObjects.Enums.FilterMode.Replicate;
        }

        private void LevelSlider_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            GetSelectedImage().MinificationMode = MiniMode;
            GetSelectedImage().MagnificationMode = MagMode;
        }

        private void WidthSlider_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MiniMode = GetSelectedImage().MinificationMode;
            MagMode = GetSelectedImage().MagnificationMode;
            GetSelectedImage().MinificationMode = DicomObjects.Enums.FilterMode.Replicate;
            GetSelectedImage().MagnificationMode = DicomObjects.Enums.FilterMode.Replicate;
        }

        private void WidthSlider_MouseUp(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            GetSelectedImage().MinificationMode = MiniMode;
            GetSelectedImage().MagnificationMode = MagMode;
        }

        private void Viewer_Click(System.Object sender, System.EventArgs e)
        {
            NewData();
        }

        private void cmdNotes_Click_1(System.Object sender, System.EventArgs e)
        {
            string StID = GetSelectedImage().DataSet.StudyUID;
            string strSQL = "";

            if (string.IsNullOrEmpty(StID))
            {
                MessageBox.Show("Please select any DICOM Image", "TeleRad-Client", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(txtReports.Text))
            {
                MessageBox.Show("No Reports to SEND", "TeleRad-Client", MessageBoxButtons.OK);
                return;
            }

            CN.OpenConnection();
            Cmd = new OdbcCommand("SELECT Count(*) AS Kount from Reports WHERE StudyUID='" + StID + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            if (Rs1.HasRows)
            {
                strSQL = "UPDATE Reports SET Reports='" + txtReports.Rtf + "', IsReports=1 WHERE StudyUID='" + StID + "'";
            }
            else
            {
                strSQL = "INSERT INTO Reports (StudyUID, Reports, IsReports) VALUES ('" + StID + "', '" + txtReports.Rtf + "', 1)";
            }
            Rs1.Close();
            Cmd.Dispose();
            CN.closeconnection();

            CN.OpenConnection();
            Cmd = new OdbcCommand(strSQL, CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            Rs1.Close();
            Cmd.Dispose();
            CN.closeconnection();
            MessageBox.Show("Successfully Report sent", "TeleRad - Client", MessageBoxButtons.OK);
            frmRet.btnRefresh_Click(this, e);
        }

        public bool Show_Notes()
        {
            string StID = GetSelectedImage().DataSet.StudyUID;

            if (string.IsNullOrEmpty(StID))
            {
                //MessageBox.Show("Please select any DICOM Image", "TeleRad-Client", MessageBoxButtons.OK)
                return true;
            }

            CN.OpenConnection();
            Cmd = new OdbcCommand("SELECT * FROM Reports WHERE StudyUID='" + StID + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            //Rs1.Read()
            if (Rs1.HasRows)
            {
                if (Rs1["Notes"] != null)
                {
                    txtNotes.Text = Rs1["Notes"].ToString();
                }
                else
                {
                    txtNotes.Text = "";
                }
            }
            Rs1.Close();
            Cmd.Dispose();
            CN.closeconnection();

            return true;
        }

        public bool Show_Reports()
        {
            string StID = GetSelectedImage().DataSet.StudyUID;

            if (string.IsNullOrEmpty(StID))
            {
                //MessageBox.Show("Please select any DICOM Image", "TeleRad-Client", MessageBoxButtons.OK)
                return true;
            }

            CN.OpenConnection();
            Cmd = new OdbcCommand("SELECT * FROM Reports WHERE StudyUID='" + StID + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            //Rs1.Read()
            if (Rs1.HasRows)
            {
                if (Rs1["Reports"] != null)
                {
                    txtReports.Rtf = Rs1["Reports"].ToString();
                }
                else
                {
                    txtReports.Text = "";
                }
            }
            Rs1.Close();
            Cmd.Dispose();
            CN.closeconnection();

            return true;
        }

        private void txtReports_DoubleClick(object sender, System.EventArgs e)
        {
            frmReport Rpt = new frmReport();
            Rpt.txtPatID.Text = GetSelectedImage().PatientID;
            Rpt.txtPatName.Text = modMain.PatName;
            Rpt.txtPatDOB.Text = modMain.PatDOB;
            Rpt.txtPatSex.Text = modMain.PatSex;
            Rpt.txtStudyID.Text = GetSelectedImage().StudyUID;
            Rpt.txtStudyDate.Text = modMain.StudyDate;
            Rpt.txtStudyTime.Text = modMain.StudyTime;
            modMain.StudyID = GetSelectedImage().StudyUID;
            //txtReports.Enabled = False

            //***************************************************************
            Rpt.BackColor = this.BackColor;
            Rpt.cmdBold.BackColor = this.btnPush.BackColor;
            Rpt.cmdItalics.BackColor = this.btnPush.BackColor;
            Rpt.cmdUnderline.BackColor = this.btnPush.BackColor;
            Rpt.cmdStrikethrough.BackColor = this.btnPush.BackColor;
            Rpt.cmdFont.BackColor = this.btnPush.BackColor;
            Rpt.cmdFontColor.BackColor = this.btnPush.BackColor;
            Rpt.btnLoad.BackColor = this.btnPush.BackColor;
            Rpt.btnSave.BackColor = this.btnPush.BackColor;
            Rpt.btnDel.BackColor = this.btnPush.BackColor;
            Rpt.btnSaveRep.BackColor = this.btnPush.BackColor;
            Rpt.cmdSend.BackColor = this.btnPush.BackColor;
            Rpt.btnPush.BackColor = this.btnPush.BackColor;
            //***************************************************************

            Rpt.Show();
        }

        private void btnDown_Click(System.Object sender, System.EventArgs e)
        {
            TableLayoutPanel2.RowStyles[1].Height = 95;
            TableLayoutPanel2.RowStyles[3].Height = 0;
            TableLayoutPanel3.ColumnStyles[1].Width = 100;
            TableLayoutPanel3.ColumnStyles[2].Width = 0;
            btnDown.Visible = false;
            btnUp.Visible = true;
            Displayvalues.Top = Viewer.Top + Viewer.Height + 2;
            Displayvalues.Width = Viewer.Width;
        }

        private void btnUp_Click(object sender, System.EventArgs e)
        {
            TableLayoutPanel2.RowStyles[1].Height = 75;
            TableLayoutPanel2.RowStyles[3].Height = 20;
            TableLayoutPanel3.ColumnStyles[1].Width = 75;
            TableLayoutPanel3.ColumnStyles[2].Width = 25;
            btnDown.Visible = true;
            Displayvalues.Top = 480;
            Displayvalues.Width = Viewer.Width;
            btnUp.Visible = false;
        }

        private void Viewer_DoubleClick(object sender, System.EventArgs e)
        {
            if (TableLayoutPanel2.RowStyles[3].Height == 0)
            {
                btnUp_Click(this, e);
            }
            else
            {
                btnDown_Click(this, e);
            }
        }

        private void btnAdvance_Click(System.Object sender, System.EventArgs e)
        {
            //try
            //{
            //    Tools_Log Tools11 = new Tools_Log();
            //    n = FileSystem.FreeFile();
            //    FileSystem.FileOpen(n, My.Application.Info.DirectoryPath + "\\Tools", OpenMode.Random);
            //    FileSystem.FileGet(n, Tools11, 1);
            //    FileSystem.FileClose(n);

            //    Process proc = default(Process);
            //    proc = Process.Start(Tools11.Path);
            //    proc.WaitForInputIdle();
            //    SetParent(proc.MainWindowHandle, this.Handle);
            //    SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("It seems that you have not configured Advance Study Tools. Please select it from Tools menu.", "TeleRad Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void MenuItem2_Click(System.Object sender, System.EventArgs e)
        {
            //ofdBrowse.ShowDialog();
            //Tools_Log Tools11 = new Tools_Log();
            //Tools11.Path = ofdBrowse.FileName;
            //n = FileSystem.FreeFile();
            //FileSystem.FileOpen(n, My.Application.Info.DirectoryPath + "\\Tools", OpenMode.Random);
            //FileSystem.FilePut(Convert.ToInt32(n), Tools11, 1);
            //FileSystem.FileClose(n);
        }

        private void btnPush_Click(System.Object sender, System.EventArgs e)
        {
            if (btnPush.Text == "Push To E&xtended Monitor")
            {
                this.Left = Screen.PrimaryScreen.Bounds.Width + 1;
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Maximized;
                btnPush.Text = "Push To O&riginal Monitor";
            }
            else
            {
                this.Left = 0;
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Maximized;
                btnPush.Text = "Push To E&xtended Monitor";
            }
        }

        private void CImageIndex_ValueChanged1(object sender, System.EventArgs e)
        {
            if (Viewer.Images.Count > 0 & CImageIndex.Value > -1)
            {
                Viewer.CurrentIndex = Convert.ToInt16(CImageIndex.Value);
                PatientName.Text = Viewer.Images[Viewer.CurrentIndex].Name + "";
            }
        }

        private void btnChangeColor_Click(System.Object sender, System.EventArgs e)
        {
            ColorDialog1.ShowDialog();
            if (ColorDialog1.Color == Color.Black)
            {
                MessageBox.Show("Black is not allowed", "TeleRad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.BackColor = ColorDialog1.Color;
            this.SelectBTN.BackColor = ColorDialog1.Color;
            this.WindowBTN.BackColor = ColorDialog1.Color;
            this.ScrollBTN.BackColor = ColorDialog1.Color;
            this.MagnifyBTN.BackColor = ColorDialog1.Color;
            this.CropBTN.BackColor = ColorDialog1.Color;
            this.CobbBTN.BackColor = ColorDialog1.Color;
            this.ProtractorBTN.BackColor = ColorDialog1.Color;
            this.PixelButton.BackColor = ColorDialog1.Color;
            this.AddAnnoBTN.BackColor = ColorDialog1.Color;
            this.EditAnnoBTN.BackColor = ColorDialog1.Color;
            this.MeasureButton.BackColor = ColorDialog1.Color;
            this.btnPush.BackColor = ColorDialog1.Color;
            this.btnDown.BackColor = ColorDialog1.Color;
            this.btnUp.BackColor = ColorDialog1.Color;
            this.btnAdvance.BackColor = ColorDialog1.Color;
            this.btnChangeColor.BackColor = ColorDialog1.Color;
            this.cmdReports.BackColor = ColorDialog1.Color;
            this.Displayvalues.BackColor = ColorDialog1.Color;
        }

        private void tbtnWindow_Click(object sender, EventArgs e)
        {
            MouseFunction = MouseFunctionEnums.Windowing;
        }

        private void tbtnSelect_Click(object sender, EventArgs e)
        {
            MouseFunction = MouseFunctionEnums.SelectImage;
        }

        private void tbtnMagnify_Click(object sender, EventArgs e)
        {
            MouseFunction = MouseFunctionEnums.MagnifyingGlass;
        }

    }
}
