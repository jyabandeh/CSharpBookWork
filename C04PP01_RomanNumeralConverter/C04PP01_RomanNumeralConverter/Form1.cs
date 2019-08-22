using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP01_RomanNumeralConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetermineRomanNumeral_Click(object sender, EventArgs e)
        {
            //declare variables
            ushort integer;
            //string romanNumeral;

            //get user input
            ushort.TryParse(txtInteger.Text, out integer);

            //determine if within 1-10
            //if (integer >= 1 && integer <= 10)
            //{
            //chose to do this instead with the default
                switch (integer)
                {
                    case 1:
                        lblDisplayRomanNumeral.Text = "I";
                        break;

                    case 2:
                        lblDisplayRomanNumeral.Text = "II";
                        break;

                    case 3:
                        lblDisplayRomanNumeral.Text = "III";
                        break;

                    case 4:
                        lblDisplayRomanNumeral.Text = "IV";
                        break;

                    case 5:
                        lblDisplayRomanNumeral.Text = "V";
                        break;

                    case 6:
                        lblDisplayRomanNumeral.Text = "VI";
                        break;

                    case 7:
                        lblDisplayRomanNumeral.Text = "VII";
                        break;

                    case 8:
                        lblDisplayRomanNumeral.Text = "VIII";
                        break;

                    case 9:
                        lblDisplayRomanNumeral.Text = "IX";
                        break;

                    case 10:
                        lblDisplayRomanNumeral.Text = "X";
                        break;

                    default:
                        MessageBox.Show("Please input a number between 1 and 10");
                        break;
                }
                //lblDisplayRomanNumeral.Text = romanNumeral;
            //}
            //else
            //{
            //    MessageBox.Show("Please input a number between 1 and 10");
           // }
        }
    }
}
