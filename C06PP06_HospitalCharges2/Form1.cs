using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06PP06_HospitalCharges2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //call methods to calculate things
            decimal stay = CalcStayCharges();
            decimal misc = CalcMiscCharges();
            decimal total = CalcTotalCharges();

            //display results
            lblStayCharges.Text = stay.ToString("c");
            lblMiscCharges.Text = misc.ToString("c");
            lblTotalCharges.Text = total.ToString("c");

        }

        public decimal CalcStayCharges()
        {
            int days = 0;
            int.TryParse(txtDays.Text, out days);
            decimal total = (decimal)days * 350;
            return total;
        }

        public decimal CalcMiscCharges()
        {
            decimal medication = 0;
            decimal.TryParse(txtMedication.Text, out medication);
            decimal surgical = 0;
            decimal.TryParse(txtSurgical.Text, out surgical);
            decimal lab = 0;
            decimal.TryParse(txtLab.Text, out lab);
            decimal rehab = 0;
            decimal.TryParse(txtPhysRehab.Text, out rehab);

            decimal total = medication + surgical + lab + rehab;
            return total;
        }

        public decimal CalcTotalCharges()
        {
            decimal total = CalcStayCharges() + CalcMiscCharges();
            return total;
        }
    }
}
