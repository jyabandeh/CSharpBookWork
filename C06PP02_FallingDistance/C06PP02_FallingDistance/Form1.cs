using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06PP02_FallingDistance
{
    public partial class Form1 : Form
    {
        private const double GRAVITY_CONSTANT = 9.8;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //read user value
                double time = double.Parse(txtTime.Text);

                //call method to calc distance
                double distance = CalculateDistanceFallen(time);

                //display distance
                lblDisplay.Text = distance.ToString("n");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This method provides the formula to calculate distance given a time and the gravity acceleration constant
        private double CalculateDistanceFallen(double time)
        {
            double distance = 0.5 * GRAVITY_CONSTANT * time * time;
            return distance;
        }
    }
}
