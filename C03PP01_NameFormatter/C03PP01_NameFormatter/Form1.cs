using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP01_NameFormatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnFormat1_Click(object sender, EventArgs e)
        {
            //get user inputs
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            string title = txtTitle.Text;

            //concatenate and display
            lblDisplayName.Text = $"{title} {firstName} {middleName} {lastName}";
        }

        private void btnFormat2_Click(object sender, EventArgs e)
        {
            //get user inputs
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            string title = txtTitle.Text;

            //concatenate and display
            lblDisplayName.Text = $"{firstName} {middleName} {lastName}";
        }

        private void btnFormat3_Click(object sender, EventArgs e)
        {
            //get user inputs
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            string title = txtTitle.Text;

            //concatenate and display
            lblDisplayName.Text = $"{firstName} {lastName}";

        }

        private void btnFormat4_Click(object sender, EventArgs e)
        {
            //get user inputs
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            string title = txtTitle.Text;

            //concatenate and display
            lblDisplayName.Text = $"{lastName}, {firstName} {middleName}, {title}";

        }

        private void btnFormat5_Click(object sender, EventArgs e)
        {
            //get user inputs
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            string title = txtTitle.Text;

            //concatenate and display
            lblDisplayName.Text = $"{lastName}, {firstName} {middleName}";

        }

        private void btnFormat6_Click(object sender, EventArgs e)
        {
            //get user inputs
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            string title = txtTitle.Text;

            //concatenate and display
            lblDisplayName.Text = $"{lastName}, {firstName}";

        }
    }
}
