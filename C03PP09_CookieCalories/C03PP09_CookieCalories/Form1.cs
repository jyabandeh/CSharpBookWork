using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP09_CookieCalories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //get cookies
            int cookies = int.Parse(txtCookies.Text);

            //calc calories
            int calories = cookies * 30;

            //display
            lblDisplay.Text = calories.ToString("n0");
        }
    }
}
