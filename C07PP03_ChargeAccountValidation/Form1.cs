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

namespace C07PP03_ChargeAccountValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckValid_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> accounts = GetValidAccounts();
            DisplayList(accounts);
            //read user input
            int sv = GetSearchValue();
            //check if search value exists in accounts list
            int index = accounts.IndexOf(sv);
            if(index == -1)
            {
                lblDisplay.Text = $"{sv} is not a valid account.";
            }
            else
            {
                lblDisplay.Text = $"Account {sv} is valid and found at index {index}";
            }
        }

        //method to read valid accounts from file
        public List<int> GetValidAccounts()
        {
            try
            {
                List<int> accounts = new List<int>();

                string path = "E:\\C# Programming 1\\student_sample_programs\\student_sample_programs\\Chap07\\ChargeAccounts.txt";
                StreamReader inputFile = File.OpenText(path);

                while (!inputFile.EndOfStream)
                {
                    accounts.Add(int.Parse(inputFile.ReadLine()));
                }

                inputFile.Close();
                return accounts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //method to display a list (to check if GetValidAccounts is successful)
        public void DisplayList(List<int> list)
        {
            foreach(int num in list)
            {
                listBox1.Items.Add(num);
            }
        }

        //method to read the input from user
        public int GetSearchValue()
        {
            try
            {
                int sv = int.Parse(txtAccountNum.Text);
                return sv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //method to search a list (don't need because we can just use the .IndexOf method
        //public int SearchIntList(List<int> list, int sv)
        //{
        //    bool found = false;
        //    int index = 0;
        //    int position = -1;

        //    while (!found && index < list.Count)
        //    {
        //        if(list[index] == sv)
        //        {
        //            found = true;
        //            position = index;
        //        }
        //    }

        //    return position;
        //}
    }
}
