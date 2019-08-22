using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP03_MagicDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //declare variables
            ushort month;
            ushort day;
            ushort year;
            
            //TryParse each input with nested ifs
            if (ushort.TryParse(txtMonth.Text, out month) && month >= 1 && month <= 12) //checking to see if month is valid
            {
                if (ushort.TryParse(txtDay.Text, out day) && day >= 1 && day <= 31) //checking to see if day is valid
                {
                    if (ushort.TryParse(txtYear.Text, out year))
                    {
                        if(month * day == year)
                        {
                            MessageBox.Show("This date is magic!");
                        }
                        else
                        {
                            MessageBox.Show("This date is not magic....");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input a valid year.");
                    }
                }
                else
                {
                    MessageBox.Show("Please input a valid day.");
                }
            }
            else
            {
                MessageBox.Show("Please input a valid month.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMonth.Text = "";
            txtDay.Text = "";
            txtYear.Text = "";
            txtMonth.Focus();
        }
    }
}
