namespace C08PP01_WordCounter
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
            this.btnCountWords = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCountWords
            // 
            this.btnCountWords.Location = new System.Drawing.Point(43, 149);
            this.btnCountWords.Name = "btnCountWords";
            this.btnCountWords.Size = new System.Drawing.Size(154, 23);
            this.btnCountWords.TabIndex = 1;
            this.btnCountWords.Text = "Count Words";
            this.btnCountWords.UseVisualStyleBackColor = true;
            this.btnCountWords.Click += new System.EventHandler(this.btnCountWords_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(43, 184);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(154, 56);
            this.lblDisplay.TabIndex = 2;
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(43, 27);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(154, 96);
            this.rtbInput.TabIndex = 4;
            this.rtbInput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 263);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnCountWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCountWords;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.RichTextBox rtbInput;
    }
}

