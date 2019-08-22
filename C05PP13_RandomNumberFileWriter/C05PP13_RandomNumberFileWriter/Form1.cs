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

namespace C05PP13_RandomNumberFileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                saveFileDialog1.InitialDirectory = @"E:\source\repos\BookWork\C05PP13_RandomNumberFileWriter\C05PP13_RandomNumberFileWriter\bin\Debug";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.CreateText(saveFileDialog1.FileName);
                    //outputFile = File.CreateText("Test.txt");

                    int num = int.Parse(txtNumber.Text);
                    Random rand = new Random();

                    for (int i = 1; i <= num; i++)
                    {
                        int randNum = rand.Next(1, 101);
                        outputFile.WriteLine(randNum);
                    }
                    outputFile.Close();

                    MessageBox.Show("File Saved");
                }
                else
                {
                    MessageBox.Show("Operation Cancelled");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
