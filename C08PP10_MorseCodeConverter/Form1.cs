using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP10_MorseCodeConverter
{
    public partial class Form1 : Form
    {
        public Dictionary<char, string> morseCodeDict = new Dictionary<char, string>()
        {
            {' ', "space"},
            {',', "--..--"},
            {'.', ".-.-.-"},
            {'?', "..--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "---"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string input = rtbInput.Text;
            try
            {
                string output = ConvertToMorseCode(input);
                lblDisplay.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string ConvertToMorseCode(string str)
        {
            StringBuilder sb = new StringBuilder();
            str = str.Trim();
            str = str.ToUpper();
            foreach(char c in str)
            {
                sb.Append(morseCodeDict[c] + " ");
            }
            return sb.ToString();
        }
    }
}
