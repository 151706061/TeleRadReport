namespace TeleRadReport
{
    partial class AttributeFormType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttributeFormType));
            this.AttributeList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AttributeList
            // 
            this.AttributeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttributeList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributeList.HideSelection = false;
            this.AttributeList.Location = new System.Drawing.Point(4, 7);
            this.AttributeList.Multiline = true;
            this.AttributeList.Name = "AttributeList";
            this.AttributeList.ReadOnly = true;
            this.AttributeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AttributeList.Size = new System.Drawing.Size(504, 336);
            this.AttributeList.TabIndex = 1;
            this.AttributeList.TabStop = false;
            // 
            // AttributeFormType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(512, 350);
            this.Controls.Add(this.AttributeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AttributeFormType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox AttributeList;
    }
}