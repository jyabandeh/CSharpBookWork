using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP04_VowelsAndConsonants
{
    public partial class Form1 : Form
    {
        private readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCountVowelsConsonants_Click(object sender, EventArgs e)
        {
            string input = rtbInput.Text;
            int numOfVowels = GetNumOfVowels(input);
            int numOfConsonants = GetNumOfConsonants(input);
            lblDisplay.Text = $"{numOfVowels} vowels \n{numOfConsonants} consonants";
        }

        private int GetNumOfVowels(string str)
        {
            int numOfVowels = 0;
            foreach (char ch in str)
            {
                if (vowels.Contains(ch))
                {
                    numOfVowels++;
                }
            }
            return numOfVowels;
        }

        private int GetNumOfConsonants(string str)
        {
            int numOfLetters = 0;
            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    numOfLetters++;
                }
            }
            return numOfLetters - GetNumOfVowels(str);
        }

        private int GetNumOfConsonants(string str, int numOfVowels)
        {
            int numOfLetters = 0;
            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    numOfLetters++;
                }
            }
            return numOfLetters - numOfVowels;
        }
    }
}
