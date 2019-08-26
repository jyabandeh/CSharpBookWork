using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06PP01_RetailPriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //read user values
                decimal wholesale = decimal.Parse(txtWholesaleCost.Text);
                decimal markup = decimal.Parse(txtMarkup.Text);

                //call method to calc retail price
                decimal retail = CalculateRetailPrice(wholesale, markup);

                //display in label text box
                lblDisplay.Text = retail.ToString("c");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This method only provides the equation to calculate retail price
        //Values a parsed in the click event handler above
        private decimal CalculateRetailPrice(decimal wholesale, decimal markup)
        {
            decimal retail = wholesale + wholesale * (markup / 100m); //divide by 100 because user is expected to enter percentage value
            return retail;
        }
    }
}
