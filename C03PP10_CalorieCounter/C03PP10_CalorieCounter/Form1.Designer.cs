namespace C03PP10_CalorieCounter
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
            this.picBanana = new System.Windows.Forms.PictureBox();
            this.picApple = new System.Windows.Forms.PictureBox();
            this.picOrange = new System.Windows.Forms.PictureBox();
            this.picPear = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).BeginInit();
            this.SuspendLayout();
            // 
            // picBanana
            // 
            this.picBanana.Image = global::C03PP10_CalorieCounter.Properties.Resources.BananaCalories;
            this.picBanana.Location = new System.Drawing.Point(49, 33);
            this.picBanana.Name = "picBanana";
            this.picBanana.Size = new System.Drawing.Size(128, 155);
            this.picBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBanana.TabIndex = 0;
            this.picBanana.TabStop = false;
            this.picBanana.Click += new System.EventHandler(this.picBanana_Click);
            // 
            // picApple
            // 
            this.picApple.Image = global::C03PP10_CalorieCounter.Properties.Resources.AppleCalories;
            this.picApple.Location = new System.Drawing.Point(183, 33);
            this.picApple.Name = "picApple";
            this.picApple.Size = new System.Drawing.Size(128, 155);
            this.picApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picApple.TabIndex = 1;
            this.picApple.TabStop = false;
            this.picApple.Click += new System.EventHandler(this.picApple_Click);
            // 
            // picOrange
            // 
            this.picOrange.Image = global::C03PP10_CalorieCounter.Properties.Resources.OrangeCalories;
            this.picOrange.Location = new System.Drawing.Point(49, 194);
            this.picOrange.Name = "picOrange";
            this.picOrange.Size = new System.Drawing.Size(128, 155);
            this.picOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOrange.TabIndex = 2;
            this.picOrange.TabStop = false;
            this.picOrange.Click += new System.EventHandler(this.picOrange_Click);
            // 
            // picPear
            // 
            this.picPear.Image = global::C03PP10_CalorieCounter.Properties.Resources.PearCalories;
            this.picPear.Location = new System.Drawing.Point(183, 194);
            this.picPear.Name = "picPear";
            this.picPear.Size = new System.Drawing.Size(128, 155);
            this.picPear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPear.TabIndex = 3;
            this.picPear.TabStop = false;
            this.picPear.Click += new System.EventHandler(this.picPear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Calories";
            // 
            // lblCalories
            // 
            this.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalories.Location = new System.Drawing.Point(347, 78);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(111, 23);
            this.lblCalories.TabIndex = 5;
            this.lblCalories.Text = "0";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(365, 280);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 374);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPear);
            this.Controls.Add(this.picOrange);
            this.Controls.Add(this.picApple);
            this.Controls.Add(this.picBanana);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanana;
        private System.Windows.Forms.PictureBox picApple;
        private System.Windows.Forms.PictureBox picOrange;
        private System.Windows.Forms.PictureBox picPear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

