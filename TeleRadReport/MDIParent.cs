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
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            frmLogIn LgIn = new frmLogIn();
            LgIn.Show();
        }
    }
}
