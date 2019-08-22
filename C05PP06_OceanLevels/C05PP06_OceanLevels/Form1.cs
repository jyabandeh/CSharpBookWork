using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP06_OceanLevels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Year\tOcean Level");

            int year = 1;
            const double OCEAN_LEVEL_RISE_PER_YEAR = 1.5;
            double oceanLevelRise = 0;

            while (year <= 10)
            {
                oceanLevelRise += OCEAN_LEVEL_RISE_PER_YEAR;
                lstDisplay.Items.Add($"{year}\t+{oceanLevelRise:f1} millimeters");
                year++;
            }
        }
    }
}
