using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C08AW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1------------------------------------------
        public bool CheckCapAndPunc (string str)
        {
            bool valid = false;
            char[] punctuation = { '.', '!', '?' };
            
            if (char.IsUpper(str[0]))
            {
                foreach (char ch in punctuation)
                {
                    if (str[str.Length - 1] == ch)
                    {
                        valid = true;
                        return valid;
                    }
                }
                return valid; //will return false if it gets to this point
            }
            else
            {
                return valid;
            }
        }

        //2------------------------------------------
        public void DisplayStringBackwards (string str1)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                sb.Append(str1[i]);
            }

            string str2 = sb.ToString();
            MessageBox.Show(str2.ToString());
        }

        //3----------------------------------------------
        public struct Engine
        {
            public int cylinders;
            public int horsepower;
            public int torque;
        }
        public bool AreEnginesEqual (Engine e1, Engine e2)
        {
            if (e1.cylinders == e2.cylinders && e1.horsepower == e2.horsepower && e1.torque == e2.torque)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //4------------------------------------------------------
        enum Direction { North, South, East, West }

        //5----------------------------------------------------
        private void slideShowPictureBox_Click(object sender, EventArgs e)
        {
            slideShowPictureBox.Image = slideShowImageList.Images[0];
        }


        //=============================================================
        private void btnReverseString_Click(object sender, EventArgs e)
        {
            DisplayStringBackwards("gravity");
        }
    }
}
