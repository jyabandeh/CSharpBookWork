﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C02PP06_Orion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowNames_Click(object sender, EventArgs e)
        {
            lblAlnilam.Visible = true;
            lblAlnitak.Visible = true;
            lblBetelgeuse.Visible = true;
            lblMeissa.Visible = true;
            lblMintaka.Visible = true;
            lblRigel.Visible = true;
            lblSaiph.Visible = true;
        }

        private void btnHideNames_Click(object sender, EventArgs e)
        {
            lblAlnilam.Visible = false;
            lblAlnitak.Visible = false;
            lblBetelgeuse.Visible = false;
            lblMeissa.Visible = false;
            lblMintaka.Visible = false;
            lblRigel.Visible = false;
            lblSaiph.Visible = false;
        }
    }
}
