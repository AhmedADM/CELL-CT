namespace CELL_CT_Exercise
{
    partial class CELL_CT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CELL_CT));
            this.CellCTpictureBox = new System.Windows.Forms.PictureBox();
            this.enableSharpening = new System.Windows.Forms.CheckBox();
            this.openButton = new System.Windows.Forms.Button();
            this.ImageSlide = new System.Windows.Forms.TrackBar();
            this.FirstPic = new System.Windows.Forms.Label();
            this.LastPic = new System.Windows.Forms.Label();
            this.SharpenButton = new System.Windows.Forms.Button();
            this.ImageName = new System.Windows.Forms.Label();
            this.ResetImage = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ImageSize = new System.Windows.Forms.GroupBox();
            this.Zoom = new System.Windows.Forms.RadioButton();
            this.CentralImage = new System.Windows.Forms.RadioButton();
            this.AutoSize = new System.Windows.Forms.RadioButton();
            this.StretchImage = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CellCTpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSlide)).BeginInit();
            this.ImageSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // CellCTpictureBox
            // 
            this.CellCTpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CellCTpictureBox.Location = new System.Drawing.Point(12, 12);
            this.CellCTpictureBox.Name = "CellCTpictureBox";
            this.CellCTpictureBox.Size = new System.Drawing.Size(480, 305);
            this.CellCTpictureBox.TabIndex = 0;
            this.CellCTpictureBox.TabStop = false;
            // 
            // enableSharpening
            // 
            this.enableSharpening.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enableSharpening.AutoSize = true;
            this.enableSharpening.Enabled = false;
            this.enableSharpening.Location = new System.Drawing.Point(546, 12);
            this.enableSharpening.Name = "enableSharpening";
            this.enableSharpening.Size = new System.Drawing.Size(117, 17);
            this.enableSharpening.TabIndex = 1;
            this.enableSharpening.Text = "Enable sharpening ";
            this.enableSharpening.UseVisualStyleBackColor = true;
            this.enableSharpening.CheckedChanged += new System.EventHandler(this.enableSharpening_Changed);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(546, 282);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(147, 35);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Open Folder";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // ImageSlide
            // 
            this.ImageSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSlide.Enabled = false;
            this.ImageSlide.LargeChange = 1;
            this.ImageSlide.Location = new System.Drawing.Point(510, 231);
            this.ImageSlide.Maximum = 0;
            this.ImageSlide.Name = "ImageSlide";
            this.ImageSlide.Size = new System.Drawing.Size(208, 45);
            this.ImageSlide.TabIndex = 7;
            this.ImageSlide.Scroll += new System.EventHandler(this.ImageSlide_Scroll);
            // 
            // FirstPic
            // 
            this.FirstPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstPic.AutoSize = true;
            this.FirstPic.Location = new System.Drawing.Point(513, 266);
            this.FirstPic.Name = "FirstPic";
            this.FirstPic.Size = new System.Drawing.Size(13, 13);
            this.FirstPic.TabIndex = 8;
            this.FirstPic.Text = "0";
            // 
            // LastPic
            // 
            this.LastPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LastPic.AutoSize = true;
            this.LastPic.Location = new System.Drawing.Point(705, 266);
            this.LastPic.Name = "LastPic";
            this.LastPic.Size = new System.Drawing.Size(13, 13);
            this.LastPic.TabIndex = 9;
            this.LastPic.Text = "0";
            // 
            // SharpenButton
            // 
            this.SharpenButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SharpenButton.Enabled = false;
            this.SharpenButton.Location = new System.Drawing.Point(618, 35);
            this.SharpenButton.Name = "SharpenButton";
            this.SharpenButton.Size = new System.Drawing.Size(75, 23);
            this.SharpenButton.TabIndex = 10;
            this.SharpenButton.Text = "Sharpen";
            this.SharpenButton.UseVisualStyleBackColor = true;
            this.SharpenButton.Click += new System.EventHandler(this.SharpenButton_Click);
            // 
            // ImageName
            // 
            this.ImageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageName.AutoSize = true;
            this.ImageName.Location = new System.Drawing.Point(575, 215);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(58, 13);
            this.ImageName.TabIndex = 12;
            this.ImageName.Text = "No Images";
            this.ImageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetImage
            // 
            this.ResetImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetImage.Enabled = false;
            this.ResetImage.Location = new System.Drawing.Point(516, 35);
            this.ResetImage.Name = "ResetImage";
            this.ResetImage.Size = new System.Drawing.Size(75, 23);
            this.ResetImage.TabIndex = 13;
            this.ResetImage.Text = "Reset Image";
            this.ResetImage.UseVisualStyleBackColor = true;
            this.ResetImage.Click += new System.EventHandler(this.ResetImage_Click);
            // 
            // ImageSize
            // 
            this.ImageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSize.Controls.Add(this.Zoom);
            this.ImageSize.Controls.Add(this.CentralImage);
            this.ImageSize.Controls.Add(this.AutoSize);
            this.ImageSize.Controls.Add(this.StretchImage);
            this.ImageSize.Controls.Add(this.Normal);
            this.ImageSize.Location = new System.Drawing.Point(510, 75);
            this.ImageSize.Name = "ImageSize";
            this.ImageSize.Size = new System.Drawing.Size(200, 137);
            this.ImageSize.TabIndex = 14;
            this.ImageSize.TabStop = false;
            this.ImageSize.Text = "Image Size";
            // 
            // Zoom
            // 
            this.Zoom.AutoSize = true;
            this.Zoom.Location = new System.Drawing.Point(108, 111);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(52, 17);
            this.Zoom.TabIndex = 4;
            this.Zoom.Text = "Zoom";
            this.Zoom.UseVisualStyleBackColor = true;
            this.Zoom.Click += new System.EventHandler(this.ImageSizeOption_Checked);
            // 
            // CentralImage
            // 
            this.CentralImage.AutoSize = true;
            this.CentralImage.Location = new System.Drawing.Point(108, 88);
            this.CentralImage.Name = "CentralImage";
            this.CentralImage.Size = new System.Drawing.Size(90, 17);
            this.CentralImage.TabIndex = 3;
            this.CentralImage.Text = "Central Image";
            this.CentralImage.UseVisualStyleBackColor = true;
            this.CentralImage.Click += new System.EventHandler(this.ImageSizeOption_Checked);
            // 
            // AutoSize
            // 
            this.AutoSize.AutoSize = true;
            this.AutoSize.Location = new System.Drawing.Point(108, 65);
            this.AutoSize.Name = "AutoSize";
            this.AutoSize.Size = new System.Drawing.Size(70, 17);
            this.AutoSize.TabIndex = 2;
            this.AutoSize.Text = "Auto Size";
            this.AutoSize.UseVisualStyleBackColor = true;
            this.AutoSize.Click += new System.EventHandler(this.ImageSizeOption_Checked);
            // 
            // StretchImage
            // 
            this.StretchImage.AutoSize = true;
            this.StretchImage.Location = new System.Drawing.Point(108, 42);
            this.StretchImage.Name = "StretchImage";
            this.StretchImage.Size = new System.Drawing.Size(91, 17);
            this.StretchImage.TabIndex = 1;
            this.StretchImage.Text = "Stretch Image";
            this.StretchImage.UseVisualStyleBackColor = true;
            this.StretchImage.Click += new System.EventHandler(this.ImageSizeOption_Checked);
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Checked = true;
            this.Normal.Location = new System.Drawing.Point(108, 19);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(58, 17);
            this.Normal.TabIndex = 0;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.ImageSizeOption_Checked);
            // 
            // CELL_CT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 329);
            this.Controls.Add(this.ImageSize);
            this.Controls.Add(this.ResetImage);
            this.Controls.Add(this.ImageName);
            this.Controls.Add(this.SharpenButton);
            this.Controls.Add(this.LastPic);
            this.Controls.Add(this.FirstPic);
            this.Controls.Add(this.ImageSlide);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.enableSharpening);
            this.Controls.Add(this.CellCTpictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CELL_CT";
            this.Text = "Visiongate";
            ((System.ComponentModel.ISupportInitialize)(this.CellCTpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSlide)).EndInit();
            this.ImageSize.ResumeLayout(false);
            this.ImageSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CellCTpictureBox;
        private System.Windows.Forms.CheckBox enableSharpening;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TrackBar ImageSlide;
        private System.Windows.Forms.Label FirstPic;
        private System.Windows.Forms.Label LastPic;
        private System.Windows.Forms.Button SharpenButton;
        private System.Windows.Forms.Label ImageName;
        private System.Windows.Forms.Button ResetImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox ImageSize;
        private System.Windows.Forms.RadioButton AutoSize;
        private System.Windows.Forms.RadioButton StretchImage;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Zoom;
        private System.Windows.Forms.RadioButton CentralImage;
    }
}

