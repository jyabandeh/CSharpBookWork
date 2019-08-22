namespace C04PP02_MassAndWeight
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
            this.txtMass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnCalculateWeight = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass (kg)";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(116, 27);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(77, 20);
            this.txtMass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight (N)";
            // 
            // lblWeight
            // 
            this.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeight.Location = new System.Drawing.Point(116, 53);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(77, 20);
            this.lblWeight.TabIndex = 3;
            // 
            // btnCalculateWeight
            // 
            this.btnCalculateWeight.Location = new System.Drawing.Point(52, 115);
            this.btnCalculateWeight.Name = "btnCalculateWeight";
            this.btnCalculateWeight.Size = new System.Drawing.Size(141, 23);
            this.btnCalculateWeight.TabIndex = 4;
            this.btnCalculateWeight.Text = "Calculate Weight";
            this.btnCalculateWeight.UseVisualStyleBackColor = true;
            this.btnCalculateWeight.Click += new System.EventHandler(this.btnCalculateWeight_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(52, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(49, 89);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(144, 23);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 204);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnCalculateWeight;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMessage;
    }
}

