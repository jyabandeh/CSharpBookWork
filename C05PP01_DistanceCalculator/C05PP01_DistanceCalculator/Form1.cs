using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C05PP01_DistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double speed, hours, distance;
            double.TryParse(txtSpeed.Text, out speed);
            double.TryParse(txtHours.Text, out hours);

            lstDisplay.Items.Clear();

            //the running total distance is calculated and displayed after each whole hour, the final total distance is handled outside the loop
            for (double i = 1; i < hours; i++)
            {
                distance = speed * i;
                lstDisplay.Items.Add($"After hour {i:f0} the distance is {distance:n1} miles");
            }

            //calculate the total distance and display, this deals with situations where user enters non whole number for hours
            double finalDistance = speed * hours;
            lstDisplay.Items.Add($"After hour {hours} the distance is {finalDistance:n1} miles");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToFile_Click(object sender, EventArgs e)
        {
            try
            {


                double speed, hours, distance;
                double.TryParse(txtSpeed.Text, out speed);
                double.TryParse(txtHours.Text, out hours);

                StreamWriter outputFile;
                outputFile = File.CreateText("Distance.txt");

                for (double i = 1; i < hours; i++)
                {
                    distance = speed * i;
                    //lstDisplay.Items.Add($"After hour {i:f0} the distance is {distance:n1} miles");
                    outputFile.WriteLine($"After hour {i:f0} the distance is {distance:n1} miles");
                }

                double finalDistance = speed * hours;
                outputFile.WriteLine($"After hour {hours} the distance is {finalDistance:n1} miles");
                outputFile.Close();
                MessageBox.Show("The data was written to the file.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
