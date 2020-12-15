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

namespace C09PP07_EmailAddressBook
{
    public partial class MainForm : Form
    {
        List<PersonEntry> personEntries = new List<PersonEntry>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            DisplayNames();
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstNames.SelectedIndex;
            PersonForm personForm = new PersonForm();
            personForm.lblDisplay.Text = personEntries[i].ToString();
            personForm.ShowDialog();
        }

        private void ReadFile()
        {
            try
            {
                StreamReader inputFile = File.OpenText("PersonEntries.csv");
                //PersonEntry person = new PersonEntry();
                char[] delim = { ',' };
                while (!inputFile.EndOfStream)
                {
                    string[] tokens = inputFile.ReadLine().Split(delim);
                    PersonEntry person = new PersonEntry(tokens[0], tokens[1], tokens[2]);
                    //person.Name = tokens[0];
                    //person.Email = tokens[1];
                    //person.Phone = tokens[2];
                    personEntries.Add(person);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayNames()
        {
            foreach(PersonEntry person in personEntries)
            {
                lstNames.Items.Add(person.Name);
            }
        }
    }
}
