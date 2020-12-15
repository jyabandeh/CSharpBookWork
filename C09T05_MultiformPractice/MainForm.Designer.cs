namespace C09T05_MultiformPractice
{
    partial class MainForm
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
            this.btnDisplayForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayForm
            // 
            this.btnDisplayForm.Location = new System.Drawing.Point(79, 64);
            this.btnDisplayForm.Name = "btnDisplayForm";
            this.btnDisplayForm.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayForm.TabIndex = 0;
            this.btnDisplayForm.Text = "Display Form";
            this.btnDisplayForm.UseVisualStyleBackColor = true;
            this.btnDisplayForm.Click += new System.EventHandler(this.btnDisplayForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(160, 64);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 143);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayForm);
            this.Name = "MainForm";
            this.Text = "Multiform Practice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayForm;
        private System.Windows.Forms.Button btnExit;
    }
}

