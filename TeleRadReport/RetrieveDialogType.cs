using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using Microsoft.VisualBasic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.ServiceModel;
using ClearCanvas.ImageViewer.Common.Automation;
using System.Configuration;

namespace TeleRadReport
{
    public partial class RetrieveDialogType : Form
    {
        Form chld = new Form();
        Myconnectionclass CN1 = new Myconnectionclass();
        OdbcCommand CMD1;
        int i;
        Color WoN_WoR;
        Color WN_WoR;
        Color WN_WR = new Color();
        private StudyMoverSettings _MoverSettings;

        public RetrieveDialogType()
        {
            InitializeComponent();
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            DataGridView1.Refresh();
            PatientStudyView.Clear();
            this.PatientStudyViewTableAdapter.Fill(this.PatientStudyView.PatientStudyView);
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = PatientStudyViewBindingSource;
            this.Cursor = Cursors.Default;
            GridDesign();

            txtFirstName.Text = "";
            txtPatientID.Text = "";
            txtReferringMD.Text = "";
            dtpDateFrom.Value = DateTime.Now.Date;
            dtpDateTo.Value = DateTime.Now.Date;
            chkSearchDate.Checked = false;
        }

        public int GridDesign()
        {
            int lb2 = 0;
            int lb3 = 0;
            int lb4 = 0;
            lb2 = 0;
            lb3 = 0;
            lb4 = 0;
            label2.Text = "Without Notes && Reports";
            label3.Text = "Notes without Reports";
            label4.Text = "With Notes && Reports";
            DataGridViewCellStyle m_SelectedStyle = default(DataGridViewCellStyle);
            DataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray;
            DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            DataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            for (i = 0; i <= DataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(DataGridView1.Rows[i].Cells[13].Value) == false & Convert.ToBoolean(DataGridView1.Rows[i].Cells[14].Value) == false)
                {
                    m_SelectedStyle = new DataGridViewCellStyle();
                    m_SelectedStyle.BackColor = WoN_WoR;
                    DataGridView1.Rows[i].DefaultCellStyle = m_SelectedStyle;
                    lb2 = lb2 + 1;
                }
                if (Convert.ToBoolean(DataGridView1.Rows[i].Cells[13].Value) == true & Convert.ToBoolean(DataGridView1.Rows[i].Cells[14].Value) == false)
                {
                    m_SelectedStyle = new DataGridViewCellStyle();
                    m_SelectedStyle.BackColor = WN_WoR;
                    DataGridView1.Rows[i].DefaultCellStyle = m_SelectedStyle;
                    lb3 = lb3 + 1;
                }
                if (Convert.ToBoolean(DataGridView1.Rows[i].Cells[13].Value) == true & Convert.ToBoolean(DataGridView1.Rows[i].Cells[14].Value) == true)
                {
                    m_SelectedStyle = new DataGridViewCellStyle();
                    m_SelectedStyle.BackColor = WN_WR;
                    DataGridView1.Rows[i].DefaultCellStyle = m_SelectedStyle;
                    lb4 = lb4 + 1;
                }
            }
            label2.Text = label2.Text + ": " + lb2 + " Records";
            label3.Text = label3.Text + ": " + lb3 + " Records";
            label4.Text = label4.Text + ": " + lb4 + " Records";
            DataGridView1.Refresh();
            return 1;
        }

