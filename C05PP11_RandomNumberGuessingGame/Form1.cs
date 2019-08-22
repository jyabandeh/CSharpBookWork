using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP11_RandomNumberGuessingGame
{
    public partial class Form1 : Form
    {
        int value;
        int counter = 0; //this counter is declared outside the button click event so that it does not reset with each button click

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //generate random number from 1 to 100
            Random rand = new Random();
            value = rand.Next(1, 101);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string message;
            //check user guess
            //read guess value
            int guess;
            int.TryParse(txtGuessNumber.Text, out guess);

            //compare it
            if(guess == value)
            {
                message = $"Correct! The number was {guess}! \nA new random number has been generated.";
                txtGuessNumber.Text = String.Empty;
                value = new Random().Next(1, 101);
                //READ THIS: update this program so that it resets the counter to 0 after a successful guess
            }
            else if (guess > value)
            {
                message = "Too high. Try Again!";
            }
            else
            {
                message = "Too low. Try Again!";
            }
            //increment guess counter
            counter++;

            //display outcome
            lblResult.Text = $"Number of Guesses: {counter}\n" + message;

            //generate new random number
        }
    }
}
