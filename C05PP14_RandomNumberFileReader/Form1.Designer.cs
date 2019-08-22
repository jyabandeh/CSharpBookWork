namespace C05PP14_RandomNumberFileReader
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
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnReadCalc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(13, 13);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(181, 238);
            this.lstDisplay.TabIndex = 0;
            // 
            // btnReadCalc
            // 
            this.btnReadCalc.Location = new System.Drawing.Point(13, 270);
            this.btnReadCalc.Name = "btnReadCalc";
            this.btnReadCalc.Size = new System.Drawing.Size(181, 23);
            this.btnReadCalc.TabIndex = 1;
            this.btnReadCalc.Text = "Read and Calculate from File";
            this.btnReadCalc.UseVisualStyleBackColor = true;
            this.btnReadCalc.Click += new System.EventHandler(this.btnReadCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 340);
            this.Controls.Add(this.btnReadCalc);
            this.Controls.Add(this.lstDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnReadCalc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

