namespace C05P01_CoinToss
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
            this.picHeads = new System.Windows.Forms.PictureBox();
            this.picTails = new System.Windows.Forms.PictureBox();
            this.btnToss = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeads
            // 
            this.picHeads.Image = global::C05P01_CoinToss.Properties.Resources.Heads1;
            this.picHeads.Location = new System.Drawing.Point(50, 36);
            this.picHeads.Name = "picHeads";
            this.picHeads.Size = new System.Drawing.Size(170, 170);
            this.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeads.TabIndex = 0;
            this.picHeads.TabStop = false;
            // 
            // picTails
            // 
            this.picTails.Image = global::C05P01_CoinToss.Properties.Resources.Tails1;
            this.picTails.Location = new System.Drawing.Point(50, 36);
            this.picTails.Name = "picTails";
            this.picTails.Size = new System.Drawing.Size(170, 170);
            this.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTails.TabIndex = 1;
            this.picTails.TabStop = false;
            this.picTails.Visible = false;
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(53, 221);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 23);
            this.btnToss.TabIndex = 2;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(134, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 265);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToss);
            this.Controls.Add(this.picTails);
            this.Controls.Add(this.picHeads);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeads;
        private System.Windows.Forms.PictureBox picTails;
        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Button btnExit;
    }
}

