using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP07_CaloriesBurned
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double minutes = 10;
            lstTable.Items.Add("Minutes \t Calories");
            while (minutes <= 30)
            {
                double calories = minutes * 3.9;
                lstTable.Items.Add($"{minutes} \t {calories}");
                minutes += 5;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstTable.Items.Clear();
        }
    }
}
