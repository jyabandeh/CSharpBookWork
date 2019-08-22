namespace C03PP11_AutomobileCosts
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
            this.txtLoanPayment = new System.Windows.Forms.TextBox();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.txtOil = new System.Windows.Forms.TextBox();
            this.txtTires = new System.Windows.Forms.TextBox();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtLoanPayment
            // 
            this.txtLoanPayment.Location = new System.Drawing.Point(131, 29);
            this.txtLoanPayment.Name = "txtLoanPayment";
            this.txtLoanPayment.Size = new System.Drawing.Size(100, 20);
            this.txtLoanPayment.TabIndex = 0;
            // 
            // txtInsurance
            // 
            this.txtInsurance.Location = new System.Drawing.Point(131, 55);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(100, 20);
            this.txtInsurance.TabIndex = 1;
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(131, 81);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(100, 20);
            this.txtGas.TabIndex = 2;
            // 
            // txtOil
            // 
            this.txtOil.Location = new System.Drawing.Point(131, 107);
            this.txtOil.Name = "txtOil";
            this.txtOil.Size = new System.Drawing.Size(100, 20);
            this.txtOil.TabIndex = 3;
            // 
            // txtTires
            // 
            this.txtTires.Location = new System.Drawing.Point(131, 133);
            this.txtTires.Name = "txtTires";
            this.txtTires.Size = new System.Drawing.Size(100, 20);
            this.txtTires.TabIndex = 4;
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.Location = new System.Drawing.Point(131, 159);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(100, 20);
            this.txtMaintenance.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loan Payment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insurance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Oil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tires:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Maintenance:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(71, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(71, 249);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(144, 51);
            this.rtbDisplay.TabIndex = 13;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 340);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaintenance);
            this.Controls.Add(this.txtTires);
            this.Controls.Add(this.txtOil);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.txtLoanPayment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoanPayment;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.TextBox txtOil;
        private System.Windows.Forms.TextBox txtTires;
        private System.Windows.Forms.TextBox txtMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

