namespace C07PP06_NameSearch
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
            this.txtBoyName = new System.Windows.Forms.TextBox();
            this.lblBoyName = new System.Windows.Forms.Label();
            this.lblGirlName = new System.Windows.Forms.Label();
            this.txtGirlName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchNames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Boy Name:";
            // 
            // txtBoyName
            // 
            this.txtBoyName.Location = new System.Drawing.Point(44, 85);
            this.txtBoyName.Name = "txtBoyName";
            this.txtBoyName.Size = new System.Drawing.Size(135, 20);
            this.txtBoyName.TabIndex = 1;
            // 
            // lblBoyName
            // 
            this.lblBoyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoyName.Location = new System.Drawing.Point(44, 108);
            this.lblBoyName.Name = "lblBoyName";
            this.lblBoyName.Size = new System.Drawing.Size(135, 48);
            this.lblBoyName.TabIndex = 2;
            // 
            // lblGirlName
            // 
            this.lblGirlName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGirlName.Location = new System.Drawing.Point(219, 108);
            this.lblGirlName.Name = "lblGirlName";
            this.lblGirlName.Size = new System.Drawing.Size(141, 48);
            this.lblGirlName.TabIndex = 5;
            // 
            // txtGirlName
            // 
            this.txtGirlName.Location = new System.Drawing.Point(219, 85);
            this.txtGirlName.Name = "txtGirlName";
            this.txtGirlName.Size = new System.Drawing.Size(141, 20);
            this.txtGirlName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter a Girl Name:";
            // 
            // btnSearchNames
            // 
            this.btnSearchNames.Location = new System.Drawing.Point(103, 187);
            this.btnSearchNames.Name = "btnSearchNames";
            this.btnSearchNames.Size = new System.Drawing.Size(169, 23);
            this.btnSearchNames.TabIndex = 6;
            this.btnSearchNames.Text = "Search Names";
            this.btnSearchNames.UseVisualStyleBackColor = true;
            this.btnSearchNames.Click += new System.EventHandler(this.btnSearchNames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 256);
            this.Controls.Add(this.btnSearchNames);
            this.Controls.Add(this.lblGirlName);
            this.Controls.Add(this.txtGirlName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBoyName);
            this.Controls.Add(this.txtBoyName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoyName;
        private System.Windows.Forms.Label lblBoyName;
        private System.Windows.Forms.Label lblGirlName;
        private System.Windows.Forms.TextBox txtGirlName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchNames;
    }
}

