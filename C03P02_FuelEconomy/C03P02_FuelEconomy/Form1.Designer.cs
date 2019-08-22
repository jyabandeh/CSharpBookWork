namespace C03P02_FuelEconomy
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
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMPG = new System.Windows.Forms.Label();
            this.btnCalculateMPG = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of miles driven:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the gallons of gas used:";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(179, 19);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 2;
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(179, 46);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(100, 20);
            this.txtGallons.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your car\'s mileage:";
            // 
            // lblMPG
            // 
            this.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPG.Location = new System.Drawing.Point(179, 92);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(100, 23);
            this.lblMPG.TabIndex = 5;
            this.lblMPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateMPG
            // 
            this.btnCalculateMPG.Location = new System.Drawing.Point(73, 147);
            this.btnCalculateMPG.Name = "btnCalculateMPG";
            this.btnCalculateMPG.Size = new System.Drawing.Size(75, 37);
            this.btnCalculateMPG.TabIndex = 6;
            this.btnCalculateMPG.Text = "Calculate MPG";
            this.btnCalculateMPG.UseVisualStyleBackColor = true;
            this.btnCalculateMPG.Click += new System.EventHandler(this.btnCalculateMPG_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(155, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 209);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateMPG);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtMiles);
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
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.Button btnCalculateMPG;
        private System.Windows.Forms.Button btnExit;
    }
}

