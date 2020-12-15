using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C11PP06_PopulationDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDataSet.City);

        }

        private void button1_Click(object sender, EventArgs e) // sort by population ascending
        {
            this.cityTableAdapter.FillByPopAsc(this.cityDataSet.City);
        }

        private void btnSortPopDesc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopDesc(this.cityDataSet.City);
        }

        private void btnSortCity_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByCity(this.cityDataSet.City);
        }

        private void btnTotalPop_Click(object sender, EventArgs e)
        {
            double totalPop = (double)this.cityTableAdapter.TotalPopulation();
            lblDisplay.Text = $"Total Population: \n{totalPop:n0}";
        }

        private void btnAvgPop_Click(object sender, EventArgs e)
        {
            double avgPop = (double)this.cityTableAdapter.AveragePopulation();
            lblDisplay.Text = $"Average Population: \n{avgPop:n0}";
        }

        private void btnHighestPop_Click(object sender, EventArgs e)
        {
            double maxPop = (double)this.cityTableAdapter.HighestPopulation();
            lblDisplay.Text = $"Highest Population: \n{maxPop:n0}";
        }

        private void btnLowestPop_Click(object sender, EventArgs e)
        {
            double minPop = (double)this.cityTableAdapter.LowestPopulation();
            lblDisplay.Text = $"Lowest Population: \n{minPop:n0}";
        }
    }
}
