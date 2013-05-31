using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using Microsoft.VisualBasic;

namespace TeleRadReport
{
    public partial class frmReport : Form
    {
        Myconnectionclass CN = new Myconnectionclass();
        OdbcCommand Cmd;
        OdbcDataReader Rs1;

        public frmReport()
        {
            InitializeComponent();
        }

        private void cmdFont_Click(System.Object sender, System.EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            DialogResult res = dlg.ShowDialog();
            txtFont.Text = dlg.Font.Name + "(" + dlg.Font.Size + ")";
            txtReports.SelectionFont = dlg.Font;
        }

        private void frmReport_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //SP.txtReports.Rtf = this.txtReports.Rtf;
        }

        private void frmReport_Load(System.Object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'dicomServerDBDataSet21.ReportTemplates' table. You can move, or remove it, as needed.
            this.reportTemplatesTableAdapter.Fill(this.dicomServerDBDataSet21.ReportTemplates);
            //TODO: This line of code loads data into the 'DicomServerDBDataSet2.ReportTemplates' table. You can move, or remove it, as needed.
            this.reportTemplatesTableAdapter.Fill(this.dicomServerDBDataSet21.ReportTemplates);
            txtFont.Text = this.Font.Name + "(" + this.Font.Size + ")";
            this.Text = "Report of " + modMain.PatName + " (" + this.txtStudyID.Text + ")";
            Show_Reports();
        }

        private void cmdBold_Click(System.Object sender, System.EventArgs e)
        {
            if ((txtReports.SelectionFont != null))
            {
                System.Drawing.Font fntCurrentFont = txtReports.SelectionFont;
                System.Drawing.FontStyle fstNewFontStyle = default(System.Drawing.FontStyle);

                if (txtReports.SelectionFont.Bold == true)
                {
                    fstNewFontStyle = txtReports.SelectionFont.Style & FontStyle.Bold;
                }
                else
                {
                    fstNewFontStyle = txtReports.SelectionFont.Style | FontStyle.Bold;
                }
                txtReports.SelectionFont = new Font(fntCurrentFont.FontFamily, fntCurrentFont.Size, fstNewFontStyle);
            }
        }

        private void cmdItalics_Click(System.Object sender, System.EventArgs e)
        {
            if ((txtReports.SelectionFont != null))
            {
                System.Drawing.Font fntCurrentFont = txtReports.SelectionFont;
                System.Drawing.FontStyle fstNewFontStyle = default(System.Drawing.FontStyle);

                if (txtReports.SelectionFont.Italic == true)
                {
                    fstNewFontStyle = txtReports.SelectionFont.Style & FontStyle.Italic;
                }
                else
                {
                    fstNewFontStyle = txtReports.SelectionFont.Style | FontStyle.Italic;
                }

                txtReports.SelectionFont = new Font(fntCurrentFont.FontFamily, fntCurrentFont.Size, fstNewFontStyle);
            }
        }

        private void cmdUnderline_Click(System.Object sender, System.EventArgs e)
        {
            if ((txtReports.SelectionFont != null))
            {
                System.Drawing.Font fntCurrentFont = txtReports.SelectionFont;
                System.Drawing.FontStyle fstNewFontStyle = default(System.Drawing.FontStyle);

                if (txtReports.SelectionFont.Underline == true)
                {
                    fstNewFontStyle = txtReports.SelectionFont.Style & FontStyle.Underline;
                }
                else
                {
                    fstNewFontStyle = txtReports.SelectionFont.Style | FontStyle.Underline;
                }

                txtReports.SelectionFont = new Font(fntCurrentFont.FontFamily, fntCurrentFont.Size, fstNewFontStyle);
            }
        }

        private void cmdStrikethrough_Click(System.Object sender, System.EventArgs e)
        {
            if ((txtReports.SelectionFont != null))
            {
                System.Drawing.Font fntCurrentFont = txtReports.SelectionFont;
                System.Drawing.FontStyle fstNewFontStyle = default(System.Drawing.FontStyle);

                if (txtReports.SelectionFont.Strikeout == true)
                {
                    fstNewFontStyle = txtReports.SelectionFont.Style & FontStyle.Strikeout;
                }
                else
                {
                    fstNewFontStyle = txtReports.SelectionFont.Style | FontStyle.Strikeout;
                }

                txtReports.SelectionFont = new Font(fntCurrentFont.FontFamily, fntCurrentFont.Size, fstNewFontStyle);
            }
        }

