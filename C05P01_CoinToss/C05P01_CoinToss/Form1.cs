using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05P01_CoinToss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            int sideup; //variable to indicate which side is up
            Random rand = new Random();

            //0 means tails, 1 means heads
            sideup = rand.Next(2);

            if (sideup == 0)
            {
                picTails.Visible = true;
                picHeads.Visible = false;
            }
            else
            {
                picTails.Visible = false;
                picHeads.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
