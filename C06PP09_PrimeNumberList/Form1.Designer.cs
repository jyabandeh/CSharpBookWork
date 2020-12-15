namespace C06PP09_PrimeNumberList
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
            this.lstPrimes = new System.Windows.Forms.ListBox();
            this.btnShowPrimes = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPrimes
            // 
            this.lstPrimes.FormattingEnabled = true;
            this.lstPrimes.Location = new System.Drawing.Point(12, 12);
            this.lstPrimes.Name = "lstPrimes";
            this.lstPrimes.Size = new System.Drawing.Size(104, 394);
            this.lstPrimes.TabIndex = 0;
            // 
            // btnShowPrimes
            // 
            this.btnShowPrimes.Location = new System.Drawing.Point(122, 12);
            this.btnShowPrimes.Name = "btnShowPrimes";
            this.btnShowPrimes.Size = new System.Drawing.Size(148, 23);
            this.btnShowPrimes.TabIndex = 1;
            this.btnShowPrimes.Text = "Show Primes (1-100)";
            this.btnShowPrimes.UseVisualStyleBackColor = true;
            this.btnShowPrimes.Click += new System.EventHandler(this.btnShowPrimes_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(122, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowPrimes);
            this.Controls.Add(this.lstPrimes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPrimes;
        private System.Windows.Forms.Button btnShowPrimes;
        private System.Windows.Forms.Button btnClear;
    }
}

