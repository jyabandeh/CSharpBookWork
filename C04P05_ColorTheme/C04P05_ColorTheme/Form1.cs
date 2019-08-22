using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04P05_ColorTheme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (radYellow.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void radWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (radWhite.Checked)
            {
                this.BackColor = Color.White;
            }
        }

        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radNormal.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
