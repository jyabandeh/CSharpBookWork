namespace C08PP12_SlotMachine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgListFruits = new System.Windows.Forms.ImageList(this.components);
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListFruits
            // 
            this.imgListFruits.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListFruits.ImageStream")));
            this.imgListFruits.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListFruits.Images.SetKeyName(0, "Apple.bmp");
            this.imgListFruits.Images.SetKeyName(1, "Banana.bmp");
            this.imgListFruits.Images.SetKeyName(2, "Cherries.bmp");
            this.imgListFruits.Images.SetKeyName(3, "Grapes.bmp");
            this.imgListFruits.Images.SetKeyName(4, "Lemon.bmp");
            this.imgListFruits.Images.SetKeyName(5, "Lime.bmp");
            this.imgListFruits.Images.SetKeyName(6, "Orange.bmp");
            this.imgListFruits.Images.SetKeyName(7, "Pear.bmp");
            this.imgListFruits.Images.SetKeyName(8, "Strawberry.bmp");
            this.imgListFruits.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // picBox1
            // 
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Location = new System.Drawing.Point(20, 12);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(128, 128);
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox2.Location = new System.Drawing.Point(154, 12);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(128, 128);
            this.picBox2.TabIndex = 1;
            this.picBox2.TabStop = false;
            // 
            // picBox3
            // 
            this.picBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox3.Location = new System.Drawing.Point(288, 12);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(128, 128);
            this.picBox3.TabIndex = 2;
            this.picBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount Inserted: $";
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(219, 163);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(100, 20);
            this.txtBet.TabIndex = 4;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(140, 215);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 5;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(221, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgListFruits;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnExit;
    }
}

