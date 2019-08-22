using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06PP03_KineticEnergy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateKineticEnergy_Click(object sender, EventArgs e)
        {
            //read user input
            double m;
            double.TryParse(txtMass.Text, out m);

            double v;
            double.TryParse(txtVelocity.Text, out v);

            //call method
            double ke = CalculateKineticEnergy(m, v);

            //display result
            lblKineticEnergy.Text = ke.ToString("f");

        }

        //method to calculate kinetic energy
        private double CalculateKineticEnergy(double mass, double velocity)
        {
            double kineticEnergy = mass * velocity * velocity / 2;
            return kineticEnergy;
        }
    }
}
