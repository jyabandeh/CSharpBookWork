using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C09PP04_EmployeeClass
{
    public partial class Form1 : Form
    {
        List<Employee> employeeList = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int idNumber = int.Parse(txtIdNumber.Text);
                Employee employee = new Employee(txtName.Text, idNumber, txtDepartment.Text, txtPosition.Text);
                employeeList.Add(employee);
                lstEmployees.Items.Add(employee.Name);

                txtName.Clear();
                txtIdNumber.Clear();
                txtDepartment.Clear();
                txtPosition.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            employeeList.Clear();
            lstEmployees.Items.Clear();
            rtbDisplay.Clear();
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            int i = lstEmployees.SelectedIndex;
            rtbDisplay.Text = employeeList[i].ToString();
        }
    }
}
