using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP03_DistanceTravelled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn5Hours_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(txtSpeed.Text);
            int miles = speed * 5;
            lblDisplay.Text = $"{miles:n0} miles in 5 hours.";
        }

        private void btn8Hours_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(txtSpeed.Text);
            int miles = speed * 8;
            lblDisplay.Text = $"{miles:n0} miles in 8 hours.";
        }

        private void btn12Hours_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(txtSpeed.Text);
            int miles = speed * 12;
            lblDisplay.Text = $"{miles:n0} miles in 12 hours.";
        }
    }
}
