namespace C02PP01_LatinTranslator
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
            this.lblTranslation = new System.Windows.Forms.Label();
            this.btnSinister = new System.Windows.Forms.Button();
            this.btnDexter = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a Latin word to see its English translation!";
            // 
            // lblTranslation
            // 
            this.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslation.Location = new System.Drawing.Point(39, 66);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(224, 23);
            this.lblTranslation.TabIndex = 1;
            this.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSinister
            // 
            this.btnSinister.Location = new System.Drawing.Point(32, 119);
            this.btnSinister.Name = "btnSinister";
            this.btnSinister.Size = new System.Drawing.Size(75, 23);
            this.btnSinister.TabIndex = 2;
            this.btnSinister.Text = "Sinister";
            this.btnSinister.UseVisualStyleBackColor = true;
            this.btnSinister.Click += new System.EventHandler(this.btnSinister_Click);
            // 
            // btnDexter
            // 
            this.btnDexter.Location = new System.Drawing.Point(113, 120);
            this.btnDexter.Name = "btnDexter";
            this.btnDexter.Size = new System.Drawing.Size(75, 23);
            this.btnDexter.TabIndex = 3;
            this.btnDexter.Text = "Dexter";
            this.btnDexter.UseVisualStyleBackColor = true;
            this.btnDexter.Click += new System.EventHandler(this.btnDexter_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(194, 119);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 4;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 193);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnDexter);
            this.Controls.Add(this.btnSinister);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Button btnSinister;
        private System.Windows.Forms.Button btnDexter;
        private System.Windows.Forms.Button btnMedium;
    }
}

