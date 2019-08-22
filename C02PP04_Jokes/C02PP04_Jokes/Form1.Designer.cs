namespace C02PP04_Jokes
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
            this.lblJoke = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnPunchLine = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoke
            // 
            this.lblJoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoke.Location = new System.Drawing.Point(12, 23);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(188, 69);
            this.lblJoke.TabIndex = 0;
            this.lblJoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(44, 117);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(127, 23);
            this.btnSetup.TabIndex = 1;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnPunchLine
            // 
            this.btnPunchLine.Location = new System.Drawing.Point(44, 117);
            this.btnPunchLine.Name = "btnPunchLine";
            this.btnPunchLine.Size = new System.Drawing.Size(127, 23);
            this.btnPunchLine.TabIndex = 2;
            this.btnPunchLine.Text = "Punch Line";
            this.btnPunchLine.UseVisualStyleBackColor = true;
            this.btnPunchLine.Visible = false;
            this.btnPunchLine.Click += new System.EventHandler(this.btnPunchLine_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(44, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Okay, Now Leave";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 166);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPunchLine);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.lblJoke);
            this.Name = "Form1";
            this.Text = "Jokes!!!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnPunchLine;
        private System.Windows.Forms.Button btnExit;
    }
}

