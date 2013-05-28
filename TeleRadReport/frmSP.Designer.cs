namespace TeleRadReport
{
    partial class frmSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSP));
            this.Rows = new System.Windows.Forms.NumericUpDown();
            this.Replicate = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Columns = new System.Windows.Forms.NumericUpDown();
            this.Displayvalues = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.CubicSpine = new System.Windows.Forms.Button();
            this.BSpine = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.MovingAverage = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.PixelValue = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.PixelButton = new System.Windows.Forms.RadioButton();
            this.MeasureButton = new System.Windows.Forms.RadioButton();
            this.EditAnnoBTN = new System.Windows.Forms.RadioButton();
            this.MagnifyBTN = new System.Windows.Forms.RadioButton();
            this.ProtractorBTN = new System.Windows.Forms.RadioButton();
            this.CobbBTN = new System.Windows.Forms.RadioButton();
            this.CropBTN = new System.Windows.Forms.RadioButton();
            this.AddAnnoBTN = new System.Windows.Forms.RadioButton();
            this.ScrollBTN = new System.Windows.Forms.RadioButton();
            this.WindowBTN = new System.Windows.Forms.RadioButton();
            this.SelectBTN = new System.Windows.Forms.RadioButton();
            this.AnatomicMarkers = new System.Windows.Forms.CheckBox();
            this.CImageIndex = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Level1 = new System.Windows.Forms.TextBox();
            this.Width1 = new System.Windows.Forms.TextBox();
            this.Zoom1 = new System.Windows.Forms.TextBox();
            this.StretchToFit = new System.Windows.Forms.CheckBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.LevelSlider = new System.Windows.Forms.TrackBar();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthSlider = new System.Windows.Forms.TrackBar();
            this.ZoomLabel = new System.Windows.Forms.Label();
            this.ZoomSlider = new System.Windows.Forms.TrackBar();
            this.Viewer = new DicomObjects.DicomViewer();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblImgCount = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.AttribList = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSelect = new System.Windows.Forms.ToolStripButton();
            this.tbtnWindow = new System.Windows.Forms.ToolStripButton();
            this.tbtnMagnify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnRotClock = new System.Windows.Forms.ToolStripButton();
            this.tbtnRotAntiClock = new System.Windows.Forms.ToolStripButton();
            this.tbtnFlipVertical = new System.Windows.Forms.ToolStripButton();
            this.tbtnFlipHorizontal = new System.Windows.Forms.ToolStripButton();
            this.tbtnCrop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnAddAnnot = new System.Windows.Forms.ToolStripButton();
            this.tbtnEditAnnot = new System.Windows.Forms.ToolStripButton();
            this.tbtnMeasurement = new System.Windows.Forms.ToolStripButton();
            this.tbtnAngle = new System.Windows.Forms.ToolStripButton();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdReports = new System.Windows.Forms.Button();
            this.txtReports = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.Image = new System.Windows.Forms.MenuItem();
            this.ImageRead = new System.Windows.Forms.MenuItem();
            this.ImageWrite = new System.Windows.Forms.MenuItem();
            this.PrintDICOM = new System.Windows.Forms.MenuItem();
            this.PrintWindows = new System.Windows.Forms.MenuItem();
            this.Import = new System.Windows.Forms.MenuItem();
            this.Export = new System.Windows.Forms.MenuItem();
            this.ExitOption = new System.Windows.Forms.MenuItem();
            this.Edit = new System.Windows.Forms.MenuItem();
            this.DeleteSelected = new System.Windows.Forms.MenuItem();
            this.DeleteAll = new System.Windows.Forms.MenuItem();
            this.Remote = new System.Windows.Forms.MenuItem();
            this.Verify = new System.Windows.Forms.MenuItem();
            this.Retrieve = new System.Windows.Forms.MenuItem();
            this.SendSelected = new System.Windows.Forms.MenuItem();
            this.SendAll = new System.Windows.Forms.MenuItem();
            this.Display = new System.Windows.Forms.MenuItem();
            this.DisplayNormal = new System.Windows.Forms.MenuItem();
            this.FlipHorizontal = new System.Windows.Forms.MenuItem();
            this.FlipVertical = new System.Windows.Forms.MenuItem();
            this.RotateClockwise = new System.Windows.Forms.MenuItem();
            this.RotateAntiClockwise = new System.Windows.Forms.MenuItem();
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.CineModeForward = new System.Windows.Forms.MenuItem();
            this.CineModeRepeat = new System.Windows.Forms.MenuItem();
            this.CineModeOscillate = new System.Windows.Forms.MenuItem();
            this.CineModeRepeatReverse = new System.Windows.Forms.MenuItem();
            this.CineModeReverse = new System.Windows.Forms.MenuItem();
            this.CineModeStatic = new System.Windows.Forms.MenuItem();
            this.View = new System.Windows.Forms.MenuItem();
            this.ImageInformation = new System.Windows.Forms.MenuItem();
            this.Options = new System.Windows.Forms.MenuItem();
            this.Tools = new System.Windows.Forms.MenuItem();
            this.MakeNewImage = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.AboutThisExample = new System.Windows.Forms.MenuItem();
            this.Logging = new System.Windows.Forms.MenuItem();
            this.LogLocation = new System.Windows.Forms.MenuItem();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ofdBrowse = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CImageIndex)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomSlider)).BeginInit();
            this.Viewer.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.grpReports.SuspendLayout();
            this.TableLayoutPanel6.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rows
            // 
            this.Rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rows.Location = new System.Drawing.Point(137, 134);
            this.Rows.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(40, 23);
            this.Rows.TabIndex = 13;
            this.Rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rows.ValueChanged += new System.EventHandler(this.Rows_ValueChanged);
            this.Rows.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rows_MouseUp);
            // 
            // Replicate
            // 
            this.Replicate.Location = new System.Drawing.Point(8, 32);
            this.Replicate.Name = "Replicate";
            this.Replicate.Size = new System.Drawing.Size(72, 32);
            this.Replicate.TabIndex = 1;
            this.Replicate.Text = "Pixel Value";
            this.Replicate.Click += new System.EventHandler(this.Replicate_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(6, 137);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(92, 17);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Display Rows";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(8, 176);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(112, 17);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "Display Columns";
            // 
            // Columns
            // 
            this.Columns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Columns.Location = new System.Drawing.Point(137, 173);
            this.Columns.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(40, 23);
            this.Columns.TabIndex = 15;
            this.Columns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Columns.ValueChanged += new System.EventHandler(this.Columns_ValueChanged);
            this.Columns.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Columns_MouseUp);
            // 
            // Displayvalues
            // 
            this.Displayvalues.BackColor = System.Drawing.Color.SlateBlue;
            this.Displayvalues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Displayvalues.Location = new System.Drawing.Point(3, 6);
            this.Displayvalues.Name = "Displayvalues";
            this.Displayvalues.Size = new System.Drawing.Size(614, 18);
            this.Displayvalues.TabIndex = 36;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.CubicSpine);
            this.GroupBox3.Controls.Add(this.BSpine);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.MovingAverage);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.Replicate);
            this.GroupBox3.Controls.Add(this.PixelValue);
            this.GroupBox3.Location = new System.Drawing.Point(17, 22);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(182, 142);
            this.GroupBox3.TabIndex = 17;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Smoothing Settings";
            this.GroupBox3.Visible = false;
            // 
            // CubicSpine
            // 
            this.CubicSpine.Location = new System.Drawing.Point(8, 104);
            this.CubicSpine.Name = "CubicSpine";
            this.CubicSpine.Size = new System.Drawing.Size(72, 32);
            this.CubicSpine.TabIndex = 6;
            this.CubicSpine.Text = "Cubic Spine";
            this.CubicSpine.Click += new System.EventHandler(this.CubicSpine_Click);
            // 
            // BSpine
            // 
            this.BSpine.Location = new System.Drawing.Point(8, 68);
            this.BSpine.Name = "BSpine";
            this.BSpine.Size = new System.Drawing.Size(72, 32);
            this.BSpine.TabIndex = 5;
            this.BSpine.Text = "B-Spine";
            this.BSpine.Click += new System.EventHandler(this.BSpine_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Magnification";
            // 
            // MovingAverage
            // 
            this.MovingAverage.Location = new System.Drawing.Point(91, 72);
            this.MovingAverage.Name = "MovingAverage";
            this.MovingAverage.Size = new System.Drawing.Size(85, 40);
            this.MovingAverage.TabIndex = 3;
            this.MovingAverage.Text = "Moving Average";
            this.MovingAverage.Click += new System.EventHandler(this.MovingAverage_Click);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(89, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Minification";
            // 
            // PixelValue
            // 
            this.PixelValue.Location = new System.Drawing.Point(91, 34);
            this.PixelValue.Name = "PixelValue";
            this.PixelValue.Size = new System.Drawing.Size(85, 32);
            this.PixelValue.TabIndex = 0;
            this.PixelValue.Text = "Pixel Value";
            this.PixelValue.Click += new System.EventHandler(this.PixelValue_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupBox2.Controls.Add(this.PixelButton);
            this.GroupBox2.Controls.Add(this.MeasureButton);
            this.GroupBox2.Controls.Add(this.EditAnnoBTN);
            this.GroupBox2.Controls.Add(this.MagnifyBTN);
            this.GroupBox2.Controls.Add(this.ProtractorBTN);
            this.GroupBox2.Controls.Add(this.CobbBTN);
            this.GroupBox2.Controls.Add(this.CropBTN);
            this.GroupBox2.Controls.Add(this.AddAnnoBTN);
            this.GroupBox2.Controls.Add(this.ScrollBTN);
            this.GroupBox2.Controls.Add(this.WindowBTN);
            this.GroupBox2.Controls.Add(this.SelectBTN);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(3, 256);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(181, 220);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mouse Functions";
            // 
            // PixelButton
            // 
            this.PixelButton.BackColor = System.Drawing.Color.SlateBlue;
            this.PixelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PixelButton.ForeColor = System.Drawing.Color.Black;
            this.PixelButton.Location = new System.Drawing.Point(94, 112);
            this.PixelButton.Name = "PixelButton";
            this.PixelButton.Size = new System.Drawing.Size(83, 29);
            this.PixelButton.TabIndex = 13;
            this.PixelButton.Text = "Pixel Values";
            this.PixelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PixelButton.UseVisualStyleBackColor = false;
            this.PixelButton.CheckedChanged += new System.EventHandler(this.PixelButton_CheckedChanged);
            // 
            // MeasureButton
            // 
            this.MeasureButton.BackColor = System.Drawing.Color.SlateBlue;
            this.MeasureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasureButton.ForeColor = System.Drawing.Color.Black;
            this.MeasureButton.Location = new System.Drawing.Point(50, 182);
            this.MeasureButton.Name = "MeasureButton";
            this.MeasureButton.Size = new System.Drawing.Size(83, 29);
            this.MeasureButton.TabIndex = 12;
            this.MeasureButton.Text = "Measure";
            this.MeasureButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MeasureButton.UseVisualStyleBackColor = false;
            this.MeasureButton.CheckedChanged += new System.EventHandler(this.MeasureButton_CheckedChanged);
            // 
            // EditAnnoBTN
            // 
            this.EditAnnoBTN.BackColor = System.Drawing.Color.SlateBlue;
            this.EditAnnoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAnnoBTN.ForeColor = System.Drawing.Color.Black;
            this.EditAnnoBTN.Location = new System.Drawing.Point(94, 144);
            this.EditAnnoBTN.Name = "EditAnnoBTN";
            this.EditAnnoBTN.Size = new System.Drawing.Size(83, 35);
            this.EditAnnoBTN.TabIndex = 6;
            this.EditAnnoBTN.Text = "Edit Annotation";
            this.EditAnnoBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditAnnoBTN.UseVisualStyleBackColor = false;
            this.EditAnnoBTN.CheckedChanged += new System.EventHandler(this.EditAnnoBTN_CheckedChanged);
            // 
            // MagnifyBTN
            // 
            this.MagnifyBTN.BackColor = System.Drawing.Color.SlateBlue;
            this.MagnifyBTN.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MagnifyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagnifyBTN.ForeColor = System.Drawing.Color.Black;
            this.MagnifyBTN.Location = new System.Drawing.Point(93, 48);
            this.MagnifyBTN.Name = "MagnifyBTN";
            this.MagnifyBTN.Size = new System.Drawing.Size(83, 29);
            this.MagnifyBTN.TabIndex = 11;
            this.MagnifyBTN.Tag = "9";
            this.MagnifyBTN.Text = "Magnify";
            this.MagnifyBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MagnifyBTN.UseVisualStyleBackColor = false;
            this.MagnifyBTN.CheckedChanged += new System.EventHandler(this.MagnifyBTN_CheckedChanged);
            // 
            // ProtractorBTN
            // 
            this.ProtractorBTN.BackColor = System.Drawing.Color.SlateBlue;
            this.ProtractorBTN.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProtractorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProtractorBTN.ForeColor = System.Drawing.Color.Black;
            this.ProtractorBTN.Location = new System.Drawing.Point(8, 112);
            this.ProtractorBTN.Name = "ProtractorBTN";
            this.ProtractorBTN.Size = new System.Drawing.Size(83, 29);
            this.ProtractorBTN.TabIndex = 10;
            this.ProtractorBTN.Tag = "11";
            this.ProtractorBTN.Text = "Protractor";
            this.ProtractorBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProtractorBTN.UseVisualStyleBackColor = false;
            this.ProtractorBTN.CheckedChanged += new System.EventHandler(this.ProtractorBTN_CheckedChanged);
            // 
            // CobbBTN
            // 
            this.CobbBTN.BackColor = System.Drawing.Color.SlateBlue;
            this.CobbBTN.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CobbBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobbBTN.ForeColor = System.Drawing.Color.Black;
            this.CobbBTN.Location = new System.Drawing.Point(93, 80);
            this.CobbBTN.Name = "CobbBTN";
            this.CobbBTN.Size = new System.Drawing.Size(83, 29);
            this.CobbBTN.TabIndex = 9;
            this.CobbBTN.Tag = "10";
            this.CobbBTN.Text = "Cobb";
            this.CobbBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CobbBTN.UseVisualStyleBackColor = false;
            this.CobbBTN.CheckedChanged += new System.EventHandler(this.CobbBTN_CheckedChanged);
            // 
            // CropBTN
            // 
            this.CropBTN.BackColor = System.Drawing.Color.SlateBlue;
            this.CropBTN.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CropBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CropBTN.ForeColor = System.Drawing.Color.Black;
            this.CropBTN.Location = new System.Drawing.Point(7, 80);
            this.CropBTN.Name = "CropBTN";
            this.CropBTN.Size = new System.Drawing.Size(83, 29);
            this.CropBTN.TabIndex = 8;
            this.CropBTN.Tag = "9";
            this.CropBTN.Text = "Crop";
            this.CropBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CropBTN.UseVisualStyleBackColor = false;
            this.CropBTN.CheckedChanged += new System.EventHandler(this.CropBTN_CheckedChanged);
            // 
            // AddAnnoBTN
            // 
            this.AddAnnoBTN.BackColor = System.Drawing.Color.SlateBlue;
            this.AddAnnoBTN.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddAnnoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAnnoBTN.ForeColor = System.Drawing.Color.Black;
            this.AddAnnoBTN.Location = new System.Drawing.Point(9, 144);
            this.AddAnnoBTN.Name = "AddAnnoBTN";
            this.AddAnnoBTN.Size = new System.Drawing.Size(83, 35);
            this.AddAnnoBTN.TabIndex = 3;
            this.AddAnnoBTN.Tag = "4";
            this.AddAnnoBTN.Text = "Add Annotation";
            this.AddAnnoBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddAnnoBTN.UseVisualStyleBackColor = false;
            this.AddAnnoBTN.CheckedChanged += new System.EventHandler(this.AddAnnoBTN_CheckedChanged);
            // 
            // ScrollBTN
            // 
            this.ScrollBTN.BackColor = System.Drawing.Color.SlateBlue;
            this.ScrollBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrollBTN.ForeColor = System.Drawing.Color.Black;
            this.ScrollBTN.Location = new System.Drawing.Point(6, 48);
            this.ScrollBTN.Name = "ScrollBTN";
            this.ScrollBTN.Size = new System.Drawing.Size(83, 29);
            this.ScrollBTN.TabIndex = 2;
            this.ScrollBTN.Tag = "3";
            this.ScrollBTN.Text = "Scroll";
            this.ScrollBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScrollBTN.UseVisualStyleBackColor = false;
            this.ScrollBTN.CheckedChanged += new System.EventHandler(this.ScrollBTN_CheckedChanged);
            // 
            // WindowBTN
            // 
            this.WindowBTN.BackColor = System.Drawing.Color.SlateBlue;
            this.WindowBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowBTN.ForeColor = System.Drawing.Color.Black;
            this.WindowBTN.Location = new System.Drawing.Point(94, 16);
            this.WindowBTN.Name = "WindowBTN";
            this.WindowBTN.Size = new System.Drawing.Size(83, 29);
            this.WindowBTN.TabIndex = 1;
            this.WindowBTN.Tag = "2";
            this.WindowBTN.Text = "Window";
            this.WindowBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WindowBTN.UseVisualStyleBackColor = false;
            this.WindowBTN.CheckedChanged += new System.EventHandler(this.WindowBTN_CheckedChanged);
            // 
            // SelectBTN
            // 
            this.SelectBTN.BackColor = System.Drawing.Color.SlateBlue;
            this.SelectBTN.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SelectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBTN.ForeColor = System.Drawing.Color.Black;
            this.SelectBTN.Location = new System.Drawing.Point(6, 16);
            this.SelectBTN.Name = "SelectBTN";
            this.SelectBTN.Size = new System.Drawing.Size(83, 29);
            this.SelectBTN.TabIndex = 0;
            this.SelectBTN.Tag = "1";
            this.SelectBTN.Text = "Select";
            this.SelectBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectBTN.UseVisualStyleBackColor = false;
            this.SelectBTN.CheckedChanged += new System.EventHandler(this.SelectBTN_CheckedChanged);
            // 
            // AnatomicMarkers
            // 
            this.AnatomicMarkers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AnatomicMarkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnatomicMarkers.Location = new System.Drawing.Point(5, 100);
            this.AnatomicMarkers.Name = "AnatomicMarkers";
            this.AnatomicMarkers.Size = new System.Drawing.Size(168, 24);
            this.AnatomicMarkers.TabIndex = 11;
            this.AnatomicMarkers.Text = "Show Anatomic Side Markers";
            this.AnatomicMarkers.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AnatomicMarkers.Click += new System.EventHandler(this.AnatomicMarkers_Click);
            // 
            // CImageIndex
            // 
            this.CImageIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CImageIndex.Location = new System.Drawing.Point(137, 64);
            this.CImageIndex.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CImageIndex.Name = "CImageIndex";
            this.CImageIndex.Size = new System.Drawing.Size(40, 23);
            this.CImageIndex.TabIndex = 10;
            this.CImageIndex.ValueChanged += new System.EventHandler(this.CImageIndex_ValueChanged1);
            this.CImageIndex.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CImageIndex_MouseUp);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(4, 67);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(134, 17);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Current Image Index";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Level1);
            this.GroupBox1.Controls.Add(this.Width1);
            this.GroupBox1.Controls.Add(this.Zoom1);
            this.GroupBox1.Controls.Add(this.StretchToFit);
            this.GroupBox1.Controls.Add(this.LevelLabel);
            this.GroupBox1.Controls.Add(this.LevelSlider);
            this.GroupBox1.Controls.Add(this.WidthLabel);
            this.GroupBox1.Controls.Add(this.WidthSlider);
            this.GroupBox1.Controls.Add(this.ZoomLabel);
            this.GroupBox1.Controls.Add(this.ZoomSlider);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(181, 247);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Display Settings";
            // 
            // Level1
            // 
            this.Level1.Location = new System.Drawing.Point(5, 199);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(56, 20);
            this.Level1.TabIndex = 2;
            this.Level1.Text = "128";
            this.Level1.Leave += new System.EventHandler(this.Level1_Leave);
            // 
            // Width1
            // 
            this.Width1.Location = new System.Drawing.Point(64, 199);
            this.Width1.Name = "Width1";
            this.Width1.Size = new System.Drawing.Size(56, 20);
            this.Width1.TabIndex = 2;
            this.Width1.Text = "256";
            this.Width1.Leave += new System.EventHandler(this.width1_Leave);
            // 
            // Zoom1
            // 
            this.Zoom1.Location = new System.Drawing.Point(123, 199);
            this.Zoom1.Name = "Zoom1";
            this.Zoom1.Size = new System.Drawing.Size(56, 20);
            this.Zoom1.TabIndex = 2;
            this.Zoom1.Text = "1.0";
            // 
            // StretchToFit
            // 
            this.StretchToFit.Checked = true;
            this.StretchToFit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StretchToFit.Location = new System.Drawing.Point(33, 219);
            this.StretchToFit.Name = "StretchToFit";
            this.StretchToFit.Size = new System.Drawing.Size(142, 19);
            this.StretchToFit.TabIndex = 3;
            this.StretchToFit.Text = "Stretch To Fit";
            this.StretchToFit.Visible = false;
            this.StretchToFit.CheckedChanged += new System.EventHandler(this.StretchToFit_CheckedChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.Location = new System.Drawing.Point(5, 16);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(40, 16);
            this.LevelLabel.TabIndex = 1;
            this.LevelLabel.Text = "Level";
            // 
            // LevelSlider
            // 
            this.LevelSlider.AutoSize = false;
            this.LevelSlider.Location = new System.Drawing.Point(13, 25);
            this.LevelSlider.Maximum = 1000;
            this.LevelSlider.Name = "LevelSlider";
            this.LevelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LevelSlider.Size = new System.Drawing.Size(45, 178);
            this.LevelSlider.TabIndex = 0;
            this.LevelSlider.TickFrequency = 50;
            this.LevelSlider.Value = 128;
            this.LevelSlider.Scroll += new System.EventHandler(this.LevelSlider_Scroll);
            this.LevelSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LevelSlider_MouseDown);
            this.LevelSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LevelSlider_MouseUp);
            // 
            // WidthLabel
            // 
            this.WidthLabel.Location = new System.Drawing.Point(64, 16);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(40, 16);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width";
            // 
            // WidthSlider
            // 
            this.WidthSlider.AutoSize = false;
            this.WidthSlider.Location = new System.Drawing.Point(72, 25);
            this.WidthSlider.Maximum = 1000;
            this.WidthSlider.Name = "WidthSlider";
            this.WidthSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.WidthSlider.Size = new System.Drawing.Size(45, 178);
            this.WidthSlider.TabIndex = 0;
            this.WidthSlider.TickFrequency = 50;
            this.WidthSlider.Value = 256;
            this.WidthSlider.Scroll += new System.EventHandler(this.WidthSlider_Scroll);
            this.WidthSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WidthSlider_MouseDown);
            this.WidthSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WidthSlider_MouseUp);
            // 
            // ZoomLabel
            // 
            this.ZoomLabel.Location = new System.Drawing.Point(123, 16);
            this.ZoomLabel.Name = "ZoomLabel";
            this.ZoomLabel.Size = new System.Drawing.Size(40, 16);
            this.ZoomLabel.TabIndex = 1;
            this.ZoomLabel.Text = "Zoom";
            // 
            // ZoomSlider
            // 
            this.ZoomSlider.AutoSize = false;
            this.ZoomSlider.Location = new System.Drawing.Point(131, 25);
            this.ZoomSlider.Maximum = 40;
            this.ZoomSlider.Minimum = -40;
            this.ZoomSlider.Name = "ZoomSlider";
            this.ZoomSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ZoomSlider.Size = new System.Drawing.Size(45, 178);
            this.ZoomSlider.TabIndex = 0;
            this.ZoomSlider.TickFrequency = 50;
            this.ZoomSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ZoomSlider.Value = 1;
            this.ZoomSlider.Scroll += new System.EventHandler(this.ZoomSlider_Scroll);
            // 
            // Viewer
            // 
            this.Viewer.AutoDisplay = false;
            this.Viewer.AutoScroll = true;
            this.Viewer.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.Viewer.BackColor = System.Drawing.Color.Black;
            this.Viewer.BackColour = System.Drawing.Color.Black;
            this.Viewer.Border = ((short)(1));
            this.Viewer.CellSpacing = ((short)(0));
            this.Viewer.Controls.Add(this.PatientName);
            this.Viewer.CurrentIndex = 0;
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.HitMargin = 3;
            this.Viewer.Location = new System.Drawing.Point(0, 0);
            this.Viewer.MultiColumns = ((short)(1));
            this.Viewer.MultiRows = ((short)(1));
            this.Viewer.Name = "Viewer";
            this.Viewer.PixelSize = new System.Drawing.SizeF(0.3F, 0.3F);
            this.Viewer.ShowLabels = true;
            this.Viewer.Size = new System.Drawing.Size(751, 467);
            this.Viewer.TabIndex = 18;
            this.Viewer.Text = "DicomViewer1";
            this.Viewer.UseScrollBars = true;
            this.Viewer.DataChanged += new DicomObjects.DicomViewer.DataChangedHandler(this.Viewer_DataChanged);
            this.Viewer.Click += new System.EventHandler(this.Viewer_Click);
            this.Viewer.DoubleClick += new System.EventHandler(this.Viewer_DoubleClick);
            this.Viewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseDown);
            this.Viewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseMove);
            this.Viewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseUp);
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(0, 3);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(750, 20);
            this.PatientName.TabIndex = 2;
            this.PatientName.Visible = false;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.Label1);
            this.GroupBox5.Controls.Add(this.lblImgCount);
            this.GroupBox5.Controls.Add(this.CImageIndex);
            this.GroupBox5.Controls.Add(this.AnatomicMarkers);
            this.GroupBox5.Controls.Add(this.Rows);
            this.GroupBox5.Controls.Add(this.Label4);
            this.GroupBox5.Controls.Add(this.Label5);
            this.GroupBox5.Controls.Add(this.Label6);
            this.GroupBox5.Controls.Add(this.Columns);
            this.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(0, 0);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(181, 200);
            this.GroupBox5.TabIndex = 25;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "DICOM Image View Details";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(143, 17);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "No. of Image(s) ---";
            // 
            // lblImgCount
            // 
            this.lblImgCount.AutoSize = true;
            this.lblImgCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgCount.Location = new System.Drawing.Point(147, 31);
            this.lblImgCount.Name = "lblImgCount";
            this.lblImgCount.Size = new System.Drawing.Size(17, 17);
            this.lblImgCount.TabIndex = 24;
            this.lblImgCount.Text = "0";
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDown.ForeColor = System.Drawing.Color.Black;
            this.btnDown.Image = global::TeleRadReport.Properties.Resources.down_arrow;
            this.btnDown.Location = new System.Drawing.Point(9, -2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(35, 32);
            this.btnDown.TabIndex = 27;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.Controls.Add(this.Panel2, 0, 2);
            this.TableLayoutPanel2.Controls.Add(this.TableLayoutPanel3, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.TableLayoutPanel4, 0, 3);
            this.TableLayoutPanel2.Controls.Add(this.toolStrip2, 0, 0);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 4;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(1085, 685);
            this.TableLayoutPanel2.TabIndex = 1;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.btnDown);
            this.Panel2.Controls.Add(this.btnAdvance);
            this.Panel2.Controls.Add(this.btnUp);
            this.Panel2.Controls.Add(this.btnPush);
            this.Panel2.Controls.Add(this.btnChangeColor);
            this.Panel2.Controls.Add(this.Displayvalues);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(3, 516);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1079, 28);
            this.Panel2.TabIndex = 1;
            // 
            // btnAdvance
            // 
            this.btnAdvance.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvance.ForeColor = System.Drawing.Color.Black;
            this.btnAdvance.Location = new System.Drawing.Point(702, -2);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(104, 32);
            this.btnAdvance.TabIndex = 32;
            this.btnAdvance.Text = "Ad&vance Study";
            this.btnAdvance.UseVisualStyleBackColor = false;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUp.Image = global::TeleRadReport.Properties.Resources.up_arrow;
            this.btnUp.Location = new System.Drawing.Point(9, -2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(35, 32);
            this.btnUp.TabIndex = 28;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.ForeColor = System.Drawing.Color.Black;
            this.btnPush.Location = new System.Drawing.Point(531, -2);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(165, 32);
            this.btnPush.TabIndex = 33;
            this.btnPush.Text = "Push To E&xtended Monitor";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.BackColor = System.Drawing.Color.SlateBlue;
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.ForeColor = System.Drawing.Color.Black;
            this.btnChangeColor.Location = new System.Drawing.Point(421, -2);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(104, 32);
            this.btnChangeColor.TabIndex = 34;
            this.btnChangeColor.Text = "Change &Color";
            this.btnChangeColor.UseVisualStyleBackColor = false;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 3;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.819277F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.15755F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel3.Controls.Add(this.Panel3, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.Panel1, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.toolStrip1, 0, 0);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 37);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 1;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(1079, 473);
            this.TableLayoutPanel3.TabIndex = 2;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Viewer);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(55, 3);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(751, 467);
            this.Panel3.TabIndex = 3;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.AttribList);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(812, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(264, 467);
            this.Panel1.TabIndex = 2;
            // 
            // AttribList
            // 
            this.AttribList.BackColor = System.Drawing.Color.Black;
            this.AttribList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttribList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttribList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttribList.ForeColor = System.Drawing.Color.White;
            this.AttribList.HideSelection = false;
            this.AttribList.Location = new System.Drawing.Point(0, 0);
            this.AttribList.Multiline = true;
            this.AttribList.Name = "AttribList";
            this.AttribList.ReadOnly = true;
            this.AttribList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AttribList.Size = new System.Drawing.Size(264, 467);
            this.AttribList.TabIndex = 19;
            this.AttribList.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnSelect,
            this.tbtnWindow,
            this.tbtnMagnify,
            this.toolStripSeparator1,
            this.tbtnRotClock,
            this.tbtnRotAntiClock,
            this.tbtnFlipVertical,
            this.tbtnFlipHorizontal,
            this.tbtnCrop,
            this.toolStripSeparator3,
            this.tbtnAddAnnot,
            this.tbtnEditAnnot,
            this.tbtnMeasurement,
            this.tbtnAngle});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(52, 473);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnSelect
            // 
            this.tbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSelect.Image = global::TeleRadReport.Properties.Resources.whitestyle_04_pointer;
            this.tbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSelect.Name = "tbtnSelect";
            this.tbtnSelect.Size = new System.Drawing.Size(50, 36);
            this.tbtnSelect.Text = "toolStripButton2";
            this.tbtnSelect.ToolTipText = "Select";
            this.tbtnSelect.Click += new System.EventHandler(this.tbtnSelect_Click);
            // 
            // tbtnWindow
            // 
            this.tbtnWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnWindow.Image = global::TeleRadReport.Properties.Resources.gradient_linear_pyramid;
            this.tbtnWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnWindow.Name = "tbtnWindow";
            this.tbtnWindow.Size = new System.Drawing.Size(50, 36);
            this.tbtnWindow.Text = "toolStripButton1";
            this.tbtnWindow.ToolTipText = "Window Level / Width";
            this.tbtnWindow.Click += new System.EventHandler(this.tbtnWindow_Click);
            // 
            // tbtnMagnify
            // 
            this.tbtnMagnify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnMagnify.Image = global::TeleRadReport.Properties.Resources.magnify_copy;
            this.tbtnMagnify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMagnify.Name = "tbtnMagnify";
            this.tbtnMagnify.Size = new System.Drawing.Size(50, 36);
            this.tbtnMagnify.Text = "toolStripButton3";
            this.tbtnMagnify.ToolTipText = "Magnify";
            this.tbtnMagnify.Click += new System.EventHandler(this.tbtnMagnify_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // tbtnRotClock
            // 
            this.tbtnRotClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnRotClock.Image = global::TeleRadReport.Properties.Resources.rotate_clockwise;
            this.tbtnRotClock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRotClock.Name = "tbtnRotClock";
            this.tbtnRotClock.Size = new System.Drawing.Size(50, 36);
            this.tbtnRotClock.Text = "toolStripButton1";
            this.tbtnRotClock.ToolTipText = "Rotate Clockwise";
            // 
            // tbtnRotAntiClock
            // 
            this.tbtnRotAntiClock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnRotAntiClock.Image = global::TeleRadReport.Properties.Resources.rotate_counter_clockwise;
            this.tbtnRotAntiClock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRotAntiClock.Name = "tbtnRotAntiClock";
            this.tbtnRotAntiClock.Size = new System.Drawing.Size(50, 36);
            this.tbtnRotAntiClock.Text = "toolStripButton2";
            this.tbtnRotAntiClock.ToolTipText = "Rotate Anti-Clockwise";
            // 
            // tbtnFlipVertical
            // 
            this.tbtnFlipVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnFlipVertical.Image = global::TeleRadReport.Properties.Resources.shape_flip_vertical;
            this.tbtnFlipVertical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnFlipVertical.Name = "tbtnFlipVertical";
            this.tbtnFlipVertical.Size = new System.Drawing.Size(50, 36);
            this.tbtnFlipVertical.Text = "toolStripButton3";
            this.tbtnFlipVertical.ToolTipText = "Flip Vertically";
            // 
            // tbtnFlipHorizontal
            // 
            this.tbtnFlipHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnFlipHorizontal.Image = global::TeleRadReport.Properties.Resources.shape_flip_horizontal;
            this.tbtnFlipHorizontal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnFlipHorizontal.Name = "tbtnFlipHorizontal";
            this.tbtnFlipHorizontal.Size = new System.Drawing.Size(50, 36);
            this.tbtnFlipHorizontal.Text = "toolStripButton4";
            this.tbtnFlipHorizontal.ToolTipText = "Flip Horizobtally";
            // 
            // tbtnCrop
            // 
            this.tbtnCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnCrop.Image = global::TeleRadReport.Properties.Resources.crop;
            this.tbtnCrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCrop.Name = "tbtnCrop";
            this.tbtnCrop.Size = new System.Drawing.Size(50, 36);
            this.tbtnCrop.Text = "toolStripButton1";
            this.tbtnCrop.ToolTipText = "Crop";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(50, 6);
            // 
            // tbtnAddAnnot
            // 
            this.tbtnAddAnnot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddAnnot.Image = global::TeleRadReport.Properties.Resources.pencil;
            this.tbtnAddAnnot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddAnnot.Name = "tbtnAddAnnot";
            this.tbtnAddAnnot.Size = new System.Drawing.Size(50, 36);
            this.tbtnAddAnnot.Text = "toolStripButton1";
            this.tbtnAddAnnot.ToolTipText = "Add Annotation";
            // 
            // tbtnEditAnnot
            // 
            this.tbtnEditAnnot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnEditAnnot.Image = global::TeleRadReport.Properties.Resources.edit_pencil;
            this.tbtnEditAnnot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEditAnnot.Name = "tbtnEditAnnot";
            this.tbtnEditAnnot.Size = new System.Drawing.Size(50, 36);
            this.tbtnEditAnnot.Text = "Edit Annotation";
            // 
            // tbtnMeasurement
            // 
            this.tbtnMeasurement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnMeasurement.Image = global::TeleRadReport.Properties.Resources.ruler;
            this.tbtnMeasurement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMeasurement.Name = "tbtnMeasurement";
            this.tbtnMeasurement.Size = new System.Drawing.Size(50, 36);
            this.tbtnMeasurement.Text = "toolStripButton1";
            this.tbtnMeasurement.ToolTipText = "Measurement Tool";
            // 
            // tbtnAngle
            // 
            this.tbtnAngle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAngle.Image = global::TeleRadReport.Properties.Resources.protractor;
            this.tbtnAngle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAngle.Name = "tbtnAngle";
            this.tbtnAngle.Size = new System.Drawing.Size(36, 36);
            this.tbtnAngle.Text = "toolStripButton2";
            this.tbtnAngle.ToolTipText = "Angle Measurement Tool";
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.ColumnCount = 2;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel4.Controls.Add(this.grpNotes, 1, 0);
            this.TableLayoutPanel4.Controls.Add(this.grpReports, 0, 0);
            this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 550);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 1;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(1079, 132);
            this.TableLayoutPanel4.TabIndex = 3;
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNotes);
            this.grpNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNotes.Location = new System.Drawing.Point(812, 3);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(264, 126);
            this.grpNotes.TabIndex = 26;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Clinical Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.HideSelection = false;
            this.txtNotes.Location = new System.Drawing.Point(3, 16);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(258, 107);
            this.txtNotes.TabIndex = 20;
            this.txtNotes.TabStop = false;
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.TableLayoutPanel6);
            this.grpReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReports.Location = new System.Drawing.Point(3, 3);
            this.grpReports.Name = "grpReports";
            this.grpReports.Size = new System.Drawing.Size(803, 126);
            this.grpReports.TabIndex = 22;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // TableLayoutPanel6
            // 
            this.TableLayoutPanel6.ColumnCount = 2;
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TableLayoutPanel6.Controls.Add(this.cmdReports, 1, 0);
            this.TableLayoutPanel6.Controls.Add(this.txtReports, 0, 0);
            this.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.TableLayoutPanel6.Name = "TableLayoutPanel6";
            this.TableLayoutPanel6.RowCount = 1;
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel6.Size = new System.Drawing.Size(797, 107);
            this.TableLayoutPanel6.TabIndex = 23;
            // 
            // cmdReports
            // 
            this.cmdReports.BackColor = System.Drawing.Color.SlateBlue;
            this.cmdReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReports.ForeColor = System.Drawing.Color.Black;
            this.cmdReports.Location = new System.Drawing.Point(776, 3);
            this.cmdReports.Name = "cmdReports";
            this.cmdReports.Size = new System.Drawing.Size(18, 101);
            this.cmdReports.TabIndex = 21;
            this.cmdReports.Text = "SEND";
            this.cmdReports.UseVisualStyleBackColor = false;
            // 
            // txtReports
            // 
            this.txtReports.BackColor = System.Drawing.Color.White;
            this.txtReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReports.Location = new System.Drawing.Point(3, 3);
            this.txtReports.Name = "txtReports";
            this.txtReports.Size = new System.Drawing.Size(767, 101);
            this.txtReports.TabIndex = 22;
            this.txtReports.Text = "";
            this.txtReports.DoubleClick += new System.EventHandler(this.txtReports_DoubleClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1085, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel5, 1, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1284, 691);
            this.TableLayoutPanel1.TabIndex = 37;
            // 
            // TableLayoutPanel5
            // 
            this.TableLayoutPanel5.ColumnCount = 1;
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel5.Controls.Add(this.GroupBox2, 0, 1);
            this.TableLayoutPanel5.Controls.Add(this.GroupBox1, 0, 0);
            this.TableLayoutPanel5.Controls.Add(this.Panel4, 0, 2);
            this.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel5.Location = new System.Drawing.Point(1094, 3);
            this.TableLayoutPanel5.Name = "TableLayoutPanel5";
            this.TableLayoutPanel5.RowCount = 3;
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanel5.Size = new System.Drawing.Size(187, 685);
            this.TableLayoutPanel5.TabIndex = 2;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.GroupBox5);
            this.Panel4.Controls.Add(this.GroupBox3);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(3, 482);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(181, 200);
            this.Panel4.TabIndex = 4;
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Image,
            this.Edit,
            this.Remote,
            this.Display,
            this.View,
            this.Tools,
            this.AboutThisExample,
            this.Logging});
            // 
            // Image
            // 
            this.Image.Index = 0;
            this.Image.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ImageRead,
            this.ImageWrite,
            this.PrintDICOM,
            this.PrintWindows,
            this.Import,
            this.Export,
            this.ExitOption});
            this.Image.Text = "File";
            // 
            // ImageRead
            // 
            this.ImageRead.Index = 0;
            this.ImageRead.Text = "Read file(s)";
            this.ImageRead.Visible = false;
            this.ImageRead.Click += new System.EventHandler(this.ImageRead_Click);
            // 
            // ImageWrite
            // 
            this.ImageWrite.Index = 1;
            this.ImageWrite.Text = "Write";
            this.ImageWrite.Visible = false;
            this.ImageWrite.Click += new System.EventHandler(this.ImageWrite_Click);
            // 
            // PrintDICOM
            // 
            this.PrintDICOM.Index = 2;
            this.PrintDICOM.Text = "Print (DICOM)";
            this.PrintDICOM.Click += new System.EventHandler(this.PrintDICOM_Click);
            // 
            // PrintWindows
            // 
            this.PrintWindows.Index = 3;
            this.PrintWindows.Text = "Print (Windows)";
            this.PrintWindows.Click += new System.EventHandler(this.PrintWindows_Click);
            // 
            // Import
            // 
            this.Import.Index = 4;
            this.Import.Text = "Import non-DICOM File";
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Index = 5;
            this.Export.Text = "Export to non-DICOM file";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // ExitOption
            // 
            this.ExitOption.Index = 6;
            this.ExitOption.Text = "Exit";
            this.ExitOption.Click += new System.EventHandler(this.ExitOption_Click);
            // 
            // Edit
            // 
            this.Edit.Index = 1;
            this.Edit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.DeleteSelected,
            this.DeleteAll});
            this.Edit.Text = "Edit";
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Index = 0;
            this.DeleteSelected.Text = "Delete Selected";
            this.DeleteSelected.Visible = false;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Index = 1;
            this.DeleteAll.Text = "Delete All";
            this.DeleteAll.Visible = false;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // Remote
            // 
            this.Remote.Index = 2;
            this.Remote.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Verify,
            this.Retrieve,
            this.SendSelected,
            this.SendAll});
            this.Remote.Text = "Remote";
            // 
            // Verify
            // 
            this.Verify.Index = 0;
            this.Verify.Text = "Ping Server";
            this.Verify.Click += new System.EventHandler(this.Verify_Click);
            // 
            // Retrieve
            // 
            this.Retrieve.Index = 1;
            this.Retrieve.Text = "Retrieve";
            this.Retrieve.Visible = false;
            this.Retrieve.Click += new System.EventHandler(this.Retrieve_Click);
            // 
            // SendSelected
            // 
            this.SendSelected.Index = 2;
            this.SendSelected.Text = "Send Selected";
            this.SendSelected.Visible = false;
            this.SendSelected.Click += new System.EventHandler(this.SendSelected_Click);
            // 
            // SendAll
            // 
            this.SendAll.Index = 3;
            this.SendAll.Text = "Send All";
            this.SendAll.Visible = false;
            this.SendAll.Click += new System.EventHandler(this.SendAll_Click);
            // 
            // Display
            // 
            this.Display.Index = 3;
            this.Display.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.DisplayNormal,
            this.FlipHorizontal,
            this.FlipVertical,
            this.RotateClockwise,
            this.RotateAntiClockwise,
            this.MenuItem1});
            this.Display.Text = "Display";
            // 
            // DisplayNormal
            // 
            this.DisplayNormal.Index = 0;
            this.DisplayNormal.Text = "Normal";
            this.DisplayNormal.Click += new System.EventHandler(this.DisplayNormal_Click);
            // 
            // FlipHorizontal
            // 
            this.FlipHorizontal.Index = 1;
            this.FlipHorizontal.Text = "Flip Horizontal";
            this.FlipHorizontal.Click += new System.EventHandler(this.FlipHorizontal_Click);
            // 
            // FlipVertical
            // 
            this.FlipVertical.Index = 2;
            this.FlipVertical.Text = "Flip Vertical";
            this.FlipVertical.Click += new System.EventHandler(this.FlipVertical_Click);
            // 
            // RotateClockwise
            // 
            this.RotateClockwise.Index = 3;
            this.RotateClockwise.Text = "Rotate Clockwise";
            this.RotateClockwise.Click += new System.EventHandler(this.RotateClockwise_Click);
            // 
            // RotateAntiClockwise
            // 
            this.RotateAntiClockwise.Index = 4;
            this.RotateAntiClockwise.Text = "Rotate Anti-Clockwise";
            this.RotateAntiClockwise.Click += new System.EventHandler(this.RotateAntiClockwise_Click);
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 5;
            this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CineModeForward,
            this.CineModeRepeat,
            this.CineModeOscillate,
            this.CineModeRepeatReverse,
            this.CineModeReverse,
            this.CineModeStatic});
            this.MenuItem1.Text = "CineMode";
            // 
            // CineModeForward
            // 
            this.CineModeForward.Index = 0;
            this.CineModeForward.Text = "Forward";
            this.CineModeForward.Click += new System.EventHandler(this.CineModeForward_Click);
            // 
            // CineModeRepeat
            // 
            this.CineModeRepeat.Index = 1;
            this.CineModeRepeat.Text = "Repeat";
            this.CineModeRepeat.Click += new System.EventHandler(this.CineModeRepeat_Click);
            // 
            // CineModeOscillate
            // 
            this.CineModeOscillate.Index = 2;
            this.CineModeOscillate.Text = "Oscillate";
            this.CineModeOscillate.Click += new System.EventHandler(this.CineModeOscillate_Click);
            // 
            // CineModeRepeatReverse
            // 
            this.CineModeRepeatReverse.Index = 3;
            this.CineModeRepeatReverse.Text = "RepeatReverse";
            this.CineModeRepeatReverse.Click += new System.EventHandler(this.CineModeRepeatReverse_Click);
            // 
            // CineModeReverse
            // 
            this.CineModeReverse.Index = 4;
            this.CineModeReverse.Text = "Reverse";
            this.CineModeReverse.Click += new System.EventHandler(this.CineModeReverse_Click);
            // 
            // CineModeStatic
            // 
            this.CineModeStatic.Index = 5;
            this.CineModeStatic.Text = "Static";
            this.CineModeStatic.Click += new System.EventHandler(this.CineModeStatic_Click);
            // 
            // View
            // 
            this.View.Index = 4;
            this.View.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ImageInformation,
            this.Options});
            this.View.Text = "View";
            // 
            // ImageInformation
            // 
            this.ImageInformation.Index = 0;
            this.ImageInformation.Text = "Image Information";
            this.ImageInformation.Click += new System.EventHandler(this.ImageInformation_Click);
            // 
            // Options
            // 
            this.Options.Index = 1;
            this.Options.Text = "Options";
            this.Options.Visible = false;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // Tools
            // 
            this.Tools.Index = 5;
            this.Tools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MakeNewImage,
            this.MenuItem2});
            this.Tools.Text = "Tools";
            // 
            // MakeNewImage
            // 
            this.MakeNewImage.Index = 0;
            this.MakeNewImage.Text = "Make New Image";
            this.MakeNewImage.Visible = false;
            this.MakeNewImage.Click += new System.EventHandler(this.MakeNewImage_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 1;
            this.MenuItem2.Text = "Set Advanced Study Tools";
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // AboutThisExample
            // 
            this.AboutThisExample.Index = 6;
            this.AboutThisExample.Text = "About TeleRad";
            this.AboutThisExample.Visible = false;
            // 
            // Logging
            // 
            this.Logging.Index = 7;
            this.Logging.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.LogLocation});
            this.Logging.Text = "Logging";
            this.Logging.Visible = false;
            // 
            // LogLocation
            // 
            this.LogLocation.Index = 0;
            this.LogLocation.Text = "Show Logging Options";
            this.LogLocation.Click += new System.EventHandler(this.LogLocation_Click);
            // 
            // ofdBrowse
            // 
            this.ofdBrowse.Filter = "Application Files(*.exe)|*.exe";
            this.ofdBrowse.Title = "EarthMovers - Browse Item Photo";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileName = "doc1";
            // 
            // frmSP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.MainMenu1;
            this.Name = "frmSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeleRad - Reporting Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.frmSP_GotFocus);
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CImageIndex)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomSlider)).EndInit();
            this.Viewer.ResumeLayout(false);
            this.Viewer.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel3.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TableLayoutPanel4.ResumeLayout(false);
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.grpReports.ResumeLayout(false);
            this.TableLayoutPanel6.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel5.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.NumericUpDown Rows;
        internal System.Windows.Forms.Button Replicate;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.NumericUpDown Columns;
        internal System.Windows.Forms.Label Displayvalues;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button CubicSpine;
        internal System.Windows.Forms.Button BSpine;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button MovingAverage;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button PixelValue;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton PixelButton;
        internal System.Windows.Forms.RadioButton MeasureButton;
        internal System.Windows.Forms.RadioButton EditAnnoBTN;
        internal System.Windows.Forms.RadioButton MagnifyBTN;
        internal System.Windows.Forms.RadioButton ProtractorBTN;
        internal System.Windows.Forms.RadioButton CobbBTN;
        internal System.Windows.Forms.RadioButton CropBTN;
        internal System.Windows.Forms.RadioButton AddAnnoBTN;
        internal System.Windows.Forms.RadioButton ScrollBTN;
        internal System.Windows.Forms.RadioButton WindowBTN;
        internal System.Windows.Forms.RadioButton SelectBTN;
        internal System.Windows.Forms.CheckBox AnatomicMarkers;
        internal System.Windows.Forms.NumericUpDown CImageIndex;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox Level1;
        internal System.Windows.Forms.TextBox Width1;
        internal System.Windows.Forms.TextBox Zoom1;
        internal System.Windows.Forms.CheckBox StretchToFit;
        internal System.Windows.Forms.Label LevelLabel;
        internal System.Windows.Forms.TrackBar LevelSlider;
        internal System.Windows.Forms.Label WidthLabel;
        internal System.Windows.Forms.TrackBar WidthSlider;
        internal System.Windows.Forms.Label ZoomLabel;
        internal System.Windows.Forms.TrackBar ZoomSlider;
        internal DicomObjects.DicomViewer Viewer;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblImgCount;
        internal System.Windows.Forms.Button btnDown;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnAdvance;
        internal System.Windows.Forms.Button btnUp;
        internal System.Windows.Forms.Button btnPush;
        internal System.Windows.Forms.Button btnChangeColor;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.TextBox AttribList;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox PatientName;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
        internal System.Windows.Forms.GroupBox grpNotes;
        internal System.Windows.Forms.TextBox txtNotes;
        internal System.Windows.Forms.GroupBox grpReports;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel6;
        internal System.Windows.Forms.Button cmdReports;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel5;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.MainMenu MainMenu1;
        internal System.Windows.Forms.MenuItem Image;
        internal System.Windows.Forms.MenuItem ImageRead;
        internal System.Windows.Forms.MenuItem ImageWrite;
        internal System.Windows.Forms.MenuItem PrintDICOM;
        internal System.Windows.Forms.MenuItem PrintWindows;
        internal System.Windows.Forms.MenuItem Import;
        internal System.Windows.Forms.MenuItem Export;
        internal System.Windows.Forms.MenuItem ExitOption;
        internal System.Windows.Forms.MenuItem Edit;
        internal System.Windows.Forms.MenuItem DeleteSelected;
        internal System.Windows.Forms.MenuItem DeleteAll;
        internal System.Windows.Forms.MenuItem Remote;
        internal System.Windows.Forms.MenuItem Verify;
        internal System.Windows.Forms.MenuItem Retrieve;
        internal System.Windows.Forms.MenuItem SendSelected;
        internal System.Windows.Forms.MenuItem SendAll;
        internal System.Windows.Forms.MenuItem Display;
        internal System.Windows.Forms.MenuItem DisplayNormal;
        internal System.Windows.Forms.MenuItem FlipHorizontal;
        internal System.Windows.Forms.MenuItem FlipVertical;
        internal System.Windows.Forms.MenuItem RotateClockwise;
        internal System.Windows.Forms.MenuItem RotateAntiClockwise;
        internal System.Windows.Forms.MenuItem MenuItem1;
        internal System.Windows.Forms.MenuItem CineModeForward;
        internal System.Windows.Forms.MenuItem CineModeRepeat;
        internal System.Windows.Forms.MenuItem CineModeOscillate;
        internal System.Windows.Forms.MenuItem CineModeRepeatReverse;
        internal System.Windows.Forms.MenuItem CineModeReverse;
        internal System.Windows.Forms.MenuItem CineModeStatic;
        internal System.Windows.Forms.MenuItem View;
        internal System.Windows.Forms.MenuItem ImageInformation;
        internal System.Windows.Forms.MenuItem Options;
        internal System.Windows.Forms.MenuItem Tools;
        internal System.Windows.Forms.MenuItem MakeNewImage;
        internal System.Windows.Forms.MenuItem MenuItem2;
        internal System.Windows.Forms.MenuItem AboutThisExample;
        internal System.Windows.Forms.MenuItem Logging;
        internal System.Windows.Forms.MenuItem LogLocation;
        internal System.Windows.Forms.ColorDialog ColorDialog1;
        internal System.Windows.Forms.OpenFileDialog ofdBrowse;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog;
        public System.Windows.Forms.RichTextBox txtReports;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSelect;
        private System.Windows.Forms.ToolStripButton tbtnWindow;
        private System.Windows.Forms.ToolStripButton tbtnMagnify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnAddAnnot;
        private System.Windows.Forms.ToolStripButton tbtnEditAnnot;
        private System.Windows.Forms.ToolStripButton tbtnCrop;
        private System.Windows.Forms.ToolStripButton tbtnRotClock;
        private System.Windows.Forms.ToolStripButton tbtnRotAntiClock;
        private System.Windows.Forms.ToolStripButton tbtnFlipVertical;
        private System.Windows.Forms.ToolStripButton tbtnFlipHorizontal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnMeasurement;
        private System.Windows.Forms.ToolStripButton tbtnAngle;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}