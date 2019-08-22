namespace C04PP04_ColorMixer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radFirstRed = new System.Windows.Forms.RadioButton();
            this.radFirstBlue = new System.Windows.Forms.RadioButton();
            this.radFirstYellow = new System.Windows.Forms.RadioButton();
            this.radSecondYellow = new System.Windows.Forms.RadioButton();
            this.radSecondBlue = new System.Windows.Forms.RadioButton();
            this.radSecondRed = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFirstYellow);
            this.groupBox1.Controls.Add(this.radFirstBlue);
            this.groupBox1.Controls.Add(this.radFirstRed);
            this.groupBox1.Location = new System.Drawing.Point(68, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the First Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radSecondYellow);
            this.groupBox2.Controls.Add(this.radSecondBlue);
            this.groupBox2.Controls.Add(this.radSecondRed);
            this.groupBox2.Location = new System.Drawing.Point(242, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the Second Color";
            // 
            // radFirstRed
            // 
            this.radFirstRed.AutoSize = true;
            this.radFirstRed.Checked = true;
            this.radFirstRed.Location = new System.Drawing.Point(26, 24);
            this.radFirstRed.Name = "radFirstRed";
            this.radFirstRed.Size = new System.Drawing.Size(45, 17);
            this.radFirstRed.TabIndex = 0;
            this.radFirstRed.TabStop = true;
            this.radFirstRed.Text = "Red";
            this.radFirstRed.UseVisualStyleBackColor = true;
            // 
            // radFirstBlue
            // 
            this.radFirstBlue.AutoSize = true;
            this.radFirstBlue.Location = new System.Drawing.Point(26, 47);
            this.radFirstBlue.Name = "radFirstBlue";
            this.radFirstBlue.Size = new System.Drawing.Size(46, 17);
            this.radFirstBlue.TabIndex = 1;
            this.radFirstBlue.TabStop = true;
            this.radFirstBlue.Text = "Blue";
            this.radFirstBlue.UseVisualStyleBackColor = true;
            // 
            // radFirstYellow
            // 
            this.radFirstYellow.AutoSize = true;
            this.radFirstYellow.Location = new System.Drawing.Point(26, 70);
            this.radFirstYellow.Name = "radFirstYellow";
            this.radFirstYellow.Size = new System.Drawing.Size(56, 17);
            this.radFirstYellow.TabIndex = 2;
            this.radFirstYellow.TabStop = true;
            this.radFirstYellow.Text = "Yellow";
            this.radFirstYellow.UseVisualStyleBackColor = true;
            // 
            // radSecondYellow
            // 
            this.radSecondYellow.AutoSize = true;
            this.radSecondYellow.Location = new System.Drawing.Point(26, 70);
            this.radSecondYellow.Name = "radSecondYellow";
            this.radSecondYellow.Size = new System.Drawing.Size(56, 17);
            this.radSecondYellow.TabIndex = 5;
            this.radSecondYellow.TabStop = true;
            this.radSecondYellow.Text = "Yellow";
            this.radSecondYellow.UseVisualStyleBackColor = true;
            // 
            // radSecondBlue
            // 
            this.radSecondBlue.AutoSize = true;
            this.radSecondBlue.Location = new System.Drawing.Point(26, 47);
            this.radSecondBlue.Name = "radSecondBlue";
            this.radSecondBlue.Size = new System.Drawing.Size(46, 17);
            this.radSecondBlue.TabIndex = 4;
            this.radSecondBlue.TabStop = true;
            this.radSecondBlue.Text = "Blue";
            this.radSecondBlue.UseVisualStyleBackColor = true;
            // 
            // radSecondRed
            // 
            this.radSecondRed.AutoSize = true;
            this.radSecondRed.Checked = true;
            this.radSecondRed.Location = new System.Drawing.Point(26, 24);
            this.radSecondRed.Name = "radSecondRed";
            this.radSecondRed.Size = new System.Drawing.Size(45, 17);
            this.radSecondRed.TabIndex = 3;
            this.radSecondRed.TabStop = true;
            this.radSecondRed.Text = "Red";
            this.radSecondRed.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Normal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 247);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFirstYellow;
        private System.Windows.Forms.RadioButton radFirstBlue;
        private System.Windows.Forms.RadioButton radFirstRed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radSecondYellow;
        private System.Windows.Forms.RadioButton radSecondBlue;
        private System.Windows.Forms.RadioButton radSecondRed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

