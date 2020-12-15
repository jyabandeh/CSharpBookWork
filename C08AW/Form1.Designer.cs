namespace C08AW
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.slideShowImageList = new System.Windows.Forms.ImageList(this.components);
            this.slideShowPictureBox = new System.Windows.Forms.PictureBox();
            this.btnReverseString = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slideShowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // slideShowImageList
            // 
            this.slideShowImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.slideShowImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.slideShowImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // slideShowPictureBox
            // 
            this.slideShowPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slideShowPictureBox.Location = new System.Drawing.Point(12, 12);
            this.slideShowPictureBox.Name = "slideShowPictureBox";
            this.slideShowPictureBox.Size = new System.Drawing.Size(100, 50);
            this.slideShowPictureBox.TabIndex = 0;
            this.slideShowPictureBox.TabStop = false;
            this.slideShowPictureBox.Click += new System.EventHandler(this.slideShowPictureBox_Click);
            // 
            // btnReverseString
            // 
            this.btnReverseString.Location = new System.Drawing.Point(298, 114);
            this.btnReverseString.Name = "btnReverseString";
            this.btnReverseString.Size = new System.Drawing.Size(160, 23);
            this.btnReverseString.TabIndex = 1;
            this.btnReverseString.Text = "Reverse String";
            this.btnReverseString.UseVisualStyleBackColor = true;
            this.btnReverseString.Click += new System.EventHandler(this.btnReverseString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReverseString);
            this.Controls.Add(this.slideShowPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.slideShowPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList slideShowImageList;
        private System.Windows.Forms.PictureBox slideShowPictureBox;
        private System.Windows.Forms.Button btnReverseString;
    }
}

