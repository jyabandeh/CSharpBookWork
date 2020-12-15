using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C09PP03_PersonalInfoClass
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person();
                GetPersonData(person);
                people.Add(person);
                lstNames.Items.Add(person.Name);

                txtName.Clear();
                txtAddress.Clear();
                txtAge.Clear();
                txtAge.Clear();
                txtAge.Clear();
                txtPhone.Clear();
            }
            catch(Exception ex)
            {

            }
            
        }

        private void GetPersonData(Person person)
        {
            int age;
            if (int.TryParse(txtAge.Text, out age))
            {
                person.Age = age;
                person.Name = txtName.Text;
                person.Address = txtAddress.Text;
                person.PhoneNumber = txtPhone.Text;
            }
            else
            {
                MessageBox.Show("Invalid age");
                throw new Exception();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
            people.Clear();
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstNames.SelectedIndex;
            MessageBox.Show(people[i].ToString());
        }
    }
}
