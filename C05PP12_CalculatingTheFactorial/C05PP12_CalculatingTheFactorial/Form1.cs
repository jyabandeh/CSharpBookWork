using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP12_CalculatingTheFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ulong num;
            ulong.TryParse(txtNumber.Text, out num);
            ulong result = 1;

            if (num == 0)
            {
                lblResult.Text = result.ToString();
            }
            else
            {
                for (ulong i = num; i >= 1; i--)
                {
                    result *= i;
                }

                lblResult.Text = result.ToString("n0");
            }

        }
    }
}
