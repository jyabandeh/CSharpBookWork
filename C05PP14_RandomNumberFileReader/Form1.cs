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

namespace C05PP14_RandomNumberFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadCalc_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = null;
            openFileDialog1.InitialDirectory = @"E:\source\repos\BookWork\C05PP13_RandomNumberFileWriter\C05PP13_RandomNumberFileWriter\bin\Debug";

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog1.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        //finish this loop
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (inputFile != null)
                {
                    inputFile.Close();
                }
            }
        }
    }
}
