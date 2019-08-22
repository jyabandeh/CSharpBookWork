using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP11_AutomobileCosts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //get values
            decimal loan = decimal.Parse(txtLoanPayment.Text);
            decimal insurance = decimal.Parse(txtInsurance.Text);
            decimal gas = decimal.Parse(txtGas.Text);
            decimal oil = decimal.Parse(txtOil.Text);
            decimal tires = decimal.Parse(txtTires.Text);
            decimal maintenance = decimal.Parse(txtMaintenance.Text);

            //calc monthly and annual expenses
            decimal monthly = loan + insurance + gas + oil + tires + maintenance;
            decimal annual = (loan + insurance + gas + oil + tires + maintenance) * 12;

            //display results
            rtbDisplay.Text = $"Monthly Expenses: {monthly:c}\nAnnual Expenses: {annual:c}";
        }
    }
}
