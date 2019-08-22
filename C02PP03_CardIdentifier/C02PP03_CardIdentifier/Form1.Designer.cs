namespace C02PP03_CardIdentifier
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.picQueenH = new System.Windows.Forms.PictureBox();
            this.picKSpades = new System.Windows.Forms.PictureBox();
            this.picJokerRed = new System.Windows.Forms.PictureBox();
            this.picAHearts = new System.Windows.Forms.PictureBox();
            this.pic2Clubs = new System.Windows.Forms.PictureBox();
            this.pic8Diamonds = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQueenH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJokerRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2Clubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8Diamonds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a Card to See Its Name";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(116, 224);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(180, 23);
            this.lblDisplay.TabIndex = 6;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(168, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picQueenH
            // 
            this.picQueenH.Image = global::C02PP03_CardIdentifier.Properties.Resources.Queen_Hearts;
            this.picQueenH.Location = new System.Drawing.Point(364, 97);
            this.picQueenH.Name = "picQueenH";
            this.picQueenH.Size = new System.Drawing.Size(57, 77);
            this.picQueenH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQueenH.TabIndex = 8;
            this.picQueenH.TabStop = false;
            this.picQueenH.Click += new System.EventHandler(this.picQueenH_Click);
            // 
            // picKSpades
            // 
            this.picKSpades.Image = global::C02PP03_CardIdentifier.Properties.Resources.King_Spades;
            this.picKSpades.Location = new System.Drawing.Point(302, 75);
            this.picKSpades.Name = "picKSpades";
            this.picKSpades.Size = new System.Drawing.Size(56, 122);
            this.picKSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKSpades.TabIndex = 5;
            this.picKSpades.TabStop = false;
            this.picKSpades.Click += new System.EventHandler(this.picKSpades_Click);
            // 
            // picJokerRed
            // 
            this.picJokerRed.Image = global::C02PP03_CardIdentifier.Properties.Resources.Joker_Red;
            this.picJokerRed.Location = new System.Drawing.Point(240, 75);
            this.picJokerRed.Name = "picJokerRed";
            this.picJokerRed.Size = new System.Drawing.Size(56, 122);
            this.picJokerRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picJokerRed.TabIndex = 4;
            this.picJokerRed.TabStop = false;
            this.picJokerRed.Click += new System.EventHandler(this.picJokerRed_Click);
            // 
            // picAHearts
            // 
            this.picAHearts.Image = global::C02PP03_CardIdentifier.Properties.Resources.Ace_Hearts;
            this.picAHearts.Location = new System.Drawing.Point(178, 75);
            this.picAHearts.Name = "picAHearts";
            this.picAHearts.Size = new System.Drawing.Size(56, 122);
            this.picAHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAHearts.TabIndex = 3;
            this.picAHearts.TabStop = false;
            this.picAHearts.Click += new System.EventHandler(this.picAHearts_Click);
            // 
            // pic2Clubs
            // 
            this.pic2Clubs.Image = global::C02PP03_CardIdentifier.Properties.Resources._2_Clubs;
            this.pic2Clubs.Location = new System.Drawing.Point(116, 75);
            this.pic2Clubs.Name = "pic2Clubs";
            this.pic2Clubs.Size = new System.Drawing.Size(56, 122);
            this.pic2Clubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2Clubs.TabIndex = 2;
            this.pic2Clubs.TabStop = false;
            this.pic2Clubs.Click += new System.EventHandler(this.pic2Clubs_Click);
            // 
            // pic8Diamonds
            // 
            this.pic8Diamonds.Image = global::C02PP03_CardIdentifier.Properties.Resources._8_Diamonds;
            this.pic8Diamonds.Location = new System.Drawing.Point(54, 75);
            this.pic8Diamonds.Name = "pic8Diamonds";
            this.pic8Diamonds.Size = new System.Drawing.Size(56, 122);
            this.pic8Diamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic8Diamonds.TabIndex = 1;
            this.pic8Diamonds.TabStop = false;
            this.pic8Diamonds.Click += new System.EventHandler(this.pic8Diamonds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 404);
            this.Controls.Add(this.picQueenH);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.picKSpades);
            this.Controls.Add(this.picJokerRed);
            this.Controls.Add(this.picAHearts);
            this.Controls.Add(this.pic2Clubs);
            this.Controls.Add(this.pic8Diamonds);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picQueenH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJokerRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2Clubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8Diamonds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic8Diamonds;
        private System.Windows.Forms.PictureBox pic2Clubs;
        private System.Windows.Forms.PictureBox picAHearts;
        private System.Windows.Forms.PictureBox picJokerRed;
        private System.Windows.Forms.PictureBox picKSpades;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picQueenH;
    }
}

