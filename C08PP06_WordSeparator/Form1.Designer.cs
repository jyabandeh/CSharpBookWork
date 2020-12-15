namespace C08PP06_WordSeparator
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
            this.btnSeparateWords = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(13, 13);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(209, 96);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // btnSeparateWords
            // 
            this.btnSeparateWords.Location = new System.Drawing.Point(13, 116);
            this.btnSeparateWords.Name = "btnSeparateWords";
            this.btnSeparateWords.Size = new System.Drawing.Size(209, 23);
            this.btnSeparateWords.TabIndex = 1;
            this.btnSeparateWords.Text = "Separate Words";
            this.btnSeparateWords.UseVisualStyleBackColor = true;
            this.btnSeparateWords.Click += new System.EventHandler(this.btnSeparateWords_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(13, 159);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(209, 87);
            this.lblDisplay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 285);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnSeparateWords);
            this.Controls.Add(this.rtbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnSeparateWords;
        private System.Windows.Forms.Label lblDisplay;
    }
}

