using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06PP04CalroeiesFatCarbs
{
    public partial class Form1 : Form
    {
        public const double FAT_CALS_PER_GRAM = 9;
        public const double CARBS_CALS_PER_GRAM = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //read user input
            double fatGrams;
            double.TryParse(txtFatGrams.Text, out fatGrams);
            double carbGrams;
            double.TryParse(txtCarbGrams.Text, out carbGrams);

            //call get mehtods
            double fatCals = GetFatCalories(fatGrams);
            double carbCals = GetCarbCalories(carbGrams);

            //diplay results
            lblDisplay.Text = $"\nCalories from fat = {fatCals} \nCalories from carbs = {carbCals}";
        }

        //method to calculate calories from fat
        public double GetFatCalories(double fatGrams)
        {
            double fatCals = fatGrams * FAT_CALS_PER_GRAM;
            return fatCals;
        }

        //method to calculate calories from carbs
        public double GetCarbCalories(double carbGrams)
        {
            double carbCals = carbGrams * CARBS_CALS_PER_GRAM;
            return carbCals;
        }
    }
}
