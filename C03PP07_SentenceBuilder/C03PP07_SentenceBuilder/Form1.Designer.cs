namespace C03PP07_SentenceBuilder
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
            this.btnThe = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnBarks = new System.Windows.Forms.Button();
            this.btnExclamation = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThe
            // 
            this.btnThe.AutoSize = true;
            this.btnThe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThe.Location = new System.Drawing.Point(292, 70);
            this.btnThe.Name = "btnThe";
            this.btnThe.Size = new System.Drawing.Size(36, 23);
            this.btnThe.TabIndex = 0;
            this.btnThe.Text = "The";
            this.btnThe.UseVisualStyleBackColor = true;
            this.btnThe.Click += new System.EventHandler(this.btnThe_Click);
            // 
            // btnDog
            // 
            this.btnDog.AutoSize = true;
            this.btnDog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDog.Location = new System.Drawing.Point(356, 70);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(35, 23);
            this.btnDog.TabIndex = 1;
            this.btnDog.Text = "dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // btnBarks
            // 
            this.btnBarks.AutoSize = true;
            this.btnBarks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBarks.Location = new System.Drawing.Point(292, 99);
            this.btnBarks.Name = "btnBarks";
            this.btnBarks.Size = new System.Drawing.Size(43, 23);
            this.btnBarks.TabIndex = 2;
            this.btnBarks.Text = "barks";
            this.btnBarks.UseVisualStyleBackColor = true;
            this.btnBarks.Click += new System.EventHandler(this.btnBarks_Click);
            // 
            // btnExclamation
            // 
            this.btnExclamation.AutoSize = true;
            this.btnExclamation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExclamation.Location = new System.Drawing.Point(356, 99);
            this.btnExclamation.Name = "btnExclamation";
            this.btnExclamation.Size = new System.Drawing.Size(20, 23);
            this.btnExclamation.TabIndex = 3;
            this.btnExclamation.Text = "!";
            this.btnExclamation.UseVisualStyleBackColor = true;
            this.btnExclamation.Click += new System.EventHandler(this.btnExclamation_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(14, 184);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(654, 23);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(345, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(292, 128);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(75, 23);
            this.btnSpace.TabIndex = 7;
            this.btnSpace.Text = "(Space)";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 321);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnExclamation);
            this.Controls.Add(this.btnBarks);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.btnThe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThe;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnBarks;
        private System.Windows.Forms.Button btnExclamation;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSpace;
    }
}

