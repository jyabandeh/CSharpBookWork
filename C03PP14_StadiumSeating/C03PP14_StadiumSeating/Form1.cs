using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP14_StadiumSeating
{
    public partial class Form1 : Form
    {
        private const decimal CLASS_A_PRICE = 15;
        private const decimal CLASS_B_PRICE = 12;
        private const decimal CLASS_C_PRICE = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //get values
                int classATickets = int.Parse(txtClassA.Text);
                int classBTickets = int.Parse(txtClassB.Text);
                int classCTickets = int.Parse(txtClassC.Text);

                //do  calcs
                decimal classATotal = classATickets * CLASS_A_PRICE;
                decimal classBTotal = classBTickets * CLASS_B_PRICE;
                decimal classCTotal = classCTickets * CLASS_C_PRICE;
                decimal grandTotal = classATotal + classBTotal + classCTotal;

                //display
                lblClassA.Text = classATotal.ToString("c");
                lblClassB.Text = classBTotal.ToString("c");
                lblClassC.Text = classCTotal.ToString("c");
                lblTotal.Text = grandTotal.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassA.Text = "";
            txtClassB.Text = "";
            txtClassC.Text = "";
            lblClassA.Text = "";
            lblClassB.Text = "";
            lblClassC.Text = "";
            lblTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
