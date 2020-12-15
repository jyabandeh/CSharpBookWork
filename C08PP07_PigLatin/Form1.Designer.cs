namespace C08PP07_PigLatin
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
            this.btnConvertToPigLatin = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(11, 73);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(195, 112);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // btnConvertToPigLatin
            // 
            this.btnConvertToPigLatin.Location = new System.Drawing.Point(11, 208);
            this.btnConvertToPigLatin.Name = "btnConvertToPigLatin";
            this.btnConvertToPigLatin.Size = new System.Drawing.Size(195, 23);
            this.btnConvertToPigLatin.TabIndex = 1;
            this.btnConvertToPigLatin.Text = "Convert To Pig Latin";
            this.btnConvertToPigLatin.UseVisualStyleBackColor = true;
            this.btnConvertToPigLatin.Click += new System.EventHandler(this.btnConvertToPigLatin_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(12, 238);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(194, 94);
            this.lblDisplay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type a sentence in all caps with no punctuation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnConvertToPigLatin);
            this.Controls.Add(this.rtbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnConvertToPigLatin;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label1;
    }
}

