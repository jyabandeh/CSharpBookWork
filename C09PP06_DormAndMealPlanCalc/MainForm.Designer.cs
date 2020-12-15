namespace C09PP06_DormAndMealPlanCalc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAllenHall = new System.Windows.Forms.RadioButton();
            this.radPikeHall = new System.Windows.Forms.RadioButton();
            this.radFarthingHall = new System.Windows.Forms.RadioButton();
            this.radUniversitySuites = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radUnlimitedMeals = new System.Windows.Forms.RadioButton();
            this.rad14Meals = new System.Windows.Forms.RadioButton();
            this.rad7Meals = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUniversitySuites);
            this.groupBox1.Controls.Add(this.radFarthingHall);
            this.groupBox1.Controls.Add(this.radPikeHall);
            this.groupBox1.Controls.Add(this.radAllenHall);
            this.groupBox1.Location = new System.Drawing.Point(51, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Dorm";
            // 
            // radAllenHall
            // 
            this.radAllenHall.AutoSize = true;
            this.radAllenHall.Checked = true;
            this.radAllenHall.Location = new System.Drawing.Point(29, 32);
            this.radAllenHall.Name = "radAllenHall";
            this.radAllenHall.Size = new System.Drawing.Size(69, 17);
            this.radAllenHall.TabIndex = 0;
            this.radAllenHall.TabStop = true;
            this.radAllenHall.Text = "Allen Hall";
            this.radAllenHall.UseVisualStyleBackColor = true;
            // 
            // radPikeHall
            // 
            this.radPikeHall.AutoSize = true;
            this.radPikeHall.Location = new System.Drawing.Point(29, 55);
            this.radPikeHall.Name = "radPikeHall";
            this.radPikeHall.Size = new System.Drawing.Size(67, 17);
            this.radPikeHall.TabIndex = 1;
            this.radPikeHall.Text = "Pike Hall";
            this.radPikeHall.UseVisualStyleBackColor = true;
            // 
            // radFarthingHall
            // 
            this.radFarthingHall.AutoSize = true;
            this.radFarthingHall.Location = new System.Drawing.Point(29, 78);
            this.radFarthingHall.Name = "radFarthingHall";
            this.radFarthingHall.Size = new System.Drawing.Size(84, 17);
            this.radFarthingHall.TabIndex = 2;
            this.radFarthingHall.Text = "Farthing Hall";
            this.radFarthingHall.UseVisualStyleBackColor = true;
            // 
            // radUniversitySuites
            // 
            this.radUniversitySuites.AutoSize = true;
            this.radUniversitySuites.Location = new System.Drawing.Point(29, 101);
            this.radUniversitySuites.Name = "radUniversitySuites";
            this.radUniversitySuites.Size = new System.Drawing.Size(103, 17);
            this.radUniversitySuites.TabIndex = 3;
            this.radUniversitySuites.Text = "University Suites";
            this.radUniversitySuites.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radUnlimitedMeals);
            this.groupBox2.Controls.Add(this.rad14Meals);
            this.groupBox2.Controls.Add(this.rad7Meals);
            this.groupBox2.Location = new System.Drawing.Point(216, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 145);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Meal Plan";
            // 
            // radUnlimitedMeals
            // 
            this.radUnlimitedMeals.AutoSize = true;
            this.radUnlimitedMeals.Location = new System.Drawing.Point(29, 78);
            this.radUnlimitedMeals.Name = "radUnlimitedMeals";
            this.radUnlimitedMeals.Size = new System.Drawing.Size(98, 17);
            this.radUnlimitedMeals.TabIndex = 2;
            this.radUnlimitedMeals.Text = "Unlimited meals";
            this.radUnlimitedMeals.UseVisualStyleBackColor = true;
            // 
            // rad14Meals
            // 
            this.rad14Meals.AutoSize = true;
            this.rad14Meals.Location = new System.Drawing.Point(29, 55);
            this.rad14Meals.Name = "rad14Meals";
            this.rad14Meals.Size = new System.Drawing.Size(114, 17);
            this.rad14Meals.TabIndex = 1;
            this.rad14Meals.Text = "14 meals per week";
            this.rad14Meals.UseVisualStyleBackColor = true;
            // 
            // rad7Meals
            // 
            this.rad7Meals.AutoSize = true;
            this.rad7Meals.Checked = true;
            this.rad7Meals.Location = new System.Drawing.Point(29, 32);
            this.rad7Meals.Name = "rad7Meals";
            this.rad7Meals.Size = new System.Drawing.Size(108, 17);
            this.rad7Meals.TabIndex = 0;
            this.rad7Meals.TabStop = true;
            this.rad7Meals.Text = "7 meals per week";
            this.rad7Meals.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show Cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 295);
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
        private System.Windows.Forms.RadioButton radUniversitySuites;
        private System.Windows.Forms.RadioButton radFarthingHall;
        private System.Windows.Forms.RadioButton radPikeHall;
        private System.Windows.Forms.RadioButton radAllenHall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radUnlimitedMeals;
        private System.Windows.Forms.RadioButton rad14Meals;
        private System.Windows.Forms.RadioButton rad7Meals;
        private System.Windows.Forms.Button button1;
    }
}

