using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP07_SoftwareSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            try
            {
                //read quantity and declare disount
                int quantity = int.Parse(txtQuantity.Text);
                double discount = 0;

                //determine discount (conditional)
                if (quantity >= 10 && quantity < 20)
                {
                    discount = 0.2;
                }
                else if (quantity >= 20 && quantity < 50)
                {
                    discount = 0.3;
                }
                else if (quantity >= 50 && quantity < 100)
                {
                    discount = 0.4;
                }
                else if(quantity >= 100)
                {
                    discount = 0.5;
                }

                //calc subtotal, discount amount, tax, and total
                double subtotal = quantity * 99;
                double discountAmount = subtotal * discount;
                double tax = (subtotal - discountAmount) * 0.1;
                double total = subtotal - discountAmount + tax;

                //display subtotal, discount amount, tax, and total
                rtbDisplay.Text = $"Subtotal: {subtotal:c}\nDiscount: -{discountAmount:c}\nTax: {tax:c}\n\nTotal: {total:c}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
            rtbDisplay.Text = "";
        }
    }
}
