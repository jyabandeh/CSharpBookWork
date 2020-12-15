namespace C08PP11_VendingMachine
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
            this.picCola = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRootBeer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picRootBeer = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLemonLime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picLemonLime = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblGrapeSoda = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picGrapeSoda = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCreamSoda = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.picCreamSoda = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRootBeer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLemonLime)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrapeSoda)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreamSoda)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCola);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picCola);
            this.panel1.Location = new System.Drawing.Point(37, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 79);
            this.panel1.TabIndex = 0;
            // 
            // picCola
            // 
            this.picCola.Image = global::C08PP11_VendingMachine.Properties.Resources.Cola;
            this.picCola.Location = new System.Drawing.Point(4, 4);
            this.picCola.Name = "picCola";
            this.picCola.Size = new System.Drawing.Size(64, 64);
            this.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCola.TabIndex = 0;
            this.picCola.TabStop = false;
            this.picCola.Click += new System.EventHandler(this.picCola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "$1.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drinks Left:";
            // 
            // lblCola
            // 
            this.lblCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCola.Location = new System.Drawing.Point(93, 45);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(61, 23);
            this.lblCola.TabIndex = 3;
            this.lblCola.Text = "20";
            this.lblCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblRootBeer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.picRootBeer);
            this.panel2.Location = new System.Drawing.Point(215, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 79);
            this.panel2.TabIndex = 4;
            // 
            // lblRootBeer
            // 
            this.lblRootBeer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRootBeer.Location = new System.Drawing.Point(93, 45);
            this.lblRootBeer.Name = "lblRootBeer";
            this.lblRootBeer.Size = new System.Drawing.Size(61, 23);
            this.lblRootBeer.TabIndex = 3;
            this.lblRootBeer.Text = "20";
            this.lblRootBeer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Drinks Left:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "$1.00";
            // 
            // picRootBeer
            // 
            this.picRootBeer.Image = global::C08PP11_VendingMachine.Properties.Resources.RootBeer;
            this.picRootBeer.Location = new System.Drawing.Point(4, 4);
            this.picRootBeer.Name = "picRootBeer";
            this.picRootBeer.Size = new System.Drawing.Size(64, 64);
            this.picRootBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRootBeer.TabIndex = 0;
            this.picRootBeer.TabStop = false;
            this.picRootBeer.Click += new System.EventHandler(this.picRootBeer_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblLemonLime);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.picLemonLime);
            this.panel3.Location = new System.Drawing.Point(37, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 79);
            this.panel3.TabIndex = 5;
            // 
            // lblLemonLime
            // 
            this.lblLemonLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLemonLime.Location = new System.Drawing.Point(93, 45);
            this.lblLemonLime.Name = "lblLemonLime";
            this.lblLemonLime.Size = new System.Drawing.Size(61, 23);
            this.lblLemonLime.TabIndex = 3;
            this.lblLemonLime.Text = "20";
            this.lblLemonLime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Drinks Left:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "$1.00";
            // 
            // picLemonLime
            // 
            this.picLemonLime.Image = global::C08PP11_VendingMachine.Properties.Resources.LemonLime;
            this.picLemonLime.Location = new System.Drawing.Point(4, 4);
            this.picLemonLime.Name = "picLemonLime";
            this.picLemonLime.Size = new System.Drawing.Size(62, 64);
            this.picLemonLime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLemonLime.TabIndex = 0;
            this.picLemonLime.TabStop = false;
            this.picLemonLime.Click += new System.EventHandler(this.picLemonLime_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblGrapeSoda);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.picGrapeSoda);
            this.panel4.Location = new System.Drawing.Point(215, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 79);
            this.panel4.TabIndex = 4;
            // 
            // lblGrapeSoda
            // 
            this.lblGrapeSoda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrapeSoda.Location = new System.Drawing.Point(93, 45);
            this.lblGrapeSoda.Name = "lblGrapeSoda";
            this.lblGrapeSoda.Size = new System.Drawing.Size(61, 23);
            this.lblGrapeSoda.TabIndex = 3;
            this.lblGrapeSoda.Text = "20";
            this.lblGrapeSoda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Drinks Left:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(93, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "$1.00";
            // 
            // picGrapeSoda
            // 
            this.picGrapeSoda.Image = global::C08PP11_VendingMachine.Properties.Resources.GrapeSoda;
            this.picGrapeSoda.Location = new System.Drawing.Point(4, 4);
            this.picGrapeSoda.Name = "picGrapeSoda";
            this.picGrapeSoda.Size = new System.Drawing.Size(62, 64);
            this.picGrapeSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGrapeSoda.TabIndex = 0;
            this.picGrapeSoda.TabStop = false;
            this.picGrapeSoda.Click += new System.EventHandler(this.picGrapeSoda_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblCreamSoda);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.picCreamSoda);
            this.panel5.Location = new System.Drawing.Point(37, 231);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 79);
            this.panel5.TabIndex = 6;
            // 
            // lblCreamSoda
            // 
            this.lblCreamSoda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCreamSoda.Location = new System.Drawing.Point(93, 45);
            this.lblCreamSoda.Name = "lblCreamSoda";
            this.lblCreamSoda.Size = new System.Drawing.Size(61, 23);
            this.lblCreamSoda.TabIndex = 3;
            this.lblCreamSoda.Text = "20";
            this.lblCreamSoda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Drinks Left:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(93, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "$1.00";
            // 
            // picCreamSoda
            // 
            this.picCreamSoda.Image = global::C08PP11_VendingMachine.Properties.Resources.CreamSoda;
            this.picCreamSoda.Location = new System.Drawing.Point(4, 4);
            this.picCreamSoda.Name = "picCreamSoda";
            this.picCreamSoda.Size = new System.Drawing.Size(62, 64);
            this.picCreamSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCreamSoda.TabIndex = 0;
            this.picCreamSoda.TabStop = false;
            this.picCreamSoda.Click += new System.EventHandler(this.picCreamSoda_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblTotalSales);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Location = new System.Drawing.Point(215, 231);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(172, 79);
            this.panel6.TabIndex = 7;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSales.Location = new System.Drawing.Point(55, 45);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(61, 23);
            this.lblTotalSales.TabIndex = 3;
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Total Sales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select a Drink";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRootBeer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLemonLime)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrapeSoda)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreamSoda)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCola;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRootBeer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picRootBeer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLemonLime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picLemonLime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblGrapeSoda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picGrapeSoda;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCreamSoda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picCreamSoda;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
    }
}

