namespace C03P05_SalePriceCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.pic05cents = new System.Windows.Forms.PictureBox();
            this.pic10cents = new System.Windows.Forms.PictureBox();
            this.pic25cents = new System.Windows.Forms.PictureBox();
            this.pic50cents = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic05cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic25cents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic50cents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click the Coins";
            // 
            // pic05cents
            // 
            this.pic05cents.Image = global::C03P05_SalePriceCalculator.Properties.Resources._5cents;
            this.pic05cents.Location = new System.Drawing.Point(12, 43);
            this.pic05cents.Name = "pic05cents";
            this.pic05cents.Size = new System.Drawing.Size(125, 181);
            this.pic05cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic05cents.TabIndex = 1;
            this.pic05cents.TabStop = false;
            this.pic05cents.Click += new System.EventHandler(this.pic05cents_Click);
            // 
            // pic10cents
            // 
            this.pic10cents.Image = global::C03P05_SalePriceCalculator.Properties.Resources._10cents;
            this.pic10cents.Location = new System.Drawing.Point(143, 43);
            this.pic10cents.Name = "pic10cents";
            this.pic10cents.Size = new System.Drawing.Size(125, 181);
            this.pic10cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic10cents.TabIndex = 2;
            this.pic10cents.TabStop = false;
            this.pic10cents.Click += new System.EventHandler(this.pic10cents_Click);
            // 
            // pic25cents
            // 
            this.pic25cents.Image = global::C03P05_SalePriceCalculator.Properties.Resources._25cents;
            this.pic25cents.Location = new System.Drawing.Point(12, 230);
            this.pic25cents.Name = "pic25cents";
            this.pic25cents.Size = new System.Drawing.Size(125, 181);
            this.pic25cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic25cents.TabIndex = 3;
            this.pic25cents.TabStop = false;
            this.pic25cents.Click += new System.EventHandler(this.pic25cents_Click);
            // 
            // pic50cents
            // 
            this.pic50cents.Image = global::C03P05_SalePriceCalculator.Properties.Resources._50cents;
            this.pic50cents.Location = new System.Drawing.Point(143, 230);
            this.pic50cents.Name = "pic50cents";
            this.pic50cents.Size = new System.Drawing.Size(125, 181);
            this.pic50cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic50cents.TabIndex = 4;
            this.pic50cents.TabStop = false;
            this.pic50cents.Click += new System.EventHandler(this.pic50cents_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayTotal.Location = new System.Drawing.Point(286, 108);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(100, 23);
            this.lblDisplayTotal.TabIndex = 0;
            this.lblDisplayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 427);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic50cents);
            this.Controls.Add(this.pic25cents);
            this.Controls.Add(this.pic10cents);
            this.Controls.Add(this.pic05cents);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pic05cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic25cents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic50cents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic05cents;
        private System.Windows.Forms.PictureBox pic10cents;
        private System.Windows.Forms.PictureBox pic25cents;
        private System.Windows.Forms.PictureBox pic50cents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplayTotal;
    }
}

