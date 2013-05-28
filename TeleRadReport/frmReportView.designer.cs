using System;
namespace TeleRadReport
{
    partial class frmReportView
    {
        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportView));
            this.cmdPrint = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtReports = new System.Windows.Forms.RichTextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStudyTime = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtStudyDate = new System.Windows.Forms.TextBox();
            this.txtStudyID = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtPatSex = new System.Windows.Forms.TextBox();
            this.txtPatDOB = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtPatName = new System.Windows.Forms.TextBox();
            this.txtPatID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ReportTemplatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DicomServerDBDataSet2 = new TeleRadReport.DicomServerDBDataSet2();
            this.ReportTemplatesTableAdapter = new TeleRadReport.DicomServerDBDataSet2TableAdapters.ReportTemplatesTableAdapter();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTemplatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicomServerDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPrint
            // 
            this.cmdPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.Location = new System.Drawing.Point(922, 20);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(78, 35);
            this.cmdPrint.TabIndex = 21;
            this.cmdPrint.Text = "PRINT";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.txtReports);
            this.GroupBox4.Location = new System.Drawing.Point(14, 68);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(986, 657);
            this.GroupBox4.TabIndex = 50;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Reports";
            // 
            // txtReports
            // 
            this.txtReports.BackColor = System.Drawing.Color.White;
            this.txtReports.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReports.Location = new System.Drawing.Point(6, 15);
            this.txtReports.Name = "txtReports";
            this.txtReports.ReadOnly = true;
            this.txtReports.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtReports.Size = new System.Drawing.Size(974, 636);
            this.txtReports.TabIndex = 43;
            this.txtReports.Text = "";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtStudyTime);
            this.GroupBox3.Controls.Add(this.Label7);
            this.GroupBox3.Controls.Add(this.txtStudyDate);
            this.GroupBox3.Controls.Add(this.txtStudyID);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.txtPatSex);
            this.GroupBox3.Controls.Add(this.txtPatDOB);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.txtPatName);
            this.GroupBox3.Controls.Add(this.txtPatID);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Location = new System.Drawing.Point(14, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(902, 59);
            this.GroupBox3.TabIndex = 54;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Test Information";
            // 
            // txtStudyTime
            // 
            this.txtStudyTime.Enabled = false;
            this.txtStudyTime.Location = new System.Drawing.Point(761, 36);
            this.txtStudyTime.Name = "txtStudyTime";
            this.txtStudyTime.Size = new System.Drawing.Size(132, 20);
            this.txtStudyTime.TabIndex = 13;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(694, 39);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(66, 13);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Study Time :";
            // 
            // txtStudyDate
            // 
            this.txtStudyDate.Enabled = false;
            this.txtStudyDate.Location = new System.Drawing.Point(551, 36);
            this.txtStudyDate.Name = "txtStudyDate";
            this.txtStudyDate.Size = new System.Drawing.Size(132, 20);
            this.txtStudyDate.TabIndex = 11;
            // 
            // txtStudyID
            // 
            this.txtStudyID.Enabled = false;
            this.txtStudyID.Location = new System.Drawing.Point(551, 13);
            this.txtStudyID.Name = "txtStudyID";
            this.txtStudyID.Size = new System.Drawing.Size(342, 20);
            this.txtStudyID.TabIndex = 10;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(474, 39);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 13);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Study Date :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(474, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(54, 13);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Study ID :";
            // 
            // txtPatSex
            // 
            this.txtPatSex.Enabled = false;
            this.txtPatSex.Location = new System.Drawing.Point(350, 35);
            this.txtPatSex.Name = "txtPatSex";
            this.txtPatSex.Size = new System.Drawing.Size(44, 20);
            this.txtPatSex.TabIndex = 7;
            // 
            // txtPatDOB
            // 
            this.txtPatDOB.Enabled = false;
            this.txtPatDOB.Location = new System.Drawing.Point(350, 12);
            this.txtPatDOB.Name = "txtPatDOB";
            this.txtPatDOB.Size = new System.Drawing.Size(93, 20);
            this.txtPatDOB.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(273, 39);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Patient Sex :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(273, 15);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(72, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Patient DOB :";
            // 
            // txtPatName
            // 
            this.txtPatName.Enabled = false;
            this.txtPatName.Location = new System.Drawing.Point(88, 36);
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.Size = new System.Drawing.Size(179, 20);
            this.txtPatName.TabIndex = 3;
            // 
            // txtPatID
            // 
            this.txtPatID.Enabled = false;
            this.txtPatID.Location = new System.Drawing.Point(88, 13);
            this.txtPatID.Name = "txtPatID";
            this.txtPatID.Size = new System.Drawing.Size(132, 20);
            this.txtPatID.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Patient Name :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Patient ID :";
            // 
            // ReportTemplatesBindingSource
            // 
            this.ReportTemplatesBindingSource.DataMember = "ReportTemplates";
            this.ReportTemplatesBindingSource.DataSource = this.DicomServerDBDataSet2;
            // 
            // DicomServerDBDataSet2
            // 
            this.DicomServerDBDataSet2.DataSetName = "DicomServerDBDataSet2";
            this.DicomServerDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportTemplatesTableAdapter
            // 
            this.ReportTemplatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 737);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.cmdPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeleRad - Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportView_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTemplatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicomServerDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.Button cmdPrint;
        internal System.Windows.Forms.GroupBox GroupBox4;
        public System.Windows.Forms.RichTextBox txtReports;
        internal TeleRadReport.DicomServerDBDataSet2 DicomServerDBDataSet2;
        internal System.Windows.Forms.BindingSource ReportTemplatesBindingSource;
        internal TeleRadReport.DicomServerDBDataSet2TableAdapters.ReportTemplatesTableAdapter ReportTemplatesTableAdapter;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPatID;
        internal System.Windows.Forms.TextBox txtPatName;
        internal System.Windows.Forms.TextBox txtPatSex;
        internal System.Windows.Forms.TextBox txtPatDOB;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtStudyTime;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtStudyDate;
        internal System.Windows.Forms.TextBox txtStudyID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
    }
}