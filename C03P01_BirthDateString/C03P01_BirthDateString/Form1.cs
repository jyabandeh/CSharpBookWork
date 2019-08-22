using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03P01_BirthDateString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            //input: get data
            string dayName = txtDayName.Text;
            string month = txtMonth.Text;
            string dayNum = txtDayNum.Text;
            string year = txtYear.Text;

            //process: concatenate data
            string birthDate = dayName + ", " + month + " " + dayNum + ", " + year;

            //output: show data
            lblBirthDate.Text = birthDate;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear TextBoxes and label box
            lblBirthDate.Text = "";
            txtDayName.Text = "";
            txtDayNum.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
