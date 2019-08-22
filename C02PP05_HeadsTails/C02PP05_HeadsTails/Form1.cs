using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C02PP05_HeadsTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowHeads_Click(object sender, EventArgs e)
        {
            picHeads.Visible = true;
            picTails.Visible = false;
        }

        private void btnShowTails_Click(object sender, EventArgs e)
        {
            picHeads.Visible = false;
            picTails.Visible = true;
        }
    }
}
