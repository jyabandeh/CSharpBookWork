namespace C08PP04_VowelsAndConsonants
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.btnCountVowelsConsonants = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(51, 45);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(194, 110);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // btnCountVowelsConsonants
            // 
            this.btnCountVowelsConsonants.Location = new System.Drawing.Point(51, 178);
            this.btnCountVowelsConsonants.Name = "btnCountVowelsConsonants";
            this.btnCountVowelsConsonants.Size = new System.Drawing.Size(194, 23);
            this.btnCountVowelsConsonants.TabIndex = 1;
            this.btnCountVowelsConsonants.Text = "Count Vowels and Consonants";
            this.btnCountVowelsConsonants.UseVisualStyleBackColor = true;
            this.btnCountVowelsConsonants.Click += new System.EventHandler(this.btnCountVowelsConsonants_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(51, 224);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(194, 47);
            this.lblDisplay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 310);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnCountVowelsConsonants);
            this.Controls.Add(this.rtbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnCountVowelsConsonants;
        private System.Windows.Forms.Label lblDisplay;
    }
}

