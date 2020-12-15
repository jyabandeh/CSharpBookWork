using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06PP05_JoesAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //call methods to calc all charges
            decimal service = OilLubeCharges() + FlushCharges() + MiscCharges();
            decimal partsLabor = OtherCharges();
            decimal tax = TaxCharges();
            decimal total = TotalCharges();

            //display results
            lblService.Text = service.ToString("c");
            lblPartsLabor.Text = partsLabor.ToString("c");
            lblTax.Text = tax.ToString("c");
            lblTotal.Text = total.ToString("c");
        }

        //calculate methods
        public decimal OilLubeCharges()
        {
            decimal total = 0;
            if (chkOil.Checked)
                total += 26;
            if (chkLube.Checked)
                total += 18;
            return total;
        }
        public decimal FlushCharges()
        {
            decimal total = 0;
            if (chkRadiator.Checked)
                total += 30;
            if (chkTransmission.Checked)
                total += 80;
            return total;
        }
        public decimal MiscCharges()
        {
            decimal total = 0;
            if (chkInspection.Checked)
                total += 15;
            if (chkMuffler.Checked)
                total += 100;
            if (chkTire.Checked)
                total += 20;
            return total;
        }
        public decimal OtherCharges()
        {
            decimal parts = 0;
            decimal.TryParse(txtParts.Text, out parts);
            decimal labor = 0;
            decimal.TryParse(txtLabor.Text, out labor);
            return parts + labor;
        }
        public decimal TaxCharges()
        {
            decimal parts = 0;
            decimal.TryParse(txtParts.Text, out parts);
            return parts * 0.06m;
        }
        public decimal TotalCharges()
        {
            decimal total = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges();
            return total;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        //clear methods
        public void ClearOilLube()
        {
            chkOil.Checked = false;
            chkLube.Checked = false;
        }
        public void ClearFlushes()
        {
            chkRadiator.Checked = false;
            chkTransmission.Checked = false;
        }
        public void ClearMisc()
        {
            chkInspection.Checked = false;
            chkMuffler.Checked = false;
            chkTire.Checked = false;
        }
        public void ClearOther()
        {
            txtParts.Clear();
            txtLabor.Clear();
        }
        public void ClearFees()
        {
            lblPartsLabor.Text = "";
            lblService.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
