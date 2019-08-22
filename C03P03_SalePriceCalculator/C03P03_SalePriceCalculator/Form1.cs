using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03P03_SalePriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateSalePrice_Click(object sender, EventArgs e)
        {
            decimal priceOriginal = decimal.Parse(txtPriceOriginal.Text);
            decimal discountPercentage = decimal.Parse(txtDiscountPercentage.Text);
            discountPercentage /= 100;

            decimal priceSale = priceOriginal - (priceOriginal * discountPercentage);

            lblPriceSale.Text = priceSale.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
