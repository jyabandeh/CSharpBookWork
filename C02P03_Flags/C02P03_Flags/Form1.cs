using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C02P03_Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picFinland_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Finland";
        }

        private void picFrance_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "France";
        }

        private void picGermany_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Germany";
        }
    }
}
