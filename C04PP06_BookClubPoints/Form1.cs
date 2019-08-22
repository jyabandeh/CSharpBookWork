using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP06_BookClubPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //read books purchased and declare points variable
            ushort books = 0;
            ushort points;

            //determine number of points
            if(ushort.TryParse(txtBooksPurchased.Text, out books))
            {
                switch (books)
                {
                    case 0:
                        points = 0;
                        break;

                    case 1:
                        points = 5;
                        break;

                    case 2:
                        points = 15;
                        break;

                    case 3:
                        points = 30;
                        break;

                    default:
                        points = 60;
                        break;
                }
                //display result and return focus
                lblDisplayPoints.Text = points.ToString();
                txtBooksPurchased.Focus();
            }
            else
            {
                MessageBox.Show("Please input a whole number.");
            }

        }

        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            //Get a city name from user:
            string city = txtCity.Text;
            string output;

            //accept only Seattle, Portland, Dallas, Miami, New York
            //find out population and time zone
            //use a switch to find out what the user entered and display the appropriate info
            switch (city)
            {
                case "Seattle":
                    output = "Population: 1,000,000 \nTime Zone: PST";
                    break;

                case "Portland":
                    output = "Population: 750,000 \nTime Zone: PST";
                    break;

                case "Dallas":
                    output = "Population: 5,000,000 \nTime Zone: CST";
                    break;

                case "Miami":
                    output = "Population: 6,000,000 \nTime Zone: EST";
                    break;

                case "New York":
                    output = "Population: 10,000,000 \nTime Zone: EST";
                    break;

                default:
                    output = "Please enter one of the following cities: \nSeattle \nPortland \nDallas" +
                        "\nMiami \nNew York";
                    break;

            }
            lblResult.Text = output;
            lblResult.Focus();
        }
    }
}
