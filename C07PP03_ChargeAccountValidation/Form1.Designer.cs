namespace C07PP03_ChargeAccountValidation
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
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckValid = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Location = new System.Drawing.Point(208, 61);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a 7 Digit Account Number:";
            // 
            // btnCheckValid
            // 
            this.btnCheckValid.Location = new System.Drawing.Point(108, 100);
            this.btnCheckValid.Name = "btnCheckValid";
            this.btnCheckValid.Size = new System.Drawing.Size(135, 23);
            this.btnCheckValid.TabIndex = 2;
            this.btnCheckValid.Text = "Check Valid";
            this.btnCheckValid.UseVisualStyleBackColor = true;
            this.btnCheckValid.Click += new System.EventHandler(this.btnCheckValid_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(45, 144);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(263, 63);
            this.lblDisplay.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(352, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 282);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnCheckValid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckValid;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ListBox listBox1;
    }
}

