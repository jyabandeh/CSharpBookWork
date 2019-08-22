using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C02P04_CardFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowBack_Click(object sender, EventArgs e)
        {
            picCardBack.Visible = true;
            picCardFace.Visible = false;
        }

        private void btnShowFace_Click(object sender, EventArgs e)
        {
            picCardBack.Visible = false;
            picCardFace.Visible = true;
        }
    }
}
