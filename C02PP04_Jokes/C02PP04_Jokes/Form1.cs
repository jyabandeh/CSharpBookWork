using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C02PP04_Jokes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            lblJoke.Text = "How many programmers does it take to change a lightbulb?";
            btnPunchLine.Visible = true;
            btnSetup.Visible = false;
        }

        private void btnPunchLine_Click(object sender, EventArgs e)
        {
            lblJoke.Text = "None. That's a hardware problem.";
            btnExit.Visible = true;
            btnPunchLine.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
