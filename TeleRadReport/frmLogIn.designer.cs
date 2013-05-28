using System;
namespace TeleRadReport
{
    partial class frmLogIn
    {
        #region "Windows Form Designer generated code "
        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if ((components != null))
                {
                    components.Dispose();
                }
            }
            base.Dispose(Disposing);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Command2 = new System.Windows.Forms.Button();
            this.Command1 = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this._Label1_3 = new System.Windows.Forms.Label();
            this._Label1_2 = new System.Windows.Forms.Label();
            this._Label2_1 = new System.Windows.Forms.Label();
            this._Label2_0 = new System.Windows.Forms.Label();
            this._Label1_1 = new System.Windows.Forms.Label();
            this._Label1_0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Command2
            // 
            this.Command2.BackColor = System.Drawing.SystemColors.Control;
            this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Command2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command2.Location = new System.Drawing.Point(153, 109);
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command2.Size = new System.Drawing.Size(73, 25);
            this.Command2.TabIndex = 18;
            this.Command2.Text = "Exit";
            this.Command2.UseVisualStyleBackColor = false;
            this.Command2.Click += new System.EventHandler(this.Command2_Click);
            // 
            // Command1
            // 
            this.Command1.BackColor = System.Drawing.SystemColors.Control;
            this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command1.Location = new System.Drawing.Point(68, 109);
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command1.Size = new System.Drawing.Size(73, 25);
            this.Command1.TabIndex = 16;
            this.Command1.Text = "Log-In";
            this.Command1.UseVisualStyleBackColor = false;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.AcceptsReturn = true;
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPwd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPwd.Location = new System.Drawing.Point(93, 61);
            this.txtPwd.MaxLength = 0;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '?';
            this.txtPwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPwd.Size = new System.Drawing.Size(169, 22);
            this.txtPwd.TabIndex = 12;
            this.txtPwd.Enter += new System.EventHandler(this.txtPwd_Enter);
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = true;
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUser.Location = new System.Drawing.Point(93, 24);
            this.txtUser.MaxLength = 0;
            this.txtUser.Name = "txtUser";
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.Size = new System.Drawing.Size(169, 22);
            this.txtUser.TabIndex = 10;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // _Label1_3
            // 
            this._Label1_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._Label1_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_3.Location = new System.Drawing.Point(161, 117);
            this._Label1_3.Name = "_Label1_3";
            this._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_3.Size = new System.Drawing.Size(73, 25);
            this._Label1_3.TabIndex = 19;
            // 
            // _Label1_2
            // 
            this._Label1_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._Label1_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_2.Location = new System.Drawing.Point(76, 117);
            this._Label1_2.Name = "_Label1_2";
            this._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_2.Size = new System.Drawing.Size(73, 25);
            this._Label1_2.TabIndex = 17;
            // 
            // _Label2_1
            // 
            this._Label2_1.AutoSize = true;
            this._Label2_1.BackColor = System.Drawing.SystemColors.Control;
            this._Label2_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label2_1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label2_1.Location = new System.Drawing.Point(33, 69);
            this._Label2_1.Name = "_Label2_1";
            this._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label2_1.Size = new System.Drawing.Size(57, 14);
            this._Label2_1.TabIndex = 15;
            this._Label2_1.Text = "Password";
            // 
            // _Label2_0
            // 
            this._Label2_0.AutoSize = true;
            this._Label2_0.BackColor = System.Drawing.SystemColors.Control;
            this._Label2_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label2_0.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label2_0.Location = new System.Drawing.Point(33, 32);
            this._Label2_0.Name = "_Label2_0";
            this._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label2_0.Size = new System.Drawing.Size(56, 14);
            this._Label2_0.TabIndex = 14;
            this._Label2_0.Text = "Username";
            // 
            // _Label1_1
            // 
            this._Label1_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._Label1_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_1.Location = new System.Drawing.Point(101, 68);
            this._Label1_1.Name = "_Label1_1";
            this._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_1.Size = new System.Drawing.Size(169, 25);
            this._Label1_1.TabIndex = 13;
            // 
            // _Label1_0
            // 
            this._Label1_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._Label1_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_0.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label1_0.Location = new System.Drawing.Point(101, 31);
            this._Label1_0.Name = "_Label1_0";
            this._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_0.Size = new System.Drawing.Size(169, 25);
            this._Label1_0.TabIndex = 11;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(303, 166);
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this._Label1_3);
            this.Controls.Add(this._Label1_2);
            this.Controls.Add(this._Label2_1);
            this.Controls.Add(this._Label2_0);
            this.Controls.Add(this._Label1_1);
            this.Controls.Add(this._Label1_0);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeleRad - LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogIn_FormClosing);
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogIn_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button Command2;
        public System.Windows.Forms.Button Command1;
        public System.Windows.Forms.TextBox txtPwd;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.Label _Label1_3;
        public System.Windows.Forms.Label _Label1_2;
        public System.Windows.Forms.Label _Label2_1;
        public System.Windows.Forms.Label _Label2_0;
        public System.Windows.Forms.Label _Label1_1;
        public System.Windows.Forms.Label _Label1_0;
    }
}