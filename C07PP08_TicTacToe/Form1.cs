using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C07PP08_TicTacToe
{
    public partial class Form1 : Form
    {
        public const int SIZE = 3;
        public char[] TicTac = { 'O', 'X' };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //create new array
            int[,] gameBoard = CreateTicTacToeArray();
            //write to labels
            Label[,] labels = { { lbl00, lbl01, lbl02 }, 
                                { lbl10, lbl11, lbl12 }, 
                                { lbl20, lbl21, lbl22 } };
            for(int i = 0; i < SIZE; i++)
            {
                for(int j = 0; j < SIZE; j++)
                {
                    labels[i, j].Text = TicTac[gameBoard[i, j]].ToString();
                }
            }

            //check for winners
            bool xWin = CheckForWin(gameBoard, 3);
            bool oWin = CheckForWin(gameBoard, 0);

            //display message
            DisplayGameResult(xWin, oWin, lblDisplay);
        }

        public int[,] CreateTicTacToeArray()
        {
            Random rand = new Random();
            int[,] array = new int[SIZE, SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                for(int j = 0; j < SIZE; j++)
                {
                    array[i, j] = rand.Next(2);
                }
            }

            return array;
        }

        //method to check for winners (use condition = 0 to check for O, use condition = 3 to check for X)
        public bool CheckForWin(int[,] array, int condition)
        {
            bool win = false;

            //check rows
            int row = 0;
            while (!win && row < SIZE)
            {
                int total = 0;
                for (int i = 0; i < SIZE; i++)
                {
                    total += array[row, i];
                }
                if (total == condition)
                {
                    win = true;
                }
                row++;
            }

            //check columns
            int col = 0;
            while (!win && col < SIZE)
            {
                int total = 0;
                for (int i = 0; i < SIZE; i++)
                {
                    total += array[i, col];
                }
                if (total == condition)
                {
                    win = true;
                }
                col++;
            }
            
            //check diagonals
            if (!win)
            {
                if (array[0,0] + array[1,1] + array[2,2] == condition || array[0,2] + array[1,1] + array[2,0] == condition)
                {
                    win = true;
                }
            }

            return win;
        }

        //method to display games results in label
        public void DisplayGameResult(bool xWin, bool oWin, Label label)
        {
            if (xWin && oWin)
                label.Text = "Tie Game!";

            else if (xWin && !oWin)
                label.Text = "X Wins!";

            else if (!xWin && oWin)
                label.Text = "O Wins!";

            else
                label.Text = "No Winner.";
        }
    }
}
