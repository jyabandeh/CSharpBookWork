namespace C06PP08_PrimeNumbers
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
            this.txtInteger = new System.Windows.Forms.TextBox();
            this.btnIsPrime = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Integer:";
            // 
            // txtInteger
            // 
            this.txtInteger.Location = new System.Drawing.Point(99, 34);
            this.txtInteger.Name = "txtInteger";
            this.txtInteger.Size = new System.Drawing.Size(100, 20);
            this.txtInteger.TabIndex = 1;
            // 
            // btnIsPrime
            // 
            this.btnIsPrime.Location = new System.Drawing.Point(88, 71);
            this.btnIsPrime.Name = "btnIsPrime";
            this.btnIsPrime.Size = new System.Drawing.Size(75, 23);
            this.btnIsPrime.TabIndex = 2;
            this.btnIsPrime.Text = "Is Prime?";
            this.btnIsPrime.UseVisualStyleBackColor = true;
            this.btnIsPrime.Click += new System.EventHandler(this.btnIsPrime_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(53, 125);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(146, 41);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 200);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnIsPrime);
            this.Controls.Add(this.txtInteger);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInteger;
        private System.Windows.Forms.Button btnIsPrime;
        private System.Windows.Forms.Label lblDisplay;
    }
}

