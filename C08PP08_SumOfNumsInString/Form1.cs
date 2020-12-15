using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP08_SumOfNumsInString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            string input = rtbInput.Text;
            int total = CalcSum(input);
            lblDisplay.Text = $"Total = {total}";
        }
        
        private int CalcSum(string str)
        {
            try
            {


                char[] delims = { ',' };
                string[] nums = str.Split(delims, StringSplitOptions.RemoveEmptyEntries);
                int total = 0;
                foreach (string num in nums)
                {
                    total += int.Parse(num);
                }
                return total;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
