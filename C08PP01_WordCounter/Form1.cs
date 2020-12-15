using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace C08PP01_WordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCountWords_Click(object sender, EventArgs e)
        {
            string str = rtbInput.Text;
            int numOfWords = GetCountOfWords(str);
            double avgLetters = GetAvgNumOfLettersPerWord(str);
            lblDisplay.Text = $"There are {numOfWords} words with an average of {avgLetters:n2} letters.";

        }

        private static readonly char[] separators = { ' ', ',', ';', ':', '.', '!', '?' };

        private static readonly Regex nonWord = new Regex(@"\W+", RegexOptions.Compiled | RegexOptions.Multiline);

        public int GetCountOfWords(string input) => GetWords2(input).Length;

        public double GetAvgNumOfLettersPerWord (string input)
        {
            string[] words = GetWords2(input);
            double total = words.Sum(w => w.Length);
            return total / words.Length;
        }

        private static string[] GetWords(string input) => input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        private static string[] GetWords2(string input) => nonWord.Split(input);
    }
}
