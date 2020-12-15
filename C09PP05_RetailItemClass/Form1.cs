using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C09PP05_RetailItemClass
{
    public partial class Form1 : Form
    {
        RetailItem[] retailItems = new RetailItem[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayInventory_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(RetailItem r in retailItems)
            {
                sb.Append(r.ToString());
            }

            rtbDisplay.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            retailItems[0] = new RetailItem("Jacket", 12, 59.95m);
            retailItems[1] = new RetailItem("Jeans", 40, 34.95m);
            retailItems[2] = new RetailItem("Shirt", 20, 24.95m);
        }
    }
}
