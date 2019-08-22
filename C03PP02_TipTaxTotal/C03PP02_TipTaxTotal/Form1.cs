using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP02_TipTaxTotal
{
    public partial class Form1 : Form
    {
        private const decimal TIP_RATE = 0.15m;
        private const decimal TAX_RATE = 0.07m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //get meal price
            decimal subtotal = decimal.Parse(txtMealPrice.Text);

            //calculate tip, tax, and total
            decimal tip = subtotal * TIP_RATE;
            decimal tax = subtotal * TAX_RATE;
            decimal total = subtotal + tip + tax;

            //display all
            rtbDisplay.Text = $"Subtotal: {subtotal:c} \nTip: {tip:c} \nTax: {tax:c} \nTotal: {total:c}";
        }
    }
}
