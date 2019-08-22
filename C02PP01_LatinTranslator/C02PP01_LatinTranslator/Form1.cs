using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C02PP01_LatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSinister_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Left";
        }

        private void btnDexter_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Right";
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Center";
        }
    }
}
