using System;
namespace TeleRadReport
{
    partial class SplashScreen
    {
        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if ((components != null))
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.ApplicationTitle = new System.Windows.Forms.Label();
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Version = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainLayoutPanel.SuspendLayout();
            this.DetailsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationTitle
            // 
            this.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplicationTitle.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationTitle.Location = new System.Drawing.Point(226, 2);
            this.ApplicationTitle.Name = "ApplicationTitle";
            this.ApplicationTitle.Size = new System.Drawing.Size(260, 212);
            this.ApplicationTitle.TabIndex = 0;
            this.ApplicationTitle.Text = "ApplicationTitle";
            this.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ApplicationTitle.Click += new System.EventHandler(this.ApplicationTitle_Click);
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.BackColor = System.Drawing.Color.DarkGray;
            this.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 1);
            this.MainLayoutPanel.Controls.Add(this.ApplicationTitle, 1, 0);
            this.MainLayoutPanel.Controls.Add(this.PictureBox1, 0, 0);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(496, 303);
            this.MainLayoutPanel.TabIndex = 2;
            // 
            // DetailsLayoutPanel
            // 
            this.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.DetailsLayoutPanel.ColumnCount = 1;
            this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.DetailsLayoutPanel.Controls.Add(this.Version, 0, 0);
            this.DetailsLayoutPanel.Controls.Add(this.Copyright, 0, 1);
            this.DetailsLayoutPanel.Location = new System.Drawing.Point(224, 220);
            this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
            this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.DetailsLayoutPanel.Size = new System.Drawing.Size(264, 79);
            this.DetailsLayoutPanel.TabIndex = 1;
            // 
            // Version
            // 
            this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(3, 9);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(258, 20);
            this.Version.TabIndex = 1;
            this.Version.Text = "Version {0}.{1:00}";
            this.Version.Click += new System.EventHandler(this.Version_Click);
            // 
            // Copyright
            // 
            this.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.Location = new System.Drawing.Point(5, 39);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(253, 40);
            this.Copyright.TabIndex = 2;
            this.Copyright.Text = "Copyright";
            this.Copyright.Click += new System.EventHandler(this.Copyright_Click);
            this.Copyright.Paint += new System.Windows.Forms.PaintEventHandler(this.Copyright_Paint);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PictureBox1.Size = new System.Drawing.Size(210, 210);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 19;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 303);
            this.ControlBox = false;
            this.Controls.Add(this.MainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.Click += new System.EventHandler(this.SplashScreen_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SplashScreen_Paint);
            this.DoubleClick += new System.EventHandler(this.SplashScreen_DoubleClick);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SplashScreen_KeyPress);
            this.MainLayoutPanel.ResumeLayout(false);
            this.DetailsLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.Label ApplicationTitle;
        internal System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        internal System.Windows.Forms.TableLayoutPanel DetailsLayoutPanel;
        internal System.Windows.Forms.Label Version;
        internal System.Windows.Forms.Label Copyright;
        public System.Windows.Forms.PictureBox PictureBox1;
    }
}