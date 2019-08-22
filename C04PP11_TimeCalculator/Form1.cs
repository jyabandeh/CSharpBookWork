using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP11_TimeCalculator
{
    public partial class Form1 : Form
    {
        private const double SECONDS_IN_DAY = 86400;
        private const double SECONDS_IN_HOUR = 3600;
        private const double SECONDS_IN_MINUTE = 60;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double output;
            double seconds;
            double.TryParse(txtSeconds.Text, out seconds);

            if (seconds < 0)
            {
                MessageBox.Show("Number of seconds cannot be negative.");
            }
            else if (seconds < SECONDS_IN_MINUTE)
            {
                lblDisplay.Text = $"{seconds} second(s)";
            }
            else if (seconds < SECONDS_IN_HOUR)
            {
                double minutes = seconds / SECONDS_IN_MINUTE;
                lblDisplay.Text = $"{minutes:n1} minute(s)";
            }
            else if (seconds < SECONDS_IN_DAY)
            {
                double hours = seconds / SECONDS_IN_HOUR;
                lblDisplay.Text = $"{hours:n1} hour(s)";
            }
            else
            {
                double days = seconds / SECONDS_IN_DAY;
                lblDisplay.Text = $"{days:n1} day(s)";
            }
        }
    }
}
