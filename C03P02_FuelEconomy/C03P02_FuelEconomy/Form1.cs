using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03P02_FuelEconomy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateMPG_Click(object sender, EventArgs e)
        {
            double miles = double.Parse(txtMiles.Text);
            double gallons = double.Parse(txtGallons.Text);
            double mpg = miles / gallons;
            lblMPG.Text = mpg.ToString("f");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
