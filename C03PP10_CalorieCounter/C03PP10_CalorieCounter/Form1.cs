using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP10_CalorieCounter
{
    public partial class Form1 : Form
    {
        private int totalCalories = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void picBanana_Click(object sender, EventArgs e)
        {
            totalCalories += 115;
            lblCalories.Text = totalCalories.ToString();
        }

        private void picApple_Click(object sender, EventArgs e)
        {
            totalCalories += 80;
            lblCalories.Text = totalCalories.ToString();
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            totalCalories += 90;
            lblCalories.Text = totalCalories.ToString();
        }

        private void picPear_Click(object sender, EventArgs e)
        {
            totalCalories += 120;
            lblCalories.Text = totalCalories.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCalories.Text = "0";
            totalCalories = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
