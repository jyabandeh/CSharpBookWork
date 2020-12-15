using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP07_PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertToPigLatin_Click(object sender, EventArgs e)
        {
            string input = rtbInput.Text;
            string output = ConvertToPigLatin(input);
            lblDisplay.Text = output;
        }

        private string ConvertToPigLatin(string str)
        {
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 1)
                {
                    words[i] = words[i].Insert(0, "AY");
                }
                else
                {
                    words[i] = words[i].Insert(words[i].Length, words[i][0].ToString());
                    words[i] = words[i].Remove(0, 1);
                    words[i] = words[i].Insert(words[i].Length, "AY");
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                sb.Append($"{word} ");
            }

            return sb.ToString();
        }
    }
}
