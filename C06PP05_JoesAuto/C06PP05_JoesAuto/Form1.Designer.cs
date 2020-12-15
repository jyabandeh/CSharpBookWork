namespace C06PP05_JoesAuto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOil = new System.Windows.Forms.CheckBox();
            this.chkLube = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTransmission = new System.Windows.Forms.CheckBox();
            this.chkRadiator = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkMuffler = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.chkTire = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.Summary = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblPartsLabor = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLube);
            this.groupBox1.Controls.Add(this.chkOil);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // chkOil
            // 
            this.chkOil.AutoSize = true;
            this.chkOil.Location = new System.Drawing.Point(7, 20);
            this.chkOil.Name = "chkOil";
            this.chkOil.Size = new System.Drawing.Size(120, 17);
            this.chkOil.TabIndex = 0;
            this.chkOil.Text = "Oil Change ($26.00)";
            this.chkOil.UseVisualStyleBackColor = true;
            // 
            // chkLube
            // 
            this.chkLube.AutoSize = true;
            this.chkLube.Location = new System.Drawing.Point(7, 43);
            this.chkLube.Name = "chkLube";
            this.chkLube.Size = new System.Drawing.Size(112, 17);
            this.chkLube.TabIndex = 1;
            this.chkLube.Text = "Lube Job ($18.00)";
            this.chkLube.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTransmission);
            this.groupBox2.Controls.Add(this.chkRadiator);
            this.groupBox2.Location = new System.Drawing.Point(184, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // chkTransmission
            // 
            this.chkTransmission.AutoSize = true;
            this.chkTransmission.Location = new System.Drawing.Point(7, 43);
            this.chkTransmission.Name = "chkTransmission";
            this.chkTransmission.Size = new System.Drawing.Size(157, 17);
            this.chkTransmission.TabIndex = 1;
            this.chkTransmission.Text = "Transmission Flush ($80.00)";
            this.chkTransmission.UseVisualStyleBackColor = true;
            // 
            // chkRadiator
            // 
            this.chkRadiator.AutoSize = true;
            this.chkRadiator.Location = new System.Drawing.Point(7, 20);
            this.chkRadiator.Name = "chkRadiator";
            this.chkRadiator.Size = new System.Drawing.Size(136, 17);
            this.chkRadiator.TabIndex = 0;
            this.chkRadiator.Text = "Radiator Flush ($30.00)";
            this.chkRadiator.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTire);
            this.groupBox3.Controls.Add(this.chkMuffler);
            this.groupBox3.Controls.Add(this.chkInspection);
            this.groupBox3.Location = new System.Drawing.Point(16, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // chkMuffler
            // 
            this.chkMuffler.AutoSize = true;
            this.chkMuffler.Location = new System.Drawing.Point(7, 43);
            this.chkMuffler.Name = "chkMuffler";
            this.chkMuffler.Size = new System.Drawing.Size(149, 17);
            this.chkMuffler.TabIndex = 1;
            this.chkMuffler.Text = "Replace Muffler ($100.00)";
            this.chkMuffler.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(7, 20);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(117, 17);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "Inspection ($15.00)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // chkTire
            // 
            this.chkTire.AutoSize = true;
            this.chkTire.Location = new System.Drawing.Point(6, 66);
            this.chkTire.Name = "chkTire";
            this.chkTire.Size = new System.Drawing.Size(129, 17);
            this.chkTire.TabIndex = 2;
            this.chkTire.Text = "Tire Rotation ($20.00)";
            this.chkTire.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLabor);
            this.groupBox4.Controls.Add(this.txtParts);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(184, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor ($)";
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(77, 21);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(67, 20);
            this.txtParts.TabIndex = 2;
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(77, 48);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(67, 20);
            this.txtLabor.TabIndex = 3;
            // 
            // Summary
            // 
            this.Summary.Controls.Add(this.lblTotal);
            this.Summary.Controls.Add(this.lblTax);
            this.Summary.Controls.Add(this.lblPartsLabor);
            this.Summary.Controls.Add(this.lblService);
            this.Summary.Controls.Add(this.label6);
            this.Summary.Controls.Add(this.label5);
            this.Summary.Controls.Add(this.label4);
            this.Summary.Controls.Add(this.label3);
            this.Summary.Location = new System.Drawing.Point(16, 203);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(346, 165);
            this.Summary.TabIndex = 4;
            this.Summary.TabStop = false;
            this.Summary.Text = "groupBox5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts and Labor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax (on parts)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees";
            // 
            // lblService
            // 
            this.lblService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblService.Location = new System.Drawing.Point(106, 25);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(100, 23);
            this.lblService.TabIndex = 4;
            // 
            // lblPartsLabor
            // 
            this.lblPartsLabor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartsLabor.Location = new System.Drawing.Point(106, 57);
            this.lblPartsLabor.Name = "lblPartsLabor";
            this.lblPartsLabor.Size = new System.Drawing.Size(100, 23);
            this.lblPartsLabor.TabIndex = 5;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(106, 89);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(100, 23);
            this.lblTax.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(106, 121);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(71, 387);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(152, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 439);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLube;
        private System.Windows.Forms.CheckBox chkOil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTransmission;
        private System.Windows.Forms.CheckBox chkRadiator;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkTire;
        private System.Windows.Forms.CheckBox chkMuffler;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Summary;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPartsLabor;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

