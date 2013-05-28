using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.Odbc;

namespace TeleRadReport
{
    public partial class frmLogIn : Form
    {
        bool nowConnected = false;
        string errMsg = "";
        Myconnectionclass CN = new Myconnectionclass();
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataReader Rs1;
        string UID, PWD, UType;

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void Command1_Click(object sender, EventArgs e)
        {
            nowConnected = false;
            if (File.Exists(Environment.CurrentDirectory + "\\RemLog"))
            {
                StreamReader file = new StreamReader(Environment.CurrentDirectory + "\\RemLog");
                string line = "";
                int counter = 1;
                while ((line = file.ReadLine()) != null)
                {
                    switch (counter++)
                    {
                        case 1:
                            UID = line;
                            break;
                        case 2:
                            PWD = line;
                            break;
                        case 3:
                            UType = line;
                            break;
                        default:
                            break;
                    }
                }
                if (UID == txtUser.Text & PWD == txtPwd.Text)
                {
                    nowConnected = true;
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                    txtUser.Focus();
                    txtUser.SelectionStart = 0;
                    txtUser.SelectionLength = txtUser.Text.Length;
                }
            }
            else
            {
                CN.OpenConnection();
                cmd = new System.Data.Odbc.OdbcCommand("SELECT * FROM UserMaster WHERE UserName='" + txtUser.Text + "' AND EncodedPass='" + txtPwd.Text + "'", CN.DBConnection);
                Rs1 = cmd.ExecuteReader();
                if (Rs1.HasRows)
                {
                    StreamWriter file = new StreamWriter(Environment.CurrentDirectory + "\\RemLog");
                    UID = Rs1["UserName"].ToString();
                    PWD = Rs1["EncodedPass"].ToString();
                    UType = Rs1["UserType"].ToString();
                    Rs1.Close();
                    CN.closeconnection();
                    file.WriteLine(UID);
                    file.WriteLine(PWD);
                    file.WriteLine(UType);
                    file.Close();
                    nowConnected = true;
                }
                else
                {
                    Rs1.Close();
                    CN.closeconnection();
                    MessageBox.Show("Invalid Login");
                    txtUser.Focus();
                    txtUser.SelectionStart = 0;
                    txtUser.SelectionLength = txtUser.Text.Length;
                }
            }

            if (nowConnected == true)
            {
                RetrieveDialogType frmRet = new RetrieveDialogType();

                //this.Hide();
                if (UType == "1")
                {
                    //frmAd.ShowDialog();
                }
                if (UType == "2")
                    frmRet.ShowDialog();
                if (UType == "3")
                {
                    //frmRet.BackColor = Color.SlateBlue
                    //frmRet.Retrieve.BackColor = Color.DarkSlateBlue
                    //frmRet.Retrieve.ForeColor = Color.White
                    //frmRet.btnViewReport.BackColor = Color.DarkSlateBlue
                    //frmRet.btnViewReport.ForeColor = Color.White
                    //frmRet.btnRefresh.BackColor = Color.DarkSlateBlue
                    //frmRet.btnRefresh.ForeColor = Color.White
                    //frmRet.DataGridView1.BackgroundColor = Color.White

                    frmRet.ShowDialog();
                }

                this.Close();
            }
        }

        private void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Command2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            txtPwd.SelectionStart = 0;
            txtPwd.SelectionLength = txtPwd.Text.Length;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.SelectionStart = 0;
            txtUser.SelectionLength = txtUser.Text.Length;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Command1_Click(this, e);
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Command1_Click(this, e);
        }

        private void frmLogIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                Environment.Exit(0);
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            SplashScreen spl = new SplashScreen();
            spl.Close();
        }
    }
}
