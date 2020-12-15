namespace C06PP10_RockPaperScissors
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.picPlayerRock = new System.Windows.Forms.PictureBox();
            this.picPlayerPaper = new System.Windows.Forms.PictureBox();
            this.picPlayerScissors = new System.Windows.Forms.PictureBox();
            this.picCompRock = new System.Windows.Forms.PictureBox();
            this.picCompPaper = new System.Windows.Forms.PictureBox();
            this.picCompScissors = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picCompRock);
            this.panel1.Controls.Add(this.picCompPaper);
            this.panel1.Controls.Add(this.picCompScissors);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 96);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.picPlayerRock);
            this.panel2.Controls.Add(this.picPlayerPaper);
            this.panel2.Controls.Add(this.picPlayerScissors);
            this.panel2.Location = new System.Drawing.Point(187, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 96);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Computer Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Your Selection";
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(289, 74);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 11;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(289, 103);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 12;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(289, 130);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 23);
            this.btnScissors.TabIndex = 13;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 164);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(271, 98);
            this.lblDisplay.TabIndex = 14;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(289, 186);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // picPlayerRock
            // 
            this.picPlayerRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayerRock.Image = global::C06PP10_RockPaperScissors.Properties.Resources.Rock;
            this.picPlayerRock.Location = new System.Drawing.Point(16, 14);
            this.picPlayerRock.Name = "picPlayerRock";
            this.picPlayerRock.Size = new System.Drawing.Size(66, 66);
            this.picPlayerRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayerRock.TabIndex = 4;
            this.picPlayerRock.TabStop = false;
            this.picPlayerRock.Visible = false;
            // 
            // picPlayerPaper
            // 
            this.picPlayerPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayerPaper.Image = global::C06PP10_RockPaperScissors.Properties.Resources.Paper;
            this.picPlayerPaper.Location = new System.Drawing.Point(16, 14);
            this.picPlayerPaper.Name = "picPlayerPaper";
            this.picPlayerPaper.Size = new System.Drawing.Size(66, 66);
            this.picPlayerPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayerPaper.TabIndex = 5;
            this.picPlayerPaper.TabStop = false;
            this.picPlayerPaper.Visible = false;
            // 
            // picPlayerScissors
            // 
            this.picPlayerScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayerScissors.Image = global::C06PP10_RockPaperScissors.Properties.Resources.Scissors;
            this.picPlayerScissors.Location = new System.Drawing.Point(16, 14);
            this.picPlayerScissors.Name = "picPlayerScissors";
            this.picPlayerScissors.Size = new System.Drawing.Size(66, 66);
            this.picPlayerScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayerScissors.TabIndex = 6;
            this.picPlayerScissors.TabStop = false;
            this.picPlayerScissors.Visible = false;
            // 
            // picCompRock
            // 
            this.picCompRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCompRock.Image = global::C06PP10_RockPaperScissors.Properties.Resources.Rock;
            this.picCompRock.Location = new System.Drawing.Point(15, 14);
            this.picCompRock.Name = "picCompRock";
            this.picCompRock.Size = new System.Drawing.Size(66, 66);
            this.picCompRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCompRock.TabIndex = 0;
            this.picCompRock.TabStop = false;
            this.picCompRock.Visible = false;
            // 
            // picCompPaper
            // 
            this.picCompPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCompPaper.Image = global::C06PP10_RockPaperScissors.Properties.Resources.Paper;
            this.picCompPaper.Location = new System.Drawing.Point(15, 14);
            this.picCompPaper.Name = "picCompPaper";
            this.picCompPaper.Size = new System.Drawing.Size(66, 66);
            this.picCompPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCompPaper.TabIndex = 2;
            this.picCompPaper.TabStop = false;
            this.picCompPaper.Visible = false;
            // 
            // picCompScissors
            // 
            this.picCompScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCompScissors.Image = global::C06PP10_RockPaperScissors.Properties.Resources.Scissors;
            this.picCompScissors.Location = new System.Drawing.Point(15, 14);
            this.picCompScissors.Name = "picCompScissors";
            this.picCompScissors.Size = new System.Drawing.Size(66, 66);
            this.picCompScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCompScissors.TabIndex = 3;
            this.picCompScissors.TabStop = false;
            this.picCompScissors.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(289, 215);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 314);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCompRock;
        private System.Windows.Forms.PictureBox picCompPaper;
        private System.Windows.Forms.PictureBox picCompScissors;
        private System.Windows.Forms.PictureBox picPlayerScissors;
        private System.Windows.Forms.PictureBox picPlayerPaper;
        private System.Windows.Forms.PictureBox picPlayerRock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnReset;
    }
}

