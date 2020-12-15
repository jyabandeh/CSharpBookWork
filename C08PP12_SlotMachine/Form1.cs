using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP12_SlotMachine
{
    public partial class Form1 : Form
    {
        decimal totalBet = 0;
        decimal totalWin = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            int[] rands = GetRands();
            SetImages(rands);
            DetermineWinnings(rands);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total bet: {totalBet:c} \nTotal won: {totalWin:c}");
            this.Close();
        }

        public int[] GetRands()
        {
            Random rand = new Random();
            int[] rands = new int[3];
            for (int i = 0; i < rands.Length; i++)
            {
                rands[i] = rand.Next(0, 10);
            }
            return rands;
        }

        public void SetImages(int[] rands)
        {            
            picBox1.Image = imgListFruits.Images[rands[0]];
            picBox2.Image = imgListFruits.Images[rands[1]];
            picBox3.Image = imgListFruits.Images[rands[2]];
        }

        public void DetermineWinnings(int[] rands)
        {
            try
            {
                decimal bet = decimal.Parse(txtBet.Text);
                totalBet += bet;
                decimal win = 0;
                if (rands[0] == rands[1] && rands[1] == rands[2])
                {
                    win = bet * 3;
                    totalWin += win;
                    MessageBox.Show($"Congrats! You won {win:c}");
                }
                else if (rands[0] == rands[1] || rands[1] == rands[2] || rands[0] == rands[2])
                {
                    win = bet * 2;
                    totalWin += win;
                    MessageBox.Show($"Congrats! You won {win:c}");
                }
                else
                {
                    MessageBox.Show($"You won {win:c}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
