using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C11PP03_HourlyPaySorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void btnSortPayAsc_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillByPayAsc(this.employeeDataSet.Employee);
        }

        private void btnSortPayDesc_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillByPayDesc(this.employeeDataSet.Employee);

        }
    }
}
