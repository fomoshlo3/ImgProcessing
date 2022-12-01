namespace ImgProcessing.GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdLoadImage = new System.Windows.Forms.Button();
            this.PictBxLoadedImage = new System.Windows.Forms.PictureBox();
            this.LblImageInfo = new System.Windows.Forms.Label();
            this.CmdConvertToGrayscale = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictBxLoadedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdLoadImage
            // 
            this.CmdLoadImage.Location = new System.Drawing.Point(12, 12);
            this.CmdLoadImage.Name = "CmdLoadImage";
            this.CmdLoadImage.Size = new System.Drawing.Size(75, 23);
            this.CmdLoadImage.TabIndex = 0;
            this.CmdLoadImage.Text = "Laden";
            this.CmdLoadImage.UseVisualStyleBackColor = true;
            this.CmdLoadImage.Click += new System.EventHandler(this.CmdLoadImage_Click);
            // 
            // PictBxLoadedImage
            // 
            this.PictBxLoadedImage.Location = new System.Drawing.Point(134, 12);
            this.PictBxLoadedImage.Name = "PictBxLoadedImage";
            this.PictBxLoadedImage.Size = new System.Drawing.Size(654, 388);
            this.PictBxLoadedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictBxLoadedImage.TabIndex = 1;
            this.PictBxLoadedImage.TabStop = false;
            // 
            // LblImageInfo
            // 
            this.LblImageInfo.AutoSize = true;
            this.LblImageInfo.Location = new System.Drawing.Point(9, 364);
            this.LblImageInfo.Name = "LblImageInfo";
            this.LblImageInfo.Size = new System.Drawing.Size(67, 15);
            this.LblImageInfo.TabIndex = 2;
            this.LblImageInfo.Text = "Image Info:";
            // 
            // CmdConvertToGrayscale
            // 
            this.CmdConvertToGrayscale.Location = new System.Drawing.Point(12, 41);
            this.CmdConvertToGrayscale.Name = "CmdConvertToGrayscale";
            this.CmdConvertToGrayscale.Size = new System.Drawing.Size(111, 45);
            this.CmdConvertToGrayscale.TabIndex = 3;
            this.CmdConvertToGrayscale.Text = "Convert to Grayscale";
            this.CmdConvertToGrayscale.UseVisualStyleBackColor = true;
            this.CmdConvertToGrayscale.Click += new System.EventHandler(this.CmdConvertToGrayscale_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(713, 415);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(75, 23);
            this.CmdClose.TabIndex = 4;
            this.CmdClose.Text = "Beenden";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdConvertToGrayscale);
            this.Controls.Add(this.LblImageInfo);
            this.Controls.Add(this.PictBxLoadedImage);
            this.Controls.Add(this.CmdLoadImage);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictBxLoadedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdLoadImage;
        private PictureBox PictBxLoadedImage;
        private Label LblImageInfo;
        private Button CmdConvertToGrayscale;
        private Button CmdClose;
    }
}