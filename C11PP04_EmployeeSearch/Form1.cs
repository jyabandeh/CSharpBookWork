using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C11PP04_EmployeeSearch
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
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SearchName(this.personnelDataSet.Employee, txtName.Text.ToLower());
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);
        }
    }
}