        private void cmdFontColor_Click(System.Object sender, System.EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            DialogResult res = dlg.ShowDialog();
            txtReports.SelectionColor = dlg.Color;
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            if (ComboBox1.Items.Count < 1)
            {
                MessageBox.Show("No Report to LOAD", "TeleRad-Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CN.OpenConnection();
            Cmd = new OdbcCommand("SELECT * FROM ReportTemplates WHERE Name='" + ComboBox1.Text + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            if (Rs1.HasRows)
            {
                if (Rs1["ReportBody"] != null)
                {
                    txtReports.Rtf = Rs1["ReportBody"].ToString();
                }
                else
                {
                    txtReports.Text = "";
                }
            }
            Rs1.Close();
            Cmd.Dispose();
            CN.closeconnection();
        }

        private void btnDel_Click(System.Object sender, System.EventArgs e)
        {
            if (ComboBox1.Items.Count < 1)
            {
                MessageBox.Show("No Report to DELETE", "TeleRad-Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CN.OpenConnection();
            Cmd = new OdbcCommand("DELETE FROM ReportTemplates WHERE Name='" + ComboBox1.Text + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            Rs1.Close();
            Cmd.Dispose();
            CN.closeconnection();

            ComboBox1.DataSource = null;
            ComboBox1.Items.Clear();
            //ReportTemplatesBindingSource = Nothing
            //ReportTemplatesBindingSource.DataSource = DicomServerDBDataSet2.DataSetName
            ComboBox1.DataSource = ReportTemplatesBindingSource;
            ComboBox1.DisplayMember = "Name";
            ComboBox1.SelectedIndex = 0;
        }

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            string strSQL = "";
            string NameOfTemplate = Interaction.InputBox("Enter Name of Report Template", "TeleRad - Client");

            if (string.IsNullOrEmpty(NameOfTemplate))
            {
                MessageBox.Show("No Report Name to SAVE", "TeleRad-Client", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(txtReports.Text))
            {
                MessageBox.Show("No Reports to SAVE", "TeleRad-Client", MessageBoxButtons.OK);
                return;
            }

            CN.OpenConnection();
            Cmd = new OdbcCommand("SELECT * FROM ReportTemplates WHERE Name='" + NameOfTemplate + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            if (Rs1.HasRows)
            {
                strSQL = "UPDATE ReportTemplates SET ReportBody='" + txtReports.Rtf + "' WHERE Name='" + ComboBox1.Text + "'";
            }
            else
            {
                strSQL = "INSERT INTO ReportTemplates (Name, ReportBody) VALUES ('" + NameOfTemplate + "', '" + txtReports.Rtf + "')";
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
        }

        private void cmdSend_Click(System.Object sender, System.EventArgs e)
        {
            string strSQL = "";

            if (string.IsNullOrEmpty(modMain.StudyID))
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
            Cmd = new OdbcCommand("SELECT Count(*) AS Kount from Reports WHERE StudyUID='" + modMain.StudyID + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            if (!Rs1.HasRows)
            {
                strSQL = "UPDATE Reports SET Reports='" + txtReports.Rtf + "', IsReports=1 WHERE StudyUID='" + modMain.StudyID + "'";
            }
            else
            {
                strSQL = "INSERT INTO Reports (StudyUID, Reports, IsReports) VALUES ('" + modMain.StudyID + "', '" + txtReports.Rtf + "',1)";
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

            //Insert_ReportDone_Image()
            MessageBox.Show("Successfully Report sent", "TeleRad - Client", MessageBoxButtons.OK);

            //SP.txtReports.Enabled = true;
            //SP.txtReports.Text = txtReports.Text;
        }

        public int Insert_ReportDone_Image()
        {
            MemoryStream ms = new MemoryStream();
            this.PictureBox1.Image.Save(ms, this.PictureBox1.Image.RawFormat);

            byte[] arrayImage = ms.GetBuffer();
            ms.Close();
            // Closes the Memory Stream

            string strConnect = null;
            //strConnect = "DSN=DICOMServerDB;uid=sa;pwd=a"
            strConnect = "Data Source=DICOMServerDB;Initial Catalog=DICOMServerDB;User ID=Administrator";
            SqlConnection conn = new SqlConnection(strConnect);

            string sSQL = "INSERT INTO Reports (ImgReports) VALUES(@pic)";
            //CN.OpenConnection()
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            //Cmd = New Odbc.OdbcCommand(sSQL, CN.DBConnection)

            // image content
            SqlParameter pic = new SqlParameter("@pic", SqlDbType.Image);
            //Dim pic As Odbc.OdbcParameter = New Odbc.OdbcParameter("@pic", Odbc.OdbcType.Image)
            pic.Value = arrayImage;
            Cmd.Parameters.Add(pic);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //'conn.Close()
                CN.closeconnection();
                MessageBox.Show("Query executed.", "Image Load");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Data Error");
                return 0;
            }
        }

        public bool Show_Reports()
        {
            if (modMain.StudyID.Length <= 0)
            {
                //MessageBox.Show("Please select any DICOM Image", "TeleRad-Client", MessageBoxButtons.OK)
                return false;
            }

            CN.OpenConnection();
            Cmd = new OdbcCommand("SELECT * FROM Reports WHERE StudyUID='" + modMain.StudyID + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            Rs1.Read();
            if (Rs1["Reports"].ToString().Length > 0)
            {
                txtReports.Rtf = Rs1["Reports"].ToString();
            }
            else
            {
                txtReports.Text = "";
            }
            Rs1.Close();
            Cmd.Dispose();
            CN.closeconnection();

            return true;
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

        private void btnSaveRep_Click(System.Object sender, System.EventArgs e)
        {
            string strSQL = "";

            if (modMain.StudyID.Length <= 0)
            {
                MessageBox.Show("Please select any DICOM Image", "TeleRad-Client", MessageBoxButtons.OK);
                return;
            }

            CN.OpenConnection();
            Cmd = new OdbcCommand("SELECT Count(*) AS Kount from Reports WHERE StudyUID='" + modMain.StudyID + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            if (Rs1.HasRows)
            {
                strSQL = "UPDATE Reports SET Reports='" + txtReports.Rtf + "' WHERE StudyUID='" + modMain.StudyID + "'";
            }
            else
            {
                strSQL = "INSERT INTO Reports (StudyUID, Reports) VALUES ('" + modMain.StudyID + "', '" + txtReports.Rtf + "')";
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

            //Insert_ReportDone_Image()
            MessageBox.Show("Successfully Saved Report", "TeleRad - Client", MessageBoxButtons.OK);
            //SP.txtReports.Enabled = true;
            //SP.txtReports.Text = txtReports.Text;
        }
    }
}
