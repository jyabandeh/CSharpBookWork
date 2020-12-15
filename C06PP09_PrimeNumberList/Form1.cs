using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06PP09_PrimeNumberList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        private void btnShowPrimes_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i++)
            {
                if (IsPrime(i))
                    lstPrimes.Items.Add(i);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstPrimes.Items.Clear();
        }
    }
}
