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

namespace C07PP07_PopulationData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //read population data from file into a List
            List<int> popList = ReadPopulationData();
            //calculate average annual change in pop
            double avg = CalcAveragePopChange(popList);
            listBox1.Items.Add($"Average Population Change: {avg:n0}");
            //find the year with the greatest change in pop
            int greatestYear = FindYearGreatestPopChange(popList);
            listBox1.Items.Add($"Year of Greatest Population Change: {greatestYear}");
            //find the year with the smallest change in pop            
            int leastYear = FindYearLeastPopChange(popList);
            listBox1.Items.Add($"Year of Least Population Change: {leastYear}");
        }

        //method to read population file
        public List<int> ReadPopulationData()
        {
            string path = @"E:\C# Programming 1\student_sample_programs\student_sample_programs\Chap07\USPopulation.txt";
            StreamReader inputFile = File.OpenText(path);
            List<int> popData = new List<int>();

            while (!inputFile.EndOfStream)
            {
                popData.Add(int.Parse(inputFile.ReadLine()));
            }

            inputFile.Close();
            return popData;
        }

        //method to calculate average population change
        public double CalcAveragePopChange(List<int> list)
        {
            double total = 0;

            for (int i = 0; i < list.Count -1; i++)
            {
                total += list[i + 1] - list[i];
            }

            return total / (list.Count - 1) * 1000;
        }

        //method to find the year with the greatest population change
        public int FindYearGreatestPopChange(List<int> list)
        {
            int greatest = list[1] - list[0];
            int year = 0;

            for (int i = 2; i < list.Count; i++)
            {
                if(list[i] - list[i-1] > greatest)
                {
                    greatest = list[i] - list[i - 1];
                    year = i + 1950;
                }                    
            }

            return year;
        }

        //method to find the year with the greatest population change
        public int FindYearLeastPopChange(List<int> list)
        {
            int least = list[1] - list[0];
            int year = 0;

            for (int i = 2; i < list.Count; i++)
            {
                if (list[i] - list[i - 1] < least)
                {
                    least = list[i] - list[i - 1];
                    year = i + 1950;
                }
            }

            return year;
        }
    }
}
