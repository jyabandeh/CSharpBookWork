using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP05_PenniesForPay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int days;
            int.TryParse(txtDays.Text, out days);
            decimal pay = 0.01m;
            decimal totalPay = 0m;

            for (int i = 1; i <= days; i++)
            {
                totalPay += pay;
                pay *= 2;
            }

            lblTotalPay.Text = totalPay.ToString("c");
        }
    }
}
