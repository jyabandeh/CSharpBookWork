﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C11T06_ProductQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }

        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByPrice(this.productDataSet.Product);
        }

        private void btnUnitsGreater100_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByUnits(this.productDataSet.Product);
        }

        private void button1_Click(object sender, EventArgs e) //avg Price button
        {
            decimal averagePrice = (decimal)this.productTableAdapter.AveragePrice();
            MessageBox.Show($"Average price of all items: {averagePrice:c}");
        }
    }
}
