using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TeleRadReport
{
	/// <summary>
	/// Summary description for LabelFormType.
	/// </summary>
	public class LabelFormType : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.GroupBox LabelTypeGroup;
		internal System.Windows.Forms.RadioButton LabelType_Polygon;
		internal System.Windows.Forms.RadioButton LabelType_Ellipse;
		internal System.Windows.Forms.RadioButton LabelType_Rectangle;
		internal System.Windows.Forms.RadioButton LabelType_Arrow;
		internal System.Windows.Forms.RadioButton LabelType_PolyLine;
		internal System.Windows.Forms.RadioButton LabelType_Line;
		internal System.Windows.Forms.RadioButton LabelType_Text;
		internal System.Windows.Forms.GroupBox Tied;
		internal System.Windows.Forms.RadioButton Control;
		internal System.Windows.Forms.RadioButton ImageCell;
		internal System.Windows.Forms.RadioButton ImageScale;
		internal System.Windows.Forms.Button OK;
		internal System.Windows.Forms.TextBox FontDisplay;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.PictureBox BackColour;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.PictureBox ForeColour;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox LineWidth;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.CheckBox Transparent;
		private System.Windows.Forms.ColorDialog colorDialog1;
		internal System.Windows.Forms.FontDialog fontDialog1;
		internal DicomObjects.Enums.LabelType labelType;
        public DicomObjects.Enums.ScaleMode ScaleMode;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		public LabelFormType()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.LabelTypeGroup = new System.Windows.Forms.GroupBox();
            this.LabelType_Polygon = new System.Windows.Forms.RadioButton();
            this.LabelType_Ellipse = new System.Windows.Forms.RadioButton();
            this.LabelType_Rectangle = new System.Windows.Forms.RadioButton();
            this.LabelType_Arrow = new System.Windows.Forms.RadioButton();
            this.LabelType_PolyLine = new System.Windows.Forms.RadioButton();
            this.LabelType_Line = new System.Windows.Forms.RadioButton();
            this.LabelType_Text = new System.Windows.Forms.RadioButton();
            this.Tied = new System.Windows.Forms.GroupBox();
            this.Control = new System.Windows.Forms.RadioButton();
            this.ImageCell = new System.Windows.Forms.RadioButton();
            this.ImageScale = new System.Windows.Forms.RadioButton();
            this.OK = new System.Windows.Forms.Button();
            this.FontDisplay = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.BackColour = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ForeColour = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.LineWidth = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Transparent = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.LabelTypeGroup.SuspendLayout();
            this.Tied.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeColour)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTypeGroup
            // 
            this.LabelTypeGroup.Controls.Add(this.LabelType_Polygon);
            this.LabelTypeGroup.Controls.Add(this.LabelType_Ellipse);
            this.LabelTypeGroup.Controls.Add(this.LabelType_Rectangle);
            this.LabelTypeGroup.Controls.Add(this.LabelType_Arrow);
            this.LabelTypeGroup.Controls.Add(this.LabelType_PolyLine);
            this.LabelTypeGroup.Controls.Add(this.LabelType_Line);
            this.LabelTypeGroup.Controls.Add(this.LabelType_Text);
            this.LabelTypeGroup.Location = new System.Drawing.Point(16, 16);
            this.LabelTypeGroup.Name = "LabelTypeGroup";
            this.LabelTypeGroup.Size = new System.Drawing.Size(200, 152);
            this.LabelTypeGroup.TabIndex = 1;
            this.LabelTypeGroup.TabStop = false;
            this.LabelTypeGroup.Text = "Label Type";
            // 
            // LabelType_Polygon
            // 
            this.LabelType_Polygon.Location = new System.Drawing.Point(104, 88);
            this.LabelType_Polygon.Name = "LabelType_Polygon";
            this.LabelType_Polygon.Size = new System.Drawing.Size(64, 16);
            this.LabelType_Polygon.TabIndex = 6;
            this.LabelType_Polygon.Tag = "5";
            this.LabelType_Polygon.Text = "Polygon";
            this.LabelType_Polygon.CheckedChanged += new System.EventHandler(this.LabelType_Polygon_CheckedChanged);
            // 
            // LabelType_Ellipse
            // 
            this.LabelType_Ellipse.Location = new System.Drawing.Point(104, 56);
            this.LabelType_Ellipse.Name = "LabelType_Ellipse";
            this.LabelType_Ellipse.Size = new System.Drawing.Size(56, 16);
            this.LabelType_Ellipse.TabIndex = 5;
            this.LabelType_Ellipse.Tag = "1";
            this.LabelType_Ellipse.Text = "Ellipse";
            this.LabelType_Ellipse.CheckedChanged += new System.EventHandler(this.LabelType_Ellipse_CheckedChanged);
            // 
            // LabelType_Rectangle
            // 
            this.LabelType_Rectangle.Location = new System.Drawing.Point(104, 24);
            this.LabelType_Rectangle.Name = "LabelType_Rectangle";
            this.LabelType_Rectangle.Size = new System.Drawing.Size(80, 24);
            this.LabelType_Rectangle.TabIndex = 4;
            this.LabelType_Rectangle.Tag = "2";
            this.LabelType_Rectangle.Text = "Rectangle";
            this.LabelType_Rectangle.CheckedChanged += new System.EventHandler(this.LabelType_Rectangle_CheckedChanged);
            // 
            // LabelType_Arrow
            // 
            this.LabelType_Arrow.Location = new System.Drawing.Point(24, 120);
            this.LabelType_Arrow.Name = "LabelType_Arrow";
            this.LabelType_Arrow.Size = new System.Drawing.Size(56, 24);
            this.LabelType_Arrow.TabIndex = 3;
            this.LabelType_Arrow.Tag = "10";
            this.LabelType_Arrow.Text = "Arrow";
            this.LabelType_Arrow.CheckedChanged += new System.EventHandler(this.LabelType_Arrow_CheckedChanged);
            // 
            // LabelType_PolyLine
            // 
            this.LabelType_PolyLine.Location = new System.Drawing.Point(24, 88);
            this.LabelType_PolyLine.Name = "LabelType_PolyLine";
            this.LabelType_PolyLine.Size = new System.Drawing.Size(72, 24);
            this.LabelType_PolyLine.TabIndex = 2;
            this.LabelType_PolyLine.Tag = "4";
            this.LabelType_PolyLine.Text = "PolyLine";
            this.LabelType_PolyLine.CheckedChanged += new System.EventHandler(this.LabelType_PolyLine_CheckedChanged);
            // 
            // LabelType_Line
            // 
            this.LabelType_Line.Location = new System.Drawing.Point(24, 56);
            this.LabelType_Line.Name = "LabelType_Line";
            this.LabelType_Line.Size = new System.Drawing.Size(48, 24);
            this.LabelType_Line.TabIndex = 1;
            this.LabelType_Line.Tag = "3";
            this.LabelType_Line.Text = "Line";
            this.LabelType_Line.CheckedChanged += new System.EventHandler(this.LabelType_Line_CheckedChanged);
            // 
            // LabelType_Text
            // 
            this.LabelType_Text.Checked = true;
            this.LabelType_Text.Location = new System.Drawing.Point(24, 24);
            this.LabelType_Text.Name = "LabelType_Text";
            this.LabelType_Text.Size = new System.Drawing.Size(48, 24);
            this.LabelType_Text.TabIndex = 0;
            this.LabelType_Text.TabStop = true;
            this.LabelType_Text.Tag = "0";
            this.LabelType_Text.Text = "Text";
            this.LabelType_Text.CheckedChanged += new System.EventHandler(this.LabelType_Text_CheckedChanged);
            // 
            // Tied
            // 
            this.Tied.Controls.Add(this.Control);
            this.Tied.Controls.Add(this.ImageCell);
            this.Tied.Controls.Add(this.ImageScale);
            this.Tied.Location = new System.Drawing.Point(232, 24);
            this.Tied.Name = "Tied";
            this.Tied.Size = new System.Drawing.Size(120, 112);
            this.Tied.TabIndex = 12;
            this.Tied.TabStop = false;
            this.Tied.Text = "Tied To";
            // 
            // Control
            // 
            this.Control.Location = new System.Drawing.Point(24, 80);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(64, 16);
            this.Control.TabIndex = 2;
            this.Control.Text = "Control";
            this.Control.CheckedChanged += new System.EventHandler(this.Control_CheckedChanged);
            // 
            // ImageCell
            // 
            this.ImageCell.Location = new System.Drawing.Point(24, 48);
            this.ImageCell.Name = "ImageCell";
            this.ImageCell.Size = new System.Drawing.Size(80, 16);
            this.ImageCell.TabIndex = 1;
            this.ImageCell.Text = "Image Cell";
            this.ImageCell.CheckedChanged += new System.EventHandler(this.ImageCell_CheckedChanged);
            // 
            // ImageScale
            // 
            this.ImageScale.Checked = true;
            this.ImageScale.Location = new System.Drawing.Point(24, 16);
            this.ImageScale.Name = "ImageScale";
            this.ImageScale.Size = new System.Drawing.Size(56, 24);
            this.ImageScale.TabIndex = 0;
            this.ImageScale.TabStop = true;
            this.ImageScale.Text = "Image";
            this.ImageScale.CheckedChanged += new System.EventHandler(this.ImageScale_CheckedChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(232, 232);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(120, 40);
            this.OK.TabIndex = 22;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // FontDisplay
            // 
            this.FontDisplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontDisplay.Location = new System.Drawing.Point(16, 240);
            this.FontDisplay.Multiline = true;
            this.FontDisplay.Name = "FontDisplay";
            this.FontDisplay.Size = new System.Drawing.Size(200, 26);
            this.FontDisplay.TabIndex = 21;
            this.FontDisplay.Text = "Arial";
            this.FontDisplay.DoubleClick += new System.EventHandler(this.FontDisplay_DoubleClick);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 224);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(208, 16);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Double-Click in the box below to change the font";
            // 
            // BackColour
            // 
            this.BackColour.BackColor = System.Drawing.Color.Black;
            this.BackColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackColour.Location = new System.Drawing.Point(328, 195);
            this.BackColour.Name = "BackColour";
            this.BackColour.Size = new System.Drawing.Size(24, 24);
            this.BackColour.TabIndex = 19;
            this.BackColour.TabStop = false;
            this.BackColour.Click += new System.EventHandler(this.BackColour_Click);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(240, 200);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 16);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Back Colour";
            // 
            // ForeColour
            // 
            this.ForeColour.BackColor = System.Drawing.Color.Red;
            this.ForeColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForeColour.Location = new System.Drawing.Point(328, 163);
            this.ForeColour.Name = "ForeColour";
            this.ForeColour.Size = new System.Drawing.Size(24, 24);
            this.ForeColour.TabIndex = 17;
            this.ForeColour.TabStop = false;
            this.ForeColour.Click += new System.EventHandler(this.ForeColour_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(240, 168);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Fore Colour";
            // 
            // LineWidth
            // 
            this.LineWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LineWidth.Location = new System.Drawing.Point(200, 192);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(24, 20);
            this.LineWidth.TabIndex = 15;
            this.LineWidth.Text = "1";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(128, 192);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Line Width";
            // 
            // Transparent
            // 
            this.Transparent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Transparent.Checked = true;
            this.Transparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Transparent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transparent.Location = new System.Drawing.Point(16, 192);
            this.Transparent.Name = "Transparent";
            this.Transparent.Size = new System.Drawing.Size(88, 16);
            this.Transparent.TabIndex = 13;
            this.Transparent.Text = "Transparent";
            // 
            // LabelFormType
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(368, 286);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.FontDisplay);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.BackColour);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ForeColour);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LineWidth);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Transparent);
            this.Controls.Add(this.Tied);
            this.Controls.Add(this.LabelTypeGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LabelFormType";
            this.Text = "LabelFormType";
            this.Load += new System.EventHandler(this.LabelFormType_Load);
            this.LabelTypeGroup.ResumeLayout(false);
            this.Tied.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForeColour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void ForeColour_Click(object sender, System.EventArgs e)
		{
			colorDialog1.Color = ForeColour.BackColor;
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				ForeColour.BackColor = colorDialog1.Color;
			}
		}

		private void BackColour_Click(object sender, System.EventArgs e)
		{
			colorDialog1.Color = BackColour.BackColor;
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				BackColour.BackColor = colorDialog1.Color;
			}
		}

		private void FontDisplay_DoubleClick(object sender, System.EventArgs e)
		{
			fontDialog1.Font = FontDisplay.Font;
			if(fontDialog1.ShowDialog() == DialogResult.OK)
			{
				FontDisplay.Text = fontDialog1.Font.Name; 
				FontDisplay.Font = fontDialog1.Font;
			}
		}

		private void LabelFormType_Load(object sender, System.EventArgs e)
		{
			labelType = DicomObjects.Enums.LabelType.Text;
			LabelType_Text.Checked = true;
            ScaleMode = DicomObjects.Enums.ScaleMode.Image;
		}

		private void OK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void LabelType_Text_CheckedChanged(object sender, System.EventArgs e)
		{
			if(LabelType_Text.Checked)
				labelType = DicomObjects.Enums.LabelType.Text;
		}

		private void LabelType_Line_CheckedChanged(object sender, System.EventArgs e)
		{
			if(LabelType_Line.Checked)
				labelType = DicomObjects.Enums.LabelType.Line;
		}

		private void LabelType_PolyLine_CheckedChanged(object sender, System.EventArgs e)
		{
			if(LabelType_PolyLine.Checked)
				labelType = DicomObjects.Enums.LabelType.PolyLine;
		}

		private void LabelType_Arrow_CheckedChanged(object sender, System.EventArgs e)
		{
			if(LabelType_Arrow.Checked)
				labelType = DicomObjects.Enums.LabelType.Arrow;
		}

		private void LabelType_Rectangle_CheckedChanged(object sender, System.EventArgs e)
		{
			if(LabelType_Rectangle.Checked)
				labelType = DicomObjects.Enums.LabelType.Rectangle;
		}

		private void LabelType_Ellipse_CheckedChanged(object sender, System.EventArgs e)
		{
			if(LabelType_Ellipse.Checked)
				labelType = DicomObjects.Enums.LabelType.Ellipse;
		}

		private void LabelType_Polygon_CheckedChanged(object sender, System.EventArgs e)
		{
			if(LabelType_Polygon.Checked)
				labelType = DicomObjects.Enums.LabelType.Polygon;
		}

		private void ImageScale_CheckedChanged(object sender, System.EventArgs e)
		{
            if(ImageScale.Checked)
                ScaleMode = DicomObjects.Enums.ScaleMode.Image;
		}

        private void ImageCell_CheckedChanged(object sender, EventArgs e)
        {
            if (ImageCell.Checked)
                ScaleMode = DicomObjects.Enums.ScaleMode.Cell;
        }

        private void Control_CheckedChanged(object sender, EventArgs e)
        {
            if (Control.Checked)
                ScaleMode = DicomObjects.Enums.ScaleMode.Output; 
        }

	}
}
