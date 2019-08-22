namespace C02PP05_HeadsTails
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
            this.btnShowHeads = new System.Windows.Forms.Button();
            this.btnShowTails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeads
            // 
            this.picHeads.Image = global::C02PP05_HeadsTails.Properties.Resources.Heads1;
            this.picHeads.Location = new System.Drawing.Point(12, 12);
            this.picHeads.Name = "picHeads";
            this.picHeads.Size = new System.Drawing.Size(136, 124);
            this.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeads.TabIndex = 0;
            this.picHeads.TabStop = false;
            this.picHeads.Visible = false;
            // 
            // picTails
            // 
            this.picTails.Image = global::C02PP05_HeadsTails.Properties.Resources.Tails1;
            this.picTails.Location = new System.Drawing.Point(154, 12);
            this.picTails.Name = "picTails";
            this.picTails.Size = new System.Drawing.Size(136, 124);
            this.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTails.TabIndex = 1;
            this.picTails.TabStop = false;
            this.picTails.Visible = false;
            // 
            // btnShowHeads
            // 
            this.btnShowHeads.Location = new System.Drawing.Point(43, 153);
            this.btnShowHeads.Name = "btnShowHeads";
            this.btnShowHeads.Size = new System.Drawing.Size(86, 23);
            this.btnShowHeads.TabIndex = 2;
            this.btnShowHeads.Text = "Show Heads";
            this.btnShowHeads.UseVisualStyleBackColor = true;
            this.btnShowHeads.Click += new System.EventHandler(this.btnShowHeads_Click);
            // 
            // btnShowTails
            // 
            this.btnShowTails.Location = new System.Drawing.Point(180, 153);
            this.btnShowTails.Name = "btnShowTails";
            this.btnShowTails.Size = new System.Drawing.Size(86, 23);
            this.btnShowTails.TabIndex = 3;
            this.btnShowTails.Text = "Show Tails";
            this.btnShowTails.UseVisualStyleBackColor = true;
            this.btnShowTails.Click += new System.EventHandler(this.btnShowTails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 205);
            this.Controls.Add(this.btnShowTails);
            this.Controls.Add(this.btnShowHeads);
            this.Controls.Add(this.picTails);
            this.Controls.Add(this.picHeads);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeads;
        private System.Windows.Forms.PictureBox picTails;
        private System.Windows.Forms.Button btnShowHeads;
        private System.Windows.Forms.Button btnShowTails;
    }
}

