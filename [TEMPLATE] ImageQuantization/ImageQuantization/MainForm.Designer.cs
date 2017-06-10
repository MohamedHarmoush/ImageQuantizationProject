namespace ImageQuantization
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.DistinctColors = new MetroFramework.Controls.MetroTextBox();
            this.txtWidth = new MetroFramework.Controls.MetroTextBox();
            this.txtHeight = new MetroFramework.Controls.MetroTextBox();
            this.Clusters = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(20, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 366);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(464, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 371);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(433, 361);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(177, 486);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(123, 34);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Open Image";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(20, 479);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Width";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(20, 504);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Height";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(768, 486);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(123, 34);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 21;
            this.metroButton2.Text = "Quantize Image";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(442, 504);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(140, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Number Of Clusters";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(150, 62);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Original Image";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.CustomForeColor = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(607, 62);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(123, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Quantized Image";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(442, 475);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(184, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Number Of Distinct Colors";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // DistinctColors
            // 
            this.DistinctColors.CustomBackground = false;
            this.DistinctColors.CustomForeColor = false;
            this.DistinctColors.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.DistinctColors.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.DistinctColors.Location = new System.Drawing.Point(655, 471);
            this.DistinctColors.Multiline = false;
            this.DistinctColors.Name = "DistinctColors";
            this.DistinctColors.SelectedText = "";
            this.DistinctColors.Size = new System.Drawing.Size(75, 23);
            this.DistinctColors.Style = MetroFramework.MetroColorStyle.Blue;
            this.DistinctColors.StyleManager = null;
            this.DistinctColors.TabIndex = 26;
            this.DistinctColors.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DistinctColors.UseStyleColors = false;
            // 
            // txtWidth
            // 
            this.txtWidth.CustomBackground = false;
            this.txtWidth.CustomForeColor = false;
            this.txtWidth.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtWidth.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtWidth.Location = new System.Drawing.Point(80, 475);
            this.txtWidth.Multiline = false;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.SelectedText = "";
            this.txtWidth.Size = new System.Drawing.Size(75, 23);
            this.txtWidth.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWidth.StyleManager = null;
            this.txtWidth.TabIndex = 27;
            this.txtWidth.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWidth.UseStyleColors = false;
            // 
            // txtHeight
            // 
            this.txtHeight.CustomBackground = false;
            this.txtHeight.CustomForeColor = false;
            this.txtHeight.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtHeight.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtHeight.Location = new System.Drawing.Point(80, 504);
            this.txtHeight.Multiline = false;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.SelectedText = "";
            this.txtHeight.Size = new System.Drawing.Size(75, 23);
            this.txtHeight.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHeight.StyleManager = null;
            this.txtHeight.TabIndex = 28;
            this.txtHeight.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHeight.UseStyleColors = false;
            // 
            // Clusters
            // 
            this.Clusters.CustomBackground = false;
            this.Clusters.CustomForeColor = false;
            this.Clusters.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.Clusters.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.Clusters.Location = new System.Drawing.Point(655, 500);
            this.Clusters.Multiline = false;
            this.Clusters.Name = "Clusters";
            this.Clusters.SelectedText = "";
            this.Clusters.Size = new System.Drawing.Size(75, 23);
            this.Clusters.Style = MetroFramework.MetroColorStyle.Blue;
            this.Clusters.StyleManager = null;
            this.Clusters.TabIndex = 29;
            this.Clusters.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Clusters.UseStyleColors = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(914, 543);
            this.Controls.Add(this.Clusters);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.DistinctColors);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainForm";
            this.Text = "Image Quantization...";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox DistinctColors;
        private MetroFramework.Controls.MetroTextBox txtWidth;
        private MetroFramework.Controls.MetroTextBox txtHeight;
        private MetroFramework.Controls.MetroTextBox Clusters;
    }
}

