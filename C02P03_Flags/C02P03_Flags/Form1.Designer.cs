namespace C02P03_Flags
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.picGermany = new System.Windows.Forms.PictureBox();
            this.picFrance = new System.Windows.Forms.PictureBox();
            this.picFinland = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGermany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinland)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a flag to see the name of the country.";
            // 
            // lblCountry
            // 
            this.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(141, 165);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(206, 23);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGermany
            // 
            this.picGermany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGermany.Image = global::C02P03_Flags.Properties.Resources.Germany;
            this.picGermany.Location = new System.Drawing.Point(319, 76);
            this.picGermany.Name = "picGermany";
            this.picGermany.Size = new System.Drawing.Size(122, 72);
            this.picGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGermany.TabIndex = 3;
            this.picGermany.TabStop = false;
            this.picGermany.Click += new System.EventHandler(this.picGermany_Click);
            // 
            // picFrance
            // 
            this.picFrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFrance.Image = global::C02P03_Flags.Properties.Resources.France;
            this.picFrance.Location = new System.Drawing.Point(180, 76);
            this.picFrance.Name = "picFrance";
            this.picFrance.Size = new System.Drawing.Size(122, 72);
            this.picFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFrance.TabIndex = 2;
            this.picFrance.TabStop = false;
            this.picFrance.Click += new System.EventHandler(this.picFrance_Click);
            // 
            // picFinland
            // 
            this.picFinland.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFinland.Image = global::C02P03_Flags.Properties.Resources.Finland;
            this.picFinland.Location = new System.Drawing.Point(40, 76);
            this.picFinland.Name = "picFinland";
            this.picFinland.Size = new System.Drawing.Size(122, 72);
            this.picFinland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFinland.TabIndex = 1;
            this.picFinland.TabStop = false;
            this.picFinland.Click += new System.EventHandler(this.picFinland_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 239);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.picGermany);
            this.Controls.Add(this.picFrance);
            this.Controls.Add(this.picFinland);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.picGermany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinland)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFinland;
        private System.Windows.Forms.PictureBox picFrance;
        private System.Windows.Forms.PictureBox picGermany;
        private System.Windows.Forms.Label lblCountry;
    }
}

