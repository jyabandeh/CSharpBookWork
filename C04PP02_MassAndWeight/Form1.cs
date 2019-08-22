using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP02_MassAndWeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateWeight_Click(object sender, EventArgs e)
        {
            try
            {
                //get mass
                double mass = double.Parse(txtMass.Text);

                //calculate weight
                double weight = mass * 9.8;

                //display weight
                lblWeight.Text = weight.ToString("f");

                //condiotnal based off of weight
                if (weight > 1000)
                {
                    lblMessage.Text = "TOO HEAVY";
                }
                if (weight < 10)
                {
                    lblMessage.Text = "TOO LIGHT";
                }
            }
            catch
            {
                MessageBox.Show("Please input a number");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMass.Text = "";
            lblWeight.Text = "";
            lblMessage.Text = "";
        }
    }
}
