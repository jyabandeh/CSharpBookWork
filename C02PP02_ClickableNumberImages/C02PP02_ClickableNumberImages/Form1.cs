﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C02PP02_ClickableNumberImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the One!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Two!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Three!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Four!");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Five!");
        }
    }
}
