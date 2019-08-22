namespace C04PP12_WorkshopCollector
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
            this.lstWorkshop = new System.Windows.Forms.ListBox();
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.lblDisplayCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstWorkshop
            // 
            this.lstWorkshop.FormattingEnabled = true;
            this.lstWorkshop.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.lstWorkshop.Location = new System.Drawing.Point(12, 54);
            this.lstWorkshop.Name = "lstWorkshop";
            this.lstWorkshop.Size = new System.Drawing.Size(120, 82);
            this.lstWorkshop.TabIndex = 0;
            // 
            // lstLocation
            // 
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.lstLocation.Location = new System.Drawing.Point(138, 54);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(120, 82);
            this.lstLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Workshop:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a Location";
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Location = new System.Drawing.Point(50, 155);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(157, 23);
            this.btnCalculateCost.TabIndex = 4;
            this.btnCalculateCost.Text = "Calculate Cost";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // lblDisplayCost
            // 
            this.lblDisplayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayCost.Location = new System.Drawing.Point(50, 199);
            this.lblDisplayCost.Name = "lblDisplayCost";
            this.lblDisplayCost.Size = new System.Drawing.Size(157, 66);
            this.lblDisplayCost.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 321);
            this.Controls.Add(this.lblDisplayCost);
            this.Controls.Add(this.btnCalculateCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLocation);
            this.Controls.Add(this.lstWorkshop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstWorkshop;
        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.Label lblDisplayCost;
    }
}

