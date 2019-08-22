using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP07_SentenceBuilder
{
    public partial class Form1 : Form
    {
        private string sentence = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            sentence += "The";
            lblDisplay.Text = sentence;
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            sentence += "dog";
            lblDisplay.Text = sentence;
        }

        private void btnBarks_Click(object sender, EventArgs e)
        {
            sentence += "barks";
            lblDisplay.Text = sentence;
        }

        private void btnExclamation_Click(object sender, EventArgs e)
        {
            sentence += "!";
            lblDisplay.Text = sentence;
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            sentence += " ";
            lblDisplay.Text = sentence;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
