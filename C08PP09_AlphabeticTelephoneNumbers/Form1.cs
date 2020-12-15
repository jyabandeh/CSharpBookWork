using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP09_AlphabeticTelephoneNumbers
{
    public partial class Form1 : Form
    {
        public Dictionary<char[], int> letterNumberMap = new Dictionary<char[], int>()
        {
            { new char[] {'A', 'B', 'C' }, 2 },
            { new char[] {'D', 'E', 'F' }, 3 },
            { new char[] {'G', 'H', 'I' }, 4 },
            { new char[] {'J', 'K', 'L' }, 5 },
            { new char[] {'M', 'N', 'O' }, 6 },
            { new char[] {'P', 'Q', 'R', 'S' }, 7 },
            { new char[] {'T', 'U', 'V' }, 8 },
            { new char[] {'W', 'Y', 'X', 'Z' }, 9 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertToNumbers_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string output = ConvertToNumbers(input);
            lblDisplay.Text = output;
        }

        private string ConvertToNumbers(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (c == '-' || char.IsDigit(c))
                {
                    sb.Append(c);
                }
                else
                {                    
                    foreach (var kvp in letterNumberMap)
                    {
                        if (kvp.Key.Contains(char.ToUpper(c)))
                        {
                            sb.Append(kvp.Value);
                            break;
                        }
                    }                    
                }
            }
            return sb.ToString();
        }
    }
}
