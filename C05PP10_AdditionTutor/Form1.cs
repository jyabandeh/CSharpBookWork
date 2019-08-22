using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP10_AdditionTutor
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int answer; //declare these outside so both buttons can use them!
            int.TryParse(txtAnswer.Text, out answer);
            int first;
            int.TryParse(lblFirstNumber.Text, out first);
            int second;
            int.TryParse(lblSecondNumber.Text, out second);

            int sum = first + second;

            if(sum == answer)
            {
                MessageBox.Show("Correct.");

                first = rand.Next(100, 501); //make this block a method so the code looks better!
                lblFirstNumber.Text = first.ToString();

                second = rand.Next(100, 501);
                lblSecondNumber.Text = second.ToString();

                txtAnswer.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrect.");

                first = rand.Next(100, 501);
                lblFirstNumber.Text = first.ToString();

                second = rand.Next(100, 501);
                lblSecondNumber.Text = second.ToString();

                txtAnswer.Text = "";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int first = rand.Next(100, 501);
            lblFirstNumber.Text = first.ToString();

            int second = rand.Next(100, 501);
            lblSecondNumber.Text = second.ToString();
        }
    }
}
