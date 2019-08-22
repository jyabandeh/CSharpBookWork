namespace C03PP03_DistanceTravelled
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
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.btn5Hours = new System.Windows.Forms.Button();
            this.btn8Hours = new System.Windows.Forms.Button();
            this.btn12Hours = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Speed (mph):";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(191, 47);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 1;
            // 
            // btn5Hours
            // 
            this.btn5Hours.Location = new System.Drawing.Point(90, 86);
            this.btn5Hours.Name = "btn5Hours";
            this.btn5Hours.Size = new System.Drawing.Size(201, 23);
            this.btn5Hours.TabIndex = 2;
            this.btn5Hours.Text = "Distance in 5 Hours";
            this.btn5Hours.UseVisualStyleBackColor = true;
            this.btn5Hours.Click += new System.EventHandler(this.btn5Hours_Click);
            // 
            // btn8Hours
            // 
            this.btn8Hours.Location = new System.Drawing.Point(90, 115);
            this.btn8Hours.Name = "btn8Hours";
            this.btn8Hours.Size = new System.Drawing.Size(201, 23);
            this.btn8Hours.TabIndex = 3;
            this.btn8Hours.Text = "Distance in 8 Hours";
            this.btn8Hours.UseVisualStyleBackColor = true;
            this.btn8Hours.Click += new System.EventHandler(this.btn8Hours_Click);
            // 
            // btn12Hours
            // 
            this.btn12Hours.Location = new System.Drawing.Point(90, 144);
            this.btn12Hours.Name = "btn12Hours";
            this.btn12Hours.Size = new System.Drawing.Size(201, 23);
            this.btn12Hours.TabIndex = 4;
            this.btn12Hours.Text = "Distance in 12 Hours";
            this.btn12Hours.UseVisualStyleBackColor = true;
            this.btn12Hours.Click += new System.EventHandler(this.btn12Hours_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(90, 193);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(201, 23);
            this.lblDisplay.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btn12Hours);
            this.Controls.Add(this.btn8Hours);
            this.Controls.Add(this.btn5Hours);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button btn5Hours;
        private System.Windows.Forms.Button btn8Hours;
        private System.Windows.Forms.Button btn12Hours;
        private System.Windows.Forms.Label lblDisplay;
    }
}

