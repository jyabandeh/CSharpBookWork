namespace C08PP05_MostFrequentCharacter
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
            this.btnGetMostFreqChar = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 12);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(204, 135);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // btnGetMostFreqChar
            // 
            this.btnGetMostFreqChar.Location = new System.Drawing.Point(12, 154);
            this.btnGetMostFreqChar.Name = "btnGetMostFreqChar";
            this.btnGetMostFreqChar.Size = new System.Drawing.Size(204, 23);
            this.btnGetMostFreqChar.TabIndex = 1;
            this.btnGetMostFreqChar.Text = "Get Most Frequent Character(s)";
            this.btnGetMostFreqChar.UseVisualStyleBackColor = true;
            this.btnGetMostFreqChar.Click += new System.EventHandler(this.btnGetMostFreqChar_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(12, 184);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(204, 69);
            this.lstDisplay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnGetMostFreqChar);
            this.Controls.Add(this.rtbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnGetMostFreqChar;
        private System.Windows.Forms.ListBox lstDisplay;
    }
}

