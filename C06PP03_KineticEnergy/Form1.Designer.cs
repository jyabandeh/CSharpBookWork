﻿namespace C06PP03_KineticEnergy
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.btnCalculateKineticEnergy = new System.Windows.Forms.Button();
            this.lblKineticEnergy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocity (m/s):";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(165, 41);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(100, 20);
            this.txtMass.TabIndex = 2;
            // 
            // txtVelocity
            // 
            this.txtVelocity.Location = new System.Drawing.Point(165, 68);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(100, 20);
            this.txtVelocity.TabIndex = 3;
            // 
            // btnCalculateKineticEnergy
            // 
            this.btnCalculateKineticEnergy.Location = new System.Drawing.Point(88, 145);
            this.btnCalculateKineticEnergy.Name = "btnCalculateKineticEnergy";
            this.btnCalculateKineticEnergy.Size = new System.Drawing.Size(177, 23);
            this.btnCalculateKineticEnergy.TabIndex = 4;
            this.btnCalculateKineticEnergy.Text = "Calculate Kinetic Energy";
            this.btnCalculateKineticEnergy.UseVisualStyleBackColor = true;
            this.btnCalculateKineticEnergy.Click += new System.EventHandler(this.btnCalculateKineticEnergy_Click);
            // 
            // lblKineticEnergy
            // 
            this.lblKineticEnergy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKineticEnergy.Location = new System.Drawing.Point(165, 100);
            this.lblKineticEnergy.Name = "lblKineticEnergy";
            this.lblKineticEnergy.Size = new System.Drawing.Size(100, 20);
            this.lblKineticEnergy.TabIndex = 5;
            this.lblKineticEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kinetic Energy:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKineticEnergy);
            this.Controls.Add(this.btnCalculateKineticEnergy);
            this.Controls.Add(this.txtVelocity);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.TextBox txtVelocity;
        private System.Windows.Forms.Button btnCalculateKineticEnergy;
        private System.Windows.Forms.Label lblKineticEnergy;
        private System.Windows.Forms.Label label3;
    }
}

