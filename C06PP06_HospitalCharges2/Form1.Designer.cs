namespace C06PP06_HospitalCharges2
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
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtMedication = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurgical = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhysRehab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStayCharges = new System.Windows.Forms.Label();
            this.lblMiscCharges = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days in Hospital:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(155, 23);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 1;
            // 
            // txtMedication
            // 
            this.txtMedication.Location = new System.Drawing.Point(155, 49);
            this.txtMedication.Name = "txtMedication";
            this.txtMedication.Size = new System.Drawing.Size(100, 20);
            this.txtMedication.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medication ($):";
            // 
            // txtSurgical
            // 
            this.txtSurgical.Location = new System.Drawing.Point(155, 76);
            this.txtSurgical.Name = "txtSurgical";
            this.txtSurgical.Size = new System.Drawing.Size(100, 20);
            this.txtSurgical.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surgical ($):";
            // 
            // txtLab
            // 
            this.txtLab.Location = new System.Drawing.Point(155, 103);
            this.txtLab.Name = "txtLab";
            this.txtLab.Size = new System.Drawing.Size(100, 20);
            this.txtLab.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lab ($):";
            // 
            // txtPhysRehab
            // 
            this.txtPhysRehab.Location = new System.Drawing.Point(155, 129);
            this.txtPhysRehab.Name = "txtPhysRehab";
            this.txtPhysRehab.Size = new System.Drawing.Size(100, 20);
            this.txtPhysRehab.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Physical Rehab ($):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(100, 288);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(127, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stay Charges:";
            // 
            // lblStayCharges
            // 
            this.lblStayCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStayCharges.Location = new System.Drawing.Point(155, 184);
            this.lblStayCharges.Name = "lblStayCharges";
            this.lblStayCharges.Size = new System.Drawing.Size(100, 23);
            this.lblStayCharges.TabIndex = 12;
            this.lblStayCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiscCharges
            // 
            this.lblMiscCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMiscCharges.Location = new System.Drawing.Point(155, 217);
            this.lblMiscCharges.Name = "lblMiscCharges";
            this.lblMiscCharges.Size = new System.Drawing.Size(100, 23);
            this.lblMiscCharges.TabIndex = 14;
            this.lblMiscCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Misc Charges:";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCharges.Location = new System.Drawing.Point(155, 249);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(100, 23);
            this.lblTotalCharges.TabIndex = 16;
            this.lblTotalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total Charges:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 339);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblMiscCharges);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblStayCharges);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPhysRehab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSurgical);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedication);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurgical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhysRehab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStayCharges;
        private System.Windows.Forms.Label lblMiscCharges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label label11;
    }
}

