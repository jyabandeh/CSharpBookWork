using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP05_DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //check to make sure user has made two selections
            if (lstFrom.SelectedIndex != -1 && lstTo.SelectedIndex != -1)
            {
                //read inputs and declare output variable
                double distanceInput;
                double.TryParse(txtInput.Text, out distanceInput);
                string fromUnits = lstFrom.SelectedItem.ToString();
                string toUnits = lstTo.SelectedItem.ToString();
                double distanceOutput;
                //lblDisplayConverted.Text = fromUnits;

                //determine output
                if (fromUnits == toUnits)
                {
                    distanceOutput = distanceInput;
                    //lblDisplayConverted.Text = distanceOutput.ToString("f2");
                }
                else if (fromUnits == "Inches" && toUnits == "Feet")
                {
                    distanceOutput = distanceInput / 12d;
                    //lblDisplayConverted.Text = distanceOutput.ToString("f2");
                }
                else if (fromUnits == "Inches" && toUnits == "Yards")
                {
                    distanceOutput = distanceInput / 36d;
                    //lblDisplayConverted.Text = distanceOutput.ToString("f2");
                }
                else if (fromUnits == "Feet" && toUnits == "Inches")
                {
                    distanceOutput = distanceInput * 12d;
                    //lblDisplayConverted.Text = distanceOutput.ToString("f2");
                }
                else if (fromUnits == "Feet" && toUnits == "Yards")
                {
                    distanceOutput = distanceInput / 3d;
                    //lblDisplayConverted.Text = distanceOutput.ToString("f2");
                }
                else if (fromUnits == "Yards" && toUnits == "Inches")
                {
                    distanceOutput = distanceInput * 36d;
                    //lblDisplayConverted.Text = distanceOutput.ToString("f2");
                }
                else if (fromUnits == "Yards" && toUnits == "Feet")
                {
                    distanceOutput = distanceInput * 3d;
                    //lblDisplayConverted.Text = distanceOutput.ToString("f2");
                }
                else
                {
                    distanceOutput = distanceInput;
                }

                //display output
                lblDisplayConverted.Text = distanceOutput.ToString("f2");
                //this doesn't work for some reason
                //figured it out, kinda.... need to have an else statement (probably so that all possible outcomes for distanceOutput are covered
            }
            else
            {
                MessageBox.Show("Please select 'To' and 'From' units.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
