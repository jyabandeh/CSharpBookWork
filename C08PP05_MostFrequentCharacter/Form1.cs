using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP05_MostFrequentCharacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetMostFreqChar_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            string input = rtbInput.Text;
            char[] mostFreqChars = GetMostFreqChar(input);
            foreach (char c in mostFreqChars)
            {
                lstDisplay.Items.Add(c);
            }

        }

        private char[] GetMostFreqChar(string str)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!char.IsWhiteSpace(c))
                {
                    if (chars.ContainsKey(c))
                        chars[c]++;
                    else
                        chars.Add(c, 1);
                }
            }
            //str.GroupBy(x => x);
            int max = chars.Values.Max();
            return chars.Where(b => b.Value == max)
                        .Select(b => b.Key)
                        .ToArray();
        }
    }
}
