using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeleRadReport
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //Application title
            if (!string.IsNullOrEmpty(this.ProductName))
            {
                ApplicationTitle.Text = this.ProductName;
            }

            Version.Text = "Version: " + Application.ProductVersion;

            //Copyright info
            Copyright.Text = "Copyright: " + Application.CompanyName;
        }

        private void SplashScreen_Click(object sender, EventArgs e)
        {
            frmLogIn mp = new frmLogIn();
            mp.Show();
            this.Hide();
        }

        private void SplashScreen_DoubleClick(object sender, EventArgs e)
        {
            frmLogIn mp = new frmLogIn();
            mp.Show();
            this.Hide();
        }

        private void SplashScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmLogIn mp = new frmLogIn();
            mp.Show();
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            frmLogIn mp = new frmLogIn();
            mp.Show();
            this.Hide();
        }

        private void ApplicationTitle_Click(object sender, EventArgs e)
        {
            frmLogIn mp = new frmLogIn();
            mp.Show();
            this.Hide();
        }

        private void Version_Click(object sender, EventArgs e)
        {
            frmLogIn mp = new frmLogIn();
            mp.Show();
            this.Hide();
        }

        private void Copyright_Click(object sender, EventArgs e)
        {
            frmLogIn mp = new frmLogIn();
            mp.Show();
            this.Hide();
        }

        private void Copyright_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplashScreen_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics gr = this.CreateGraphics();

            // Fill the ellipse.
            gr.FillEllipse(System.Drawing.Brushes.White, 0, 0, this.ClientSize.Width - 5, this.ClientSize.Height - 5);
        }
    }
}
