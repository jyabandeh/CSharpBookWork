using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C10PP01_EmployeeWorkerClasses
{
    //public enum Shift { Day = 1, Night = 2 }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateProdWorker_Click(object sender, EventArgs e)
        {
            ProductionWorker pw = new ProductionWorker();
            try
            {
                GetProdWorkerData(pw);
                DisplayProdWorker(pw);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetProdWorkerData(ProductionWorker pw)
        {
            pw.Name = txtEmpName.Text;
            pw.EmpNumber = int.Parse(txtEmpNum.Text);
            pw.HourlyPayRate = decimal.Parse(txtPay.Text);
            if(cmbShift.SelectedIndex != -1)
            {
                pw.WorkShift = cmbShift.Text;
            }
            else
            {
                throw new Exception("Select a shift");
            }
            
        }

        private void DisplayProdWorker(ProductionWorker pw)
        {
            lblEmpName.Text = pw.Name;
            lblEmpNum.Text = pw.EmpNumber.ToString();
            lblShift.Text = pw.WorkShift;
            lblPay.Text = pw.HourlyPayRate.ToString();
        }
    }
}
