using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06PP07_PresentValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read values
                decimal futureValue = decimal.Parse(txtFutureValue.Text);
                double aPR = double.Parse(txtAPR.Text);
                aPR /= 100;
                double year = double.Parse(txtYear.Text);
                //call method
                decimal presentValue = PresentValue(futureValue, aPR, year);
                //display
                lblDisplay.Text = presentValue.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear and reset cursor
            txtFutureValue.Clear();
            txtAPR.Clear();
            txtYear.Clear();
            lblDisplay.ResetText();
            txtFutureValue.Focus();
        }
        //method to calculate present value
        public decimal PresentValue(decimal futureValue, double aPR, double years)
        {
            decimal presentValue = futureValue / (decimal) Math.Pow(1 + aPR, years);
            return presentValue;

        }
    }
}
