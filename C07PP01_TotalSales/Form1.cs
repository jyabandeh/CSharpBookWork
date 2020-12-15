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

namespace C07PP01_TotalSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal[] totalSalesArray = GetSales();
            DisplaySalesArray(totalSalesArray);
            DisplayTotal(totalSalesArray);
            DisplayAverage(totalSalesArray);
            DisplayLargest(totalSalesArray);
            DisplaySmallest(totalSalesArray);
        }

        public decimal[] GetSales()
        {
            try
            {
                decimal[] salesArray = new decimal[7];

                string path = @"E:\C# Programming 1\student_sample_programs\student_sample_programs\Chap07\Sales.txt";
                StreamReader inputFile = File.OpenText(path);

                int i = 0;
                while (i < salesArray.Length && !inputFile.EndOfStream)
                {
                    salesArray[i] = decimal.Parse(inputFile.ReadLine());
                    i++;
                }

                inputFile.Close();

                return salesArray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void DisplaySalesArray(decimal[] array)
        {
            foreach (decimal item in array)
            {
                lstDisplay.Items.Add(item.ToString("c"));
            }
        }

        public void DisplayTotal(decimal[] array)
        {
            decimal total = 0;

            foreach (decimal item in array)
            {
                total += item;
            }

            lblTotal.Text = total.ToString("c");
        }

        public void DisplayAverage(decimal[] array)
        {
            decimal total = 0;
            decimal count = 0;

            foreach (decimal item in array)
            {
                total += item;
                count++;
            }

            if (count != 0)
            {
                lblAverage.Text = (total / count).ToString("c");
            }
            else
            {
                lblAverage.Text = "Divide by zero error";
            }
        }

        public void DisplayLargest(decimal[] array)
        {
            decimal largest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > largest)
                    largest = array[i];
            }
            lblLargest.Text = largest.ToString("c");
        }

        public void DisplaySmallest(decimal[] array)
        {
            decimal smallest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < smallest)
                    smallest = array[i];
            }
            lblSmallest.Text = smallest.ToString("c");
        }
    }
}
