using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08PP11_VendingMachine
{
    public struct Drink
    {
        public string name;
        public decimal cost;
        public int quantity;

        public Drink(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
            quantity = 20;
        }
    }

    public partial class Form1 : Form
    {
        Drink[] drinks =
        {
            new Drink("Cola", 1),
            new Drink("Root Beer", 1),
            new Drink("Lemon Lime", 1),
            new Drink("Grape Soda", 1.5m),
            new Drink("Cream Soda", 1.5m)
        };

        decimal totalSales = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void picCola_Click(object sender, EventArgs e)
        {
            ProcessSale(0, lblCola);
        }

        private void picRootBeer_Click(object sender, EventArgs e)
        {
            ProcessSale(1, lblRootBeer);
        }

        private void picLemonLime_Click(object sender, EventArgs e)
        {
            ProcessSale(2, lblLemonLime);
        }

        private void picGrapeSoda_Click(object sender, EventArgs e)
        {
            ProcessSale(3, lblGrapeSoda);
        }

        private void picCreamSoda_Click(object sender, EventArgs e)
        {
            ProcessSale(4, lblCreamSoda);
        }

        public void ProcessSale(int i, Label label)
        {
            if (drinks[i].quantity > 0)
            {
                totalSales += drinks[i].cost;
                lblTotalSales.Text = totalSales.ToString("c");
                drinks[i].quantity--;
                label.Text = drinks[i].quantity.ToString();
            }
            else
            {
                MessageBox.Show($"{drinks[i].name} out of stock.");
            }
        }
    }
}
