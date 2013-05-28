using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace TeleRadReport
{
    public partial class frmReportView : Form
    {
        Myconnectionclass CN = new Myconnectionclass();
        OdbcCommand Cmd;
        OdbcDataReader Rs1;

        public frmReportView()
        {
            InitializeComponent();
        }

        private void frmReportView_Load(object sender, EventArgs e)
        {
            this.ReportTemplatesTableAdapter.Fill(this.DicomServerDBDataSet2.ReportTemplates);
            Show_Reports();
        }

        public bool Show_Reports()
        {
            if (string.IsNullOrEmpty(TeleRadReport.modMain.StudyID))
            {
                //MessageBox.Show("Please select any DICOM Image", "TeleRad-Client", MessageBoxButtons.OK)
                return true;
            }

            CN.OpenConnection();
            Cmd = new System.Data.Odbc.OdbcCommand("SELECT * FROM Reports WHERE StudyUID='" + TeleRadReport.modMain.StudyID + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            Rs1.Read();
            if (Rs1["IsReports"].ToString() == true.ToString())
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

    }
}
