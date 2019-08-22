using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP09_ChangeForADollarGame
{
    public partial class Form1 : Form
    {
        private const ushort PENNY_VALUE = 1;
        private const ushort NICKEL_VALUE = 5;
        private const ushort DIME_VALUE = 10;
        private const ushort QUARTER_VALUE = 25;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ushort pennies;
            ushort.TryParse(txtPennies.Text, out pennies);
            ushort nickels;
            ushort.TryParse(txtNickels.Text, out nickels);
            ushort dimes;
            ushort.TryParse(txtDimes.Text, out dimes);
            ushort quarters;
            ushort.TryParse(txtQuarters.Text, out quarters);

            ushort total = (ushort)((pennies * PENNY_VALUE) + (nickels * NICKEL_VALUE) + (dimes * DIME_VALUE) + (quarters * QUARTER_VALUE));

            if(total < 100)
            {
                lblResult.Text = "Less than a dollar.";
            }
            else if(total == 100)
            {
                lblResult.Text = "Congrats, you win!!";
            }
            else
            {
                lblResult.Text = "More than a dollar.";
            }
        }
    }
}
