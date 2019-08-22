using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP04_ColorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radFirstRed.Checked && radSecondRed.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (radFirstRed.Checked && radSecondBlue.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (radFirstRed.Checked && radSecondYellow.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (radFirstBlue.Checked && radSecondRed.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (radFirstBlue.Checked && radSecondBlue.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (radFirstBlue.Checked && radSecondYellow.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (radFirstYellow.Checked && radSecondRed.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (radFirstYellow.Checked && radSecondBlue.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (radFirstYellow.Checked && radSecondYellow.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("Please select two colors.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
