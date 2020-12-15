using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06PP10_RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int playerSelection = 0;
        int computerSelection = 0;

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayerRock.Visible = true;
            picPlayerPaper.Visible = false;
            picPlayerScissors.Visible = false;
            btnPlay.Visible = true;
            playerSelection = 1;
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayerRock.Visible = false;
            picPlayerPaper.Visible = true;
            picPlayerScissors.Visible = false;
            btnPlay.Visible = true;
            playerSelection = 2;
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picPlayerRock.Visible = false;
            picPlayerPaper.Visible = false;
            picPlayerScissors.Visible = true;
            btnPlay.Visible = true;
            playerSelection = 3;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnRock.Visible = false;
            btnPaper.Visible = false;
            btnScissors.Visible = false;
            btnPlay.Visible = false;
            btnReset.Visible = true;
            //computer makes a random selection (1, 2, or 3)
            Random rand = new Random();
            int computerSelection = rand.Next(1, 4);
            //computerSelection determines image shown
            switch (computerSelection)
            {
                case 1:
                    picCompRock.Visible = true;
                    break;
                case 2:
                    picCompPaper.Visible = true;
                    break;
                case 3:
                    picCompScissors.Visible = true;
                    break;
            }
            //compare computerSelection to playerSelection to determine outcome
            if(IsTieGame(playerSelection, computerSelection))
            {
                lblDisplay.Text = "Tie game.";
            }
            else
            {
                lblDisplay.Text = $"{DisplayFlavorText(playerSelection, computerSelection)}" +
                    $"\n{DisplayOutcome(playerSelection, computerSelection)}";
            }

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnRock.Visible = true;
            btnPaper.Visible = true;
            btnScissors.Visible = true;
            picPlayerRock.Visible = false;
            picPlayerPaper.Visible = false;
            picPlayerScissors.Visible = false;
            picCompRock.Visible = false;
            picCompPaper.Visible = false;
            picCompScissors.Visible = false;
            btnPlay.Visible = false;
            btnReset.Visible = false;
            playerSelection = 0;
            lblDisplay.ResetText();

        }

        //method to check for a tie
        public static bool IsTieGame(int a, int b)
        {
            if (a == b)
                return true;
            else
                return false;
        }
        //method to determine if player wins
        public static string DisplayOutcome(int player, int computer)
        {
            if (computer + 1 == player || computer - 2 == player)
                return "You win!";
            else
                return "You lose....";
        }
        public static string DisplayFlavorText(int a, int b)
        {
            switch (a + b)
            {
                case 3:
                    return "Paper covers rock.";
                case 4:
                    return "Rock breaks scissors.";
                case 5:
                    return "Scissors cuts paper.";
                default:
                    return "WTF?";
            }
        }
    }
}
