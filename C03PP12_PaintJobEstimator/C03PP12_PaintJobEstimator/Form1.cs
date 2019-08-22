using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03PP12_PaintJobEstimator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //get values
            decimal squareFeet = decimal.Parse(txtSquareFeet.Text);
            decimal paintPrice = decimal.Parse(txtPaintPrice.Text);

            //do calculations
            decimal gallons = squareFeet * 1 / 115;
            decimal laborHours = squareFeet * 8 / 115;
            decimal paintCost = gallons * paintPrice;
            decimal laborCost = laborHours * 20;
            decimal totalCost = laborCost + paintCost;

            //display everything
            rtbDisplay.Text = $"Gallons: {gallons:n1} \nHours of Labor: {laborHours:n1} \nCost of Paint: {paintCost:c}" +
                $"\nCost of Labor: {laborCost:c} \nTotal Cost: {totalCost:c}";
        }
    }
}
