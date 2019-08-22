using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP13_PropertyTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //get value
            decimal value = decimal.Parse(txtPropertyValue.Text);

            //calculate
            decimal tax = value * 0.64m / 100;

            //display
            lblDisplay.Text = tax.ToString("c");
        }
    }
}
