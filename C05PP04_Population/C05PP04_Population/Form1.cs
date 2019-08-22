using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP04_Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double population, increasePercent, increaseRate, days;
            double.TryParse(txtStartingNumber.Text, out population);
            double.TryParse(txtIncreaseRate.Text, out increasePercent);
            double.TryParse(txtDays.Text, out days);
            increaseRate = increasePercent / 100 + 1;

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Day\tPopulation");

            for (double i = 1; i <= days; i++)
            {
                lstDisplay.Items.Add($"{i}\t{population:f}");
                population *= increaseRate;
            }

            lstDisplay.TopIndex = lstDisplay.Items.Count - 1;
        }
    }
}
