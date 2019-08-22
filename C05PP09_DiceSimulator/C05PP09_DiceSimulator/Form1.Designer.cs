namespace C05PP09_DiceSimulator
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
            this.picDieBlock1 = new System.Windows.Forms.PictureBox();
            this.picDieBlock2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picDieBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDieBlock2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDieBlock1
            // 
            this.picDieBlock1.Image = global::C05PP09_DiceSimulator.Properties.Resources.Die1;
            this.picDieBlock1.Location = new System.Drawing.Point(13, 14);
            this.picDieBlock1.Name = "picDieBlock1";
            this.picDieBlock1.Size = new System.Drawing.Size(104, 104);
            this.picDieBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDieBlock1.TabIndex = 0;
            this.picDieBlock1.TabStop = false;
            // 
            // picDieBlock2
            // 
            this.picDieBlock2.Image = global::C05PP09_DiceSimulator.Properties.Resources.Die1;
            this.picDieBlock2.Location = new System.Drawing.Point(123, 14);
            this.picDieBlock2.Name = "picDieBlock2";
            this.picDieBlock2.Size = new System.Drawing.Size(104, 104);
            this.picDieBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDieBlock2.TabIndex = 1;
            this.picDieBlock2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Roll the Dice!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picDieBlock1);
            this.panel1.Controls.Add(this.picDieBlock2);
            this.panel1.Location = new System.Drawing.Point(34, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 137);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDieBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDieBlock2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDieBlock1;
        private System.Windows.Forms.PictureBox picDieBlock2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

