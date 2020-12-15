using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C09PP06_DormAndMealPlanCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = GetDormCost() + GetMealPlanCost();
            TotalForm totalForm = new TotalForm();
            totalForm.lblDisplayTotal.Text = total.ToString("c");
            totalForm.ShowDialog();
        }

        private int GetDormCost()
        {
            if (radAllenHall.Checked)
            {
                return 1500;
            }
            else if(radPikeHall.Checked)
            {
                return 1600;
            }
            else if (radFarthingHall.Checked)
            {
                return 1800;
            }
            else //if radUniversitySuites is checked
            {
                return 2500;
            }
        }

        private int GetMealPlanCost()
        {
            if (rad7Meals.Checked)
            {
                return 600;
            }
            else if (rad14Meals.Checked)
            {
                return 1200;
            }
            else //if radUnlimitedMeals is checked
            {
                return 1700;
            }
        }
    }
}
