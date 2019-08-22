using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP03_CelsiusToFahrenheitTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double celsius = 0;
            lstTable.Items.Add("Celsius \t Fahrenheit");
            while(celsius <= 40)
            {
                double fahrenheit = (9d / 5d) * celsius + 32;
                lstTable.Items.Add($"{celsius} \t {fahrenheit:f1}");
                celsius++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstTable.Items.Clear();
        }
    }
}
