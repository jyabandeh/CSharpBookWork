using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP03_SentenceCapitalizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapitalize_Click(object sender, EventArgs e)
        {
            string input = rtbInput.Text;
            string output = CapitalizeFirstLetterOfSentence(input);
            lblDisplay.Text = output;
        }

        private string CapitalizeFirstLetterOfSentence(string str)
        {
            string strTrimmed = str.Trim();
            StringBuilder sb = new StringBuilder(strTrimmed);
            sb[0] = char.ToUpper(sb[0]);
            for (int i = 1; i < sb.Length; i++)
            {
                if(sb[i] == '.' || sb[i] == '!' || sb[i] == '?')
                {
                    i++;
                    if (i < sb.Length)
                    {
                        while (char.IsWhiteSpace(sb[i]))
                        {
                            i++; //continue to advance the index until a non-whitespace char is found
                        }
                        sb[i] = char.ToUpper(sb[i]); //capitalize first non-whitespace char after ending punctuation
                    }
                }
            }
            return sb.ToString();
        }
    }
}
