using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03P04_TestAverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcAverage_Click(object sender, EventArgs e)
        {
            try
            {
                //get test scores
                double test1 = double.Parse(txtTest1.Text);
                double test2 = double.Parse(txtTest2.Text);
                double test3 = double.Parse(txtTest3.Text);

                //compute average
                double average = (test1 + test2 + test3) / 3;

                //display
                lblDisplayAverage.Text = average.ToString("f1");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "";
            txtTest2.Text = "";
            txtTest3.Text = "";
            lblDisplayAverage.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
