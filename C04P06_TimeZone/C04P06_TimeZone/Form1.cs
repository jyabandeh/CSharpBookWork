using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04P06_TimeZone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //declare string to hold city
            string city;

            //verify that a selection has been made and get selection
            if (lstCities.SelectedIndex != -1)
            {
                city = lstCities.SelectedItem.ToString();

                //display time zone
                switch (city)
                {
                    case "Honolulu":
                        lblTimeZone.Text = "Hawaii-Aleutian";
                        break;

                    case "San Francisco":
                        lblTimeZone.Text = "Pacific";
                        break;

                    case "Denver":
                        lblTimeZone.Text = "Mountain";
                        break;

                    case "Minneapolis":
                        lblTimeZone.Text = "Central";
                        break;

                    case "New York":
                        lblTimeZone.Text = "Eastern";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Select a city.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
