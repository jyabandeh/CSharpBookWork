using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C09PP01_PetClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatePet_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();

            Pet pet = new Pet();
            try
            {
                pet.Name = txtName.Text;
                pet.Type = txtType.Text;
                pet.Age = int.Parse(txtAge.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lstDisplay.Items.Add($"Name: {pet.Name}");
            lstDisplay.Items.Add($"Type: {pet.Type}");
            lstDisplay.Items.Add($"Age: {pet.Age}");
        }
    }
}
