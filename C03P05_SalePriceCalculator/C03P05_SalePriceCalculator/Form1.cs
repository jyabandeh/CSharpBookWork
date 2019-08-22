using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03P05_SalePriceCalculator
{
    public partial class Form1 : Form
    {
        //constant fields
        private const decimal FIVE_CENTS_VALUE = 0.05m;
        private const decimal TEN_CENTS_VALUE = 0.10m;
        private const decimal TWENTYFIVE_CENTS_VALUE = 0.25m;
        private const decimal FIFTY_CENTS_VALUE = 0.50m;

        //field variable to hold the total
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void pic05cents_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS_VALUE;
            lblDisplayTotal.Text = total.ToString("c");
        }

        private void pic10cents_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS_VALUE;
            lblDisplayTotal.Text = total.ToString("c");

        }

        private void pic25cents_Click(object sender, EventArgs e)
        {
            total += TWENTYFIVE_CENTS_VALUE;
            lblDisplayTotal.Text = total.ToString("c");

        }

        private void pic50cents_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS_VALUE;
            lblDisplayTotal.Text = total.ToString("c");

        }
    }
}
