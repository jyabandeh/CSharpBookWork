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

namespace C07PP06_NameSearch
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchNames_Click(object sender, EventArgs e)
        {
            //get boy and girls names in lists
            string boyNamesPath = @"E:\C# Programming 1\student_sample_programs\student_sample_programs\Chap07\BoyNames.txt";
            string girlNamesPath = @"E:\C# Programming 1\student_sample_programs\student_sample_programs\Chap07\GirlNames.txt";
            List<string> boyNames = GetNamesList(boyNamesPath);
            List<string> girlNames = GetNamesList(girlNamesPath);

            //read user input
            string boyName = txtBoyName.Text;
            string girlName = txtGirlName.Text;

            if(boyName != "")
            {
                if (boyNames.Contains(boyName))
                    lblBoyName.Text = $"{boyName} is a popular name";
                else
                    lblBoyName.Text = $"{boyName} is not a popular name";
            }
            if (girlName != "")
            {
                if (girlNames.Contains(girlName))
                    lblGirlName.Text = $"{girlName} is a popular name";
                else
                    lblGirlName.Text = $"{girlName} is not a popular name";
            }
        }

        //method to read names from a file
        public List<string> GetNamesList (string path)
        {
            StreamReader inputFile = File.OpenText(path);
            List<string> names = new List<string>();

            while (!inputFile.EndOfStream)
            {
                names.Add(inputFile.ReadLine());
            }

            inputFile.Close();
            return names;
        }
    }
}
