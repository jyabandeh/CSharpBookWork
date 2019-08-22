namespace C03P03_SalePriceCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPriceSale = new System.Windows.Forms.Label();
            this.btnCalculateSalePrice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPriceOriginal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the item\'s original price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the discount percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sale price:";
            // 
            // lblPriceSale
            // 
            this.lblPriceSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPriceSale.Location = new System.Drawing.Point(183, 110);
            this.lblPriceSale.Name = "lblPriceSale";
            this.lblPriceSale.Size = new System.Drawing.Size(100, 23);
            this.lblPriceSale.TabIndex = 3;
            // 
            // btnCalculateSalePrice
            // 
            this.btnCalculateSalePrice.Location = new System.Drawing.Point(78, 177);
            this.btnCalculateSalePrice.Name = "btnCalculateSalePrice";
            this.btnCalculateSalePrice.Size = new System.Drawing.Size(75, 38);
            this.btnCalculateSalePrice.TabIndex = 4;
            this.btnCalculateSalePrice.Text = "Calculate Sale Price";
            this.btnCalculateSalePrice.UseVisualStyleBackColor = true;
            this.btnCalculateSalePrice.Click += new System.EventHandler(this.btnCalculateSalePrice_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(159, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPriceOriginal
            // 
            this.txtPriceOriginal.Location = new System.Drawing.Point(183, 33);
            this.txtPriceOriginal.Name = "txtPriceOriginal";
            this.txtPriceOriginal.Size = new System.Drawing.Size(100, 20);
            this.txtPriceOriginal.TabIndex = 6;
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.Location = new System.Drawing.Point(183, 60);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountPercentage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 238);
            this.Controls.Add(this.txtDiscountPercentage);
            this.Controls.Add(this.txtPriceOriginal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateSalePrice);
            this.Controls.Add(this.lblPriceSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPriceSale;
        private System.Windows.Forms.Button btnCalculateSalePrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPriceOriginal;
        private System.Windows.Forms.TextBox txtDiscountPercentage;
    }
}

