using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C02PP03_CardIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pic8Diamonds_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Eight of Diamonds";
        }

        private void pic2Clubs_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Two of Clubs";
        }

        private void picAHearts_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Ace of Hearts";
        }

        private void picJokerRed_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Red Joker";
        }

        private void picKSpades_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "King of Spades";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picQueenH_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Queen of Hearts";
        }
    }
}
