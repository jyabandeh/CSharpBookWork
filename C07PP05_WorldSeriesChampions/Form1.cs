using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C07PP05_WorldSeriesChampions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayTeams();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //get list of world series winners
            List<string> winners = GetWinners();
            //get user team selection (check that user has made a selection)
            if(listBox1.SelectedIndex != -1)
            {
                string selection = (string)listBox1.SelectedItem;
                //find number of wins
                int wins = GetNumberOfWins(selection, winners);
                //display result
                if(wins > 1)
                {
                    lblDisplay.Text = $"The {selection} have {wins} World Series wins";
                }
                else
                {
                    lblDisplay.Text = $"The {selection} have {wins} World Series win";
                }
            }
            else
            {
                MessageBox.Show("Select a team");
            }
        }
        
        //method to display teams
        public void DisplayTeams()
        {
            string path = @"E:\C# Programming 1\student_sample_programs\student_sample_programs\Chap07\Teams.txt";
            StreamReader inputFile = File.OpenText(path);

            while (!inputFile.EndOfStream)
            {
                listBox1.Items.Add(inputFile.ReadLine());
            }

            inputFile.Close();
        }

        //method to read World Series winners into a list
        public List<string> GetWinners()
        {
            string path = @"E:\C# Programming 1\student_sample_programs\student_sample_programs\Chap07\WorldSeriesWinners.txt";
            StreamReader inputFile = File.OpenText(path);
            List<string> winners = new List<string>();

            while (!inputFile.EndOfStream)
            {
                winners.Add(inputFile.ReadLine());
            }

            inputFile.Close();
            return winners;            
        }

        //method to get total number of wins for a team
        public int GetNumberOfWins(string team, List<string> winners)
        {
            int wins = 0;
            foreach(string winner in winners)
            {
                if (winner == team)
                    wins++;
            }
            return wins;
        }
    }
}