        private void RetrieveDialogType_Load(object sender, EventArgs e)
        {
            dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            dtpDateTo.CustomFormat = "dd/MM/yyyy";
            dtpDateFrom.Value = DateTime.Now.Date;
            dtpDateTo.Value = DateTime.Now.Date;
            TeleRadReport.modMain.Retreived = false;
            DataGridView1.Refresh();
            this.Cursor = Cursors.WaitCursor;
            this.PatientStudyViewTableAdapter.Fill(this.PatientStudyView.PatientStudyView);
            this.Cursor = Cursors.Default;
            WoN_WoR = Color.White;
            WN_WoR = Color.LightPink;
            WN_WR = Color.PowderBlue;
            GridDesign();
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridDesign();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void RetrieveDialogType_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            Application.Exit();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            frmReportView Rep = new frmReportView();
            if (DataGridView1.SelectedCells[14].Value.ToString() == false.ToString())
            {
                MessageBox.Show("No Report to view", "TeleRad - Client", MessageBoxButtons.OK);
                return;
            }
            TeleRadReport.modMain.StudyID = DataGridView1.SelectedCells[5].Value.ToString();
            Rep.txtPatID.Text = DataGridView1.SelectedCells[1].Value.ToString();
            Rep.txtPatName.Text = DataGridView1.SelectedCells[2].Value.ToString();
            if (DataGridView1.SelectedCells[3].Value != null)
                Rep.txtPatDOB.Text = DataGridView1.SelectedCells[3].Value.ToString();
            if (DataGridView1.SelectedCells[4].Value != null)
                Rep.txtPatSex.Text = DataGridView1.SelectedCells[4].Value.ToString();
            Rep.txtStudyID.Text = DataGridView1.SelectedCells[5].Value.ToString();
            Rep.txtStudyDate.Text = DataGridView1.SelectedCells[6].Value.ToString();
            Rep.txtStudyTime.Text = DataGridView1.SelectedCells[7].Value.ToString();

            Rep.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog1.ShowDialog();
            if (ColorDialog1.Color == Color.Black)
            {
                MessageBox.Show("Black is not allowed", "TeleRad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            WoN_WoR = ColorDialog1.Color;
            PictureBox1.BackColor = WoN_WoR;
            GridDesign();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            ColorDialog1.ShowDialog();
            if (ColorDialog1.Color == Color.Black)
            {
                MessageBox.Show("Black is not allowed", "TeleRad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            WN_WoR = ColorDialog1.Color;
            PictureBox2.BackColor = WN_WoR;
            GridDesign();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            ColorDialog1.ShowDialog();
            if (ColorDialog1.Color == Color.Black)
            {
                MessageBox.Show("Black is not allowed", "TeleRad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            WN_WR = ColorDialog1.Color;
            PictureBox3.BackColor = WN_WR;
            GridDesign();
        }

        private void DataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        #region CheckBox Events

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            chkCR.Checked = chkAll.Checked;
            chkCT.Checked = chkAll.Checked;
            chkDX.Checked = chkAll.Checked;
            chkES.Checked = chkAll.Checked;
            chkMG.Checked = chkAll.Checked;
            chkMR.Checked = chkAll.Checked;
            chkNM.Checked = chkAll.Checked;
            chkOT.Checked = chkAll.Checked;
            chkPT.Checked = chkAll.Checked;
            chkRF.Checked = chkAll.Checked;
            chkRT.Checked = chkAll.Checked;
            chkSC.Checked = chkAll.Checked;
            chkUS.Checked = chkAll.Checked;
            chkXA.Checked = chkAll.Checked;
        }

        private void chkCR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCR.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkCT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCT.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkDX_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDX.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkES_CheckedChanged(object sender, EventArgs e)
        {
            if (chkES.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkMG_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMG.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkMR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMR.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkNM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNM.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkOT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOT.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkPT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPT.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkRF_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRF.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkRT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRT.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkSC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSC.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkUS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUS.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        private void chkXA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXA.Checked == false)
            {
                chkAll.Checked = false;
            }
        }

        #endregion

        private void btnToday_Click(object sender, EventArgs e)
        {
            string sqlQuery = "";

            if (chkAll.Checked)
            {
                sqlQuery = "select * from PatientStudyView where datepart(dd,StudyDate)=" + DateTime.Now.Day.ToString() + " and  datepart(MM,StudyDate)=" + DateTime.Now.Month.ToString() + " and  datepart(yy,StudyDate)=" + DateTime.Now.Year.ToString() + "";
            }
            else
            {
                string Mod = "";
                bool MoreThanOne = false;
                if (chkCR.Checked)
                {
                    Mod = "Modality='CR'";
                    MoreThanOne = true;
                }
                if (chkCT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='CT'";
                    else
                        Mod = "Modality='CT'";
                    MoreThanOne = true;
                }
                if (chkDX.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='DX'";
                    else
                        Mod = "Modality='DX'";
                    MoreThanOne = true;
                }
                if (chkES.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='ES'";
                    else
                        Mod = "Modality='ES'";
                    MoreThanOne = true;
                }
                if (chkMG.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='MG'";
                    else
                        Mod = "Modality='MG'";
                    MoreThanOne = true;
                }
                if (chkMR.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='MR'";
                    else
                        Mod = "Modality='MR'";
                    MoreThanOne = true;
                }
                if (chkNM.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='NM'";
                    else
                        Mod = "Modality='NM'";
                    MoreThanOne = true;
                }
                if (chkOT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='OT'";
                    else
                        Mod = "Modality='OT'";
                    MoreThanOne = true;
                }
                if (chkPT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='PT'";
                    else
                        Mod = "Modality='PT'";
                    MoreThanOne = true;
                }
                if (chkRF.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='RF'";
                    else
                        Mod = "Modality='RF'";
                    MoreThanOne = true;
                }
                if (chkRT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='RT'";
                    else
                        Mod = "Modality='RT'";
                    MoreThanOne = true;
                }
                if (chkSC.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='SC'";
                    else
                        Mod = "Modality='SC'";
                    MoreThanOne = true;
                }
                if (chkUS.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='US'";
                    else
                        Mod = "Modality='US'";
                    MoreThanOne = true;
                }
                if (chkXA.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='XA'";
                    else
                        Mod = "Modality='XA'";
                    MoreThanOne = true;
                }
                sqlQuery = "select * from PatientStudyView where datepart(dd,StudyDate)=" + DateTime.Now.Day.ToString() + " and  datepart(MM,StudyDate)=" + DateTime.Now.Month.ToString() + " and  datepart(yy,StudyDate)=" + DateTime.Now.Year.ToString() + " AND (" + Mod + ")";
            }

            CN1.OpenConnection();
            CMD1 = new System.Data.Odbc.OdbcCommand(sqlQuery, CN1.DBConnection);

            //Dim dtst As New DataSet
            DicomServerDBDataSet1.PatientStudyViewDataTable table = new DicomServerDBDataSet1.PatientStudyViewDataTable();
            System.Data.Odbc.OdbcDataAdapter adptr = new System.Data.Odbc.OdbcDataAdapter();
            adptr.SelectCommand = CMD1;
            adptr.Fill(table);
            DataGridView1.Refresh();
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = table;
            this.Cursor = Cursors.Default;
            GridDesign();
            CMD1.Dispose();
            CN1.closeconnection();
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            string sqlQuery = "";

            if (chkAll.Checked)
            {
                sqlQuery = "select * from PatientStudyView where datepart(dd,StudyDate)=" + DateTime.Now.AddDays(-1).Day.ToString() + " and  datepart(MM,StudyDate)=" + DateTime.Now.AddDays(-1).Month.ToString() + " and  datepart(yy,StudyDate)=" + DateTime.Now.AddDays(-1).Year.ToString() + "";
            }
            else
            {
                string Mod = "";
                bool MoreThanOne = false;
                if (chkCR.Checked)
                {
                    Mod = "Modality='CR'";
                    MoreThanOne = true;
                }
                if (chkCT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='CT'";
                    else
                        Mod = "Modality='CT'";
                    MoreThanOne = true;
                }
                if (chkDX.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='DX'";
                    else
                        Mod = "Modality='DX'";
                    MoreThanOne = true;
                }
                if (chkES.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='ES'";
                    else
                        Mod = "Modality='ES'";
                    MoreThanOne = true;
                }
                if (chkMG.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='MG'";
                    else
                        Mod = "Modality='MG'";
                    MoreThanOne = true;
                }
                if (chkMR.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='MR'";
                    else
                        Mod = "Modality='MR'";
                    MoreThanOne = true;
                }
                if (chkNM.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='NM'";
                    else
                        Mod = "Modality='NM'";
                    MoreThanOne = true;
                }
                if (chkOT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='OT'";
                    else
                        Mod = "Modality='OT'";
                    MoreThanOne = true;
                }
                if (chkPT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='PT'";
                    else
                        Mod = "Modality='PT'";
                    MoreThanOne = true;
                }
                if (chkRF.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='RF'";
                    else
                        Mod = "Modality='RF'";
                    MoreThanOne = true;
                }
                if (chkRT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='RT'";
                    else
                        Mod = "Modality='RT'";
                    MoreThanOne = true;
                }
                if (chkSC.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='SC'";
                    else
                        Mod = "Modality='SC'";
                    MoreThanOne = true;
                }
                if (chkUS.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='US'";
                    else
                        Mod = "Modality='US'";
                    MoreThanOne = true;
                }
                if (chkXA.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='XA'";
                    else
                        Mod = "Modality='XA'";
                    MoreThanOne = true;
                }
                sqlQuery = "select * from PatientStudyView where datepart(dd,StudyDate)=" + DateTime.Now.AddDays(-1).Day.ToString() + " and  datepart(MM,StudyDate)=" + DateTime.Now.AddDays(-1).Month.ToString() + " and  datepart(yy,StudyDate)=" + DateTime.Now.AddDays(-1).Year.ToString() + " AND (" + Mod + ")";
            }

            CN1.OpenConnection();
            CMD1 = new System.Data.Odbc.OdbcCommand(sqlQuery, CN1.DBConnection);

            //Dim dtst As New DataSet
            DicomServerDBDataSet1.PatientStudyViewDataTable table = new DicomServerDBDataSet1.PatientStudyViewDataTable();
            System.Data.Odbc.OdbcDataAdapter adptr = new System.Data.Odbc.OdbcDataAdapter();
            adptr.SelectCommand = CMD1;
            adptr.Fill(table);
            DataGridView1.Refresh();
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = table;
            this.Cursor = Cursors.Default;
            GridDesign();
            CMD1.Dispose();
            CN1.closeconnection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text.Length <= 0 && txtFirstName.Text.Length <= 0 && txtReferringMD.Text.Length <= 0 && chkSearchDate.Checked == false)
                return;

            string strSQL = "";
            string varCode = "";
            string varName = "";
            string varPhys = "";

            if (txtPatientID.Text.Length > 0)
            {
                varCode = "%" + txtPatientID.Text + "%";
            }
            if (txtFirstName.Text.Length > 0)
            {
                varName = "%" + txtFirstName.Text + "%";
            }
            if (txtReferringMD.Text.Length > 0)
            {
                varPhys = "%" + txtReferringMD.Text + "%";
            }

            if (chkAll.Checked)
            {
                if (chkSearchDate.Checked)
                {
                    strSQL = "SELECT * FROM PatientStudyView  WHERE (PatientID LIKE '" + varCode + "' OR PatientName_DICOM LIKE '" + varName + "' or ReferringPhysician_DICOM like '" + varPhys + "') and convert(date,StudyDate) BETWEEN '" + dtpDateFrom.Value.ToString("yyyy-MM-dd") + "' and '" + dtpDateTo.Value.ToString("yyyy-MM-dd") + "' order by StudyDate desc";
                }
                else
                {
                    strSQL = "SELECT * FROM PatientStudyView  WHERE PatientID LIKE '" + varCode + "' OR PatientName_DICOM LIKE '" + varName + "' or ReferringPhysician_DICOM like '" + varPhys + "' order by StudyDate desc";
                }

                if (string.IsNullOrEmpty(varCode) && string.IsNullOrEmpty(varName) && string.IsNullOrEmpty(varPhys) && chkSearchDate.Checked)
                {
                    strSQL = "SELECT * FROM PatientStudyView  WHERE convert(date,StudyDate) BETWEEN '" + dtpDateFrom.Value.ToString("yyyy-MM-dd") + "' and '" + dtpDateTo.Value.ToString("yyyy-MM-dd") + "' order by StudyDate desc";
                }
            }
            else
            {
                string Mod = "";
                bool MoreThanOne = false;
                if (chkCR.Checked)
                {
                    Mod = "Modality='CR'";
                    MoreThanOne = true;
                }
                if (chkCT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='CT'";
                    else
                        Mod = "Modality='CT'";
                    MoreThanOne = true;
                }
                if (chkDX.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='DX'";
                    else
                        Mod = "Modality='DX'";
                    MoreThanOne = true;
                }
                if (chkES.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='ES'";
                    else
                        Mod = "Modality='ES'";
                    MoreThanOne = true;
                }
                if (chkMG.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='MG'";
                    else
                        Mod = "Modality='MG'";
                    MoreThanOne = true;
                }
                if (chkMR.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='MR'";
                    else
                        Mod = "Modality='MR'";
                    MoreThanOne = true;
                }
                if (chkNM.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='NM'";
                    else
                        Mod = "Modality='NM'";
                    MoreThanOne = true;
                }
                if (chkOT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='OT'";
                    else
                        Mod = "Modality='OT'";
                    MoreThanOne = true;
                }
                if (chkPT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='PT'";
                    else
                        Mod = "Modality='PT'";
                    MoreThanOne = true;
                }
                if (chkRF.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='RF'";
                    else
                        Mod = "Modality='RF'";
                    MoreThanOne = true;
                }
                if (chkRT.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='RT'";
                    else
                        Mod = "Modality='RT'";
                    MoreThanOne = true;
                }
                if (chkSC.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='SC'";
                    else
                        Mod = "Modality='SC'";
                    MoreThanOne = true;
                }
                if (chkUS.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='US'";
                    else
                        Mod = "Modality='US'";
                    MoreThanOne = true;
                }
                if (chkXA.Checked)
                {
                    if (MoreThanOne)
                        Mod = Mod + " OR Modality='XA'";
                    else
                        Mod = "Modality='XA'";
                    MoreThanOne = true;
                }

                if (chkSearchDate.Checked)
                {
                    strSQL = "SELECT * FROM PatientStudyView  WHERE (PatientID LIKE '" + varCode + "' OR PatientName_DICOM LIKE '" + varName + "' or ReferringPhysician_DICOM like '" + varPhys + "') and convert(date,StudyDate) BETWEEN '" + dtpDateFrom.Value.ToString("yyyy-MM-dd") + "' and '" + dtpDateTo.Value.ToString("yyyy-MM-dd") + "' AND (" + Mod + ") order by StudyDate desc";
                }
                else
                {
                    strSQL = "SELECT * FROM PatientStudyView  WHERE PatientID LIKE '" + varCode + "' OR PatientName_DICOM LIKE '" + varName + "' or ReferringPhysician_DICOM like '" + varPhys + "' AND (" + Mod + ") order by StudyDate desc";
                }

                if (varCode.Length <= 0 && varName.Length <= 0 && varPhys.Length <= 0 && chkSearchDate.Checked)
                {
                    strSQL = "SELECT * FROM PatientStudyView  WHERE convert(date,StudyDate) BETWEEN '" + dtpDateFrom.Value.ToString("yyyy-MM-dd") + "' and '" + dtpDateTo.Value.ToString("yyyy-MM-dd") + "' AND (" + Mod + ") order by StudyDate desc";
                }
            }

            CN1.OpenConnection();
            CMD1 = new System.Data.Odbc.OdbcCommand(strSQL, CN1.DBConnection);

            //Dim dtst As New DataSet
            DicomServerDBDataSet1.PatientStudyViewDataTable table = new DicomServerDBDataSet1.PatientStudyViewDataTable();
            System.Data.Odbc.OdbcDataAdapter adptr = new System.Data.Odbc.OdbcDataAdapter();
            adptr.SelectCommand = CMD1;
            adptr.Fill(table);
            DataGridView1.Refresh();
            DataGridView1.DataSource = null;
            DataGridView1.DataSource = table;
            this.Cursor = Cursors.Default;
            GridDesign();
            CMD1.Dispose();
            CN1.closeconnection();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DataGridView1.Columns[e.ColumnIndex].Name.Equals("ImgNotes"))
            {
                if (Convert.ToBoolean(DataGridView1.Rows[e.RowIndex].Cells["IsNotes"].Value) == true)
                {
                    e.Value = TeleRadReport.Properties.Resources.circle_green;
                }
            }
            if (DataGridView1.Columns[e.ColumnIndex].Name.Equals("ImgReports"))
            {
                if (Convert.ToBoolean(DataGridView1.Rows[e.RowIndex].Cells["IsReports"].Value) == true)
                {
                    e.Value = TeleRadReport.Properties.Resources.circle_green;
                }
            }
        }

        private void btnViewNotes_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedCells[13].Value.ToString() == false.ToString())
            {
                MessageBox.Show("No Notes to view", "TeleRad - Client", MessageBoxButtons.OK);
                return;
            }

            Myconnectionclass CN = new Myconnectionclass();
            OdbcCommand Cmd;
            OdbcDataReader Rs1;

            CN.OpenConnection();
            Cmd = new System.Data.Odbc.OdbcCommand("SELECT * FROM Reports WHERE StudyUID='" + DataGridView1.SelectedCells[5].Value.ToString() + "'", CN.DBConnection);
            Rs1 = Cmd.ExecuteReader();
            Rs1.Read();
            if (Convert.ToBoolean(Rs1["IsNotes"]) == true)
            {
                MessageBox.Show("Notes sent: " + Rs1["Notes"].ToString(), "TeleRad - Client", MessageBoxButtons.OK);
            }
            Rs1.Close();
            Cmd.Dispose();
            CN.closeconnection();
        }

        public static StudyMoverSettings LoadSettingfromXmlFile()
        {
            string FileName = Properties.Resources.StudyMoverSettingsFilePath;
            XmlSerializer ser = new XmlSerializer(typeof(StudyMoverSetting));
            TextReader reader = new StreamReader(Path.GetFullPath(FileName));
            StudyMoverSetting studyxset = (StudyMoverSetting)ser.Deserialize(reader);
            return studyxset.Items.Single();
        }

        private void btnRetreive_Click(object sender, EventArgs e)
        {

            if (DataGridView1.SelectedRows == null)
            {
                MessageBox.Show(
                                "Please Select a Study to Retrive It.",
                                "Information- " + Application.ProductName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                               );
                return;
            }

            if (DataGridView1.SelectedCells[1].Value != null)
                modMain.PatName = DataGridView1.SelectedCells[1].Value.ToString();
            if (DataGridView1.SelectedCells[3].Value != null)
                modMain.PatDOB = DataGridView1.SelectedCells[3].Value.ToString();
            if (DataGridView1.SelectedCells[2].Value != null)
                modMain.PatSex = DataGridView1.SelectedCells[2].Value.ToString();
            if (DataGridView1.SelectedCells[5].Value != null)
                modMain.StudyID = DataGridView1.SelectedCells[5].Value.ToString();
            if (DataGridView1.SelectedCells[6].Value != null)
                modMain.StudyDate = DataGridView1.SelectedCells[6].Value.ToString();
            if (DataGridView1.SelectedCells[7].Value != null)
                modMain.StudyTime = DataGridView1.SelectedCells[7].Value.ToString();

            //_MoverSettings = LoadSettingfromXmlFile();

            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(ConfigurationManager.AppSettings["AutomationServiceUrl"]);
            ViewerAutomationServiceClient client = new ViewerAutomationServiceClient(binding, endpoint);
            try
            {
                client.Open();
                OpenStudiesRequest request = new OpenStudiesRequest();
                request.ActivateIfAlreadyOpen = true;
                List<OpenStudyInfo> studiesToOpen = new List<OpenStudyInfo>();
                OpenStudyInfo studyInfo = new OpenStudyInfo(modMain.StudyID); 
                studiesToOpen.Add(studyInfo);
                request.StudiesToOpen = studiesToOpen;
                client.OpenStudies(request);
                client.Close();
            }
            catch (Exception x)
            {
                client.Abort();
                MessageBox.Show(x.Message);
            }
            //this.Close();
        }

    }
}
