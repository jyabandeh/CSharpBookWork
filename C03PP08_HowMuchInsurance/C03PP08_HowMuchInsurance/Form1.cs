using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP08_HowMuchInsurance
{
    public partial class Form1 : Form
    {
        private const decimal INSURANCE_PERCENTAGE = 0.8m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //get cost
            decimal cost = decimal.Parse(txtCost.Text);

            //calculate insurance
            decimal insurance = cost * INSURANCE_PERCENTAGE;

            //display
            lblDisplay.Text = insurance.ToString("c");
        }
    }
}
