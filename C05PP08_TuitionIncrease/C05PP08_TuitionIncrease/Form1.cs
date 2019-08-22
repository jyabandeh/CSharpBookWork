using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP08_TuitionIncrease
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            decimal tuition = 6000m;
            const decimal TUITION_INCREASE_RATE = 1.02m;

            lstDisplay.Items.Clear();

            lstDisplay.Items.Add("Year\tSemester Tuition");

            for (int i = 0; i <= 5; i++)
            {
                lstDisplay.Items.Add($"{i}\t{tuition:c}");
                tuition *= TUITION_INCREASE_RATE;
            }
        }
    }
}
