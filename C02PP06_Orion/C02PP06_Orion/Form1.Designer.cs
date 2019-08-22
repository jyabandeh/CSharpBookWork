namespace C02PP06_Orion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowNames = new System.Windows.Forms.Button();
            this.btnHideNames = new System.Windows.Forms.Button();
            this.lblBetelgeuse = new System.Windows.Forms.Label();
            this.lblAlnitak = new System.Windows.Forms.Label();
            this.lblSaiph = new System.Windows.Forms.Label();
            this.lblAlnilam = new System.Windows.Forms.Label();
            this.lblMintaka = new System.Windows.Forms.Label();
            this.lblMeissa = new System.Windows.Forms.Label();
            this.lblRigel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C02PP06_Orion.Properties.Resources.Orion;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnShowNames
            // 
            this.btnShowNames.Location = new System.Drawing.Point(111, 517);
            this.btnShowNames.Name = "btnShowNames";
            this.btnShowNames.Size = new System.Drawing.Size(75, 44);
            this.btnShowNames.TabIndex = 1;
            this.btnShowNames.Text = "Show Star Names";
            this.btnShowNames.UseVisualStyleBackColor = true;
            this.btnShowNames.Click += new System.EventHandler(this.btnShowNames_Click);
            // 
            // btnHideNames
            // 
            this.btnHideNames.Location = new System.Drawing.Point(238, 517);
            this.btnHideNames.Name = "btnHideNames";
            this.btnHideNames.Size = new System.Drawing.Size(75, 44);
            this.btnHideNames.TabIndex = 2;
            this.btnHideNames.Text = "Hide Star Names";
            this.btnHideNames.UseVisualStyleBackColor = true;
            this.btnHideNames.Click += new System.EventHandler(this.btnHideNames_Click);
            // 
            // lblBetelgeuse
            // 
            this.lblBetelgeuse.AutoSize = true;
            this.lblBetelgeuse.Location = new System.Drawing.Point(53, 39);
            this.lblBetelgeuse.Name = "lblBetelgeuse";
            this.lblBetelgeuse.Size = new System.Drawing.Size(60, 13);
            this.lblBetelgeuse.TabIndex = 3;
            this.lblBetelgeuse.Text = "Betelgeuse";
            this.lblBetelgeuse.Visible = false;
            // 
            // lblAlnitak
            // 
            this.lblAlnitak.AutoSize = true;
            this.lblAlnitak.Location = new System.Drawing.Point(83, 246);
            this.lblAlnitak.Name = "lblAlnitak";
            this.lblAlnitak.Size = new System.Drawing.Size(39, 13);
            this.lblAlnitak.TabIndex = 4;
            this.lblAlnitak.Text = "Alnitak";
            this.lblAlnitak.Visible = false;
            // 
            // lblSaiph
            // 
            this.lblSaiph.AutoSize = true;
            this.lblSaiph.Location = new System.Drawing.Point(98, 404);
            this.lblSaiph.Name = "lblSaiph";
            this.lblSaiph.Size = new System.Drawing.Size(34, 13);
            this.lblSaiph.TabIndex = 5;
            this.lblSaiph.Text = "Saiph";
            this.lblSaiph.Visible = false;
            // 
            // lblAlnilam
            // 
            this.lblAlnilam.AutoSize = true;
            this.lblAlnilam.Location = new System.Drawing.Point(156, 215);
            this.lblAlnilam.Name = "lblAlnilam";
            this.lblAlnilam.Size = new System.Drawing.Size(40, 13);
            this.lblAlnilam.TabIndex = 6;
            this.lblAlnilam.Text = "Alnilam";
            this.lblAlnilam.Visible = false;
            // 
            // lblMintaka
            // 
            this.lblMintaka.AutoSize = true;
            this.lblMintaka.Location = new System.Drawing.Point(253, 225);
            this.lblMintaka.Name = "lblMintaka";
            this.lblMintaka.Size = new System.Drawing.Size(45, 13);
            this.lblMintaka.TabIndex = 7;
            this.lblMintaka.Text = "Mintaka";
            this.lblMintaka.Visible = false;
            // 
            // lblMeissa
            // 
            this.lblMeissa.AutoSize = true;
            this.lblMeissa.Location = new System.Drawing.Point(285, 81);
            this.lblMeissa.Name = "lblMeissa";
            this.lblMeissa.Size = new System.Drawing.Size(40, 13);
            this.lblMeissa.TabIndex = 8;
            this.lblMeissa.Text = "Meissa";
            this.lblMeissa.Visible = false;
            // 
            // lblRigel
            // 
            this.lblRigel.AutoSize = true;
            this.lblRigel.Location = new System.Drawing.Point(282, 373);
            this.lblRigel.Name = "lblRigel";
            this.lblRigel.Size = new System.Drawing.Size(31, 13);
            this.lblRigel.TabIndex = 9;
            this.lblRigel.Text = "Rigel";
            this.lblRigel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 579);
            this.Controls.Add(this.lblRigel);
            this.Controls.Add(this.lblMeissa);
            this.Controls.Add(this.lblMintaka);
            this.Controls.Add(this.lblAlnilam);
            this.Controls.Add(this.lblSaiph);
            this.Controls.Add(this.lblAlnitak);
            this.Controls.Add(this.lblBetelgeuse);
            this.Controls.Add(this.btnHideNames);
            this.Controls.Add(this.btnShowNames);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowNames;
        private System.Windows.Forms.Button btnHideNames;
        private System.Windows.Forms.Label lblBetelgeuse;
        private System.Windows.Forms.Label lblAlnitak;
        private System.Windows.Forms.Label lblSaiph;
        private System.Windows.Forms.Label lblAlnilam;
        private System.Windows.Forms.Label lblMintaka;
        private System.Windows.Forms.Label lblMeissa;
        private System.Windows.Forms.Label lblRigel;
    }
}

