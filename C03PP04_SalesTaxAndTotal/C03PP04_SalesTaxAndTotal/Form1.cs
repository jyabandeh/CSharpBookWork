using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP04_SalesTaxAndTotal
{
    public partial class Form1 : Form
    {
        private const decimal STATE_TAX_RATE = 0.04m;
        private const decimal COUNTY_TAX_RATE = 0.02m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //get purchase amount
                decimal purchaseAmount = decimal.Parse(txtPurchaseAmount.Text);

                //calc taxes and grand total
                decimal stateTax = purchaseAmount * STATE_TAX_RATE;
                decimal countyTax = purchaseAmount * COUNTY_TAX_RATE;
                decimal totalTax = stateTax + countyTax;
                decimal grandTotal = purchaseAmount + totalTax;

                //display all
                rtbDisplay.Text = $"Subtotal: {purchaseAmount:c} \nState Tax: {stateTax:c} \nCounty Tax: {countyTax:c} " +
                    $"\nTotal Taxes: {totalTax:c} \nGrand Total: {grandTotal:c}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
