using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C09PP02_CarClass
{
    public partial class Form1 : Form
    {
        private Car car = new Car(2016, "Mazda");

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplaySpeed();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car.Accelerate();
            DisplaySpeed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car.Brake();
            DisplaySpeed();
        }

        private void DisplaySpeed()
        {
            lblDisplay.Text = car.Speed.ToString();
        }
    }
}
