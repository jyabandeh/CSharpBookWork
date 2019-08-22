using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05PP09_DiceSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int dieBlock1 = rand.Next(1, 7);
            int dieBlock2 = rand.Next(1, 7);

            //picDieBlock1.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die2.bmp");
            //above is the code to change the image displayed in a picture box
            //note that it needs to have double forward slashes "\\" to work properly
            //is there an easier/clear way with the images being loaded in Resources?

            switch (dieBlock1)
            {
                case 1:
                    picDieBlock1.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die1.bmp");
                    break;

                case 2:
                    picDieBlock1.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die2.bmp");
                    break;

                case 3:
                    picDieBlock1.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die3.bmp");
                    break;

                case 4:
                    picDieBlock1.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die4.bmp");
                    break;

                case 5:
                    picDieBlock1.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die5.bmp");
                    break;

                case 6:
                    picDieBlock1.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die6.bmp");
                    break;
            }

            switch (dieBlock2)
            {
                case 1:
                    picDieBlock2.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die1.bmp");
                    break;

                case 2:
                    picDieBlock2.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die2.bmp");
                    break;

                case 3:
                    picDieBlock2.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die3.bmp");
                    break;

                case 4:
                    picDieBlock2.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die4.bmp");
                    break;

                case 5:
                    picDieBlock2.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die5.bmp");
                    break;

                case 6:
                    picDieBlock2.Image = Image.FromFile("E:\\source\\repos\\BookWork\\C05PP09_DiceSimulator\\C05PP09_DiceSimulator\\Resources\\Die6.bmp");
                    break;

            }

            MessageBox.Show($"Num 1: {dieBlock1} \nNum 2: {dieBlock2}");
        }
    }
}
