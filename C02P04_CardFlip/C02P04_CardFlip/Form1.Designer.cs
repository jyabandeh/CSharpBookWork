namespace C02P04_CardFlip
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
            this.picCardBack = new System.Windows.Forms.PictureBox();
            this.btnShowBack = new System.Windows.Forms.Button();
            this.btnShowFace = new System.Windows.Forms.Button();
            this.picCardFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCardBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardFace)).BeginInit();
            this.SuspendLayout();
            // 
            // picCardBack
            // 
            this.picCardBack.Image = global::C02P04_CardFlip.Properties.Resources.Backface_Blue;
            this.picCardBack.Location = new System.Drawing.Point(51, 46);
            this.picCardBack.Name = "picCardBack";
            this.picCardBack.Size = new System.Drawing.Size(100, 140);
            this.picCardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCardBack.TabIndex = 0;
            this.picCardBack.TabStop = false;
            // 
            // btnShowBack
            // 
            this.btnShowBack.Location = new System.Drawing.Point(65, 213);
            this.btnShowBack.Name = "btnShowBack";
            this.btnShowBack.Size = new System.Drawing.Size(75, 41);
            this.btnShowBack.TabIndex = 2;
            this.btnShowBack.Text = "Show the Card Back";
            this.btnShowBack.UseVisualStyleBackColor = true;
            this.btnShowBack.Click += new System.EventHandler(this.btnShowBack_Click);
            // 
            // btnShowFace
            // 
            this.btnShowFace.Location = new System.Drawing.Point(181, 213);
            this.btnShowFace.Name = "btnShowFace";
            this.btnShowFace.Size = new System.Drawing.Size(75, 41);
            this.btnShowFace.TabIndex = 3;
            this.btnShowFace.Text = "Show the Card Face";
            this.btnShowFace.UseVisualStyleBackColor = true;
            this.btnShowFace.Click += new System.EventHandler(this.btnShowFace_Click);
            // 
            // picCardFace
            // 
            this.picCardFace.Image = global::C02P04_CardFlip.Properties.Resources.Ace_Spades;
            this.picCardFace.Location = new System.Drawing.Point(169, 46);
            this.picCardFace.Name = "picCardFace";
            this.picCardFace.Size = new System.Drawing.Size(100, 140);
            this.picCardFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCardFace.TabIndex = 4;
            this.picCardFace.TabStop = false;
            this.picCardFace.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 294);
            this.Controls.Add(this.picCardFace);
            this.Controls.Add(this.btnShowFace);
            this.Controls.Add(this.btnShowBack);
            this.Controls.Add(this.picCardBack);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCardBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCardBack;
        private System.Windows.Forms.Button btnShowBack;
        private System.Windows.Forms.Button btnShowFace;
        private System.Windows.Forms.PictureBox picCardFace;
    }
}

