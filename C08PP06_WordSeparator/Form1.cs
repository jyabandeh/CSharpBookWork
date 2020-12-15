using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP06_WordSeparator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeparateWords_Click(object sender, EventArgs e)
        {
            string input = rtbInput.Text;
            string output = SepWordsByCaps(input);
            lblDisplay.Text = output;
        }

        private string SepWordsByCaps(string str)
        {
            StringBuilder sb = new StringBuilder(str);

            for (int i = 1; i < sb.Length; i++)
            {
                if (char.IsUpper(sb[i]))
                {
                    sb.Insert(i, ' ');
                    i++;
                }
            }
            return sb.ToString();
        }
    }
}
