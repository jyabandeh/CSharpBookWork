using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP08_BodyMassIndexEnhancement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight;
            double.TryParse(txtWeight.Text, out weight);
            double height;
            double.TryParse(txtHeight.Text, out height);
            double bmi = weight * 703 / (height * height);

            if (bmi < 18.5)
            {
                lblDisplay.Text = $"BMI = {bmi:f1}\nUnderweight";
            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                lblDisplay.Text = $"BMI = {bmi:f1}\nOptimal";
            }
            else
            {
                lblDisplay.Text = $"BMI = {bmi:f1}\nOverweight";
            }
        }
    }
}
