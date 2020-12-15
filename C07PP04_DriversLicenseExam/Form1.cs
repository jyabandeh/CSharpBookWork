using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C07PP04_DriversLicenseExam
{
    public partial class Form1 : Form
    {
        readonly char[] CORRECT_ANSWERS = new char[20] { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            listBox1.Items.Clear();
            //get student answers array (use method)
            char[] studentAnswers = GetStudentAnswers();
            //compare to correct answers array (use method)
            GradeTest(studentAnswers);
            //create array of incorrect answers?
            //display incorrect answers in listbox
            //display result in textbox
        }

        public char[] GetStudentAnswers()
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    char[] studentAnswers = new char[20];
                    StreamReader inputFile = File.OpenText(openFileDialog1.FileName);


                    int i = 0;
                    while (i < studentAnswers.Length && !inputFile.EndOfStream)
                    {
                        studentAnswers[i] = char.Parse(inputFile.ReadLine());
                        i++;
                    }

                    inputFile.Close();
                    return studentAnswers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Operation cancelled.");
                return null;
            }
        }

        //method to grade test
        public void GradeTest(char[] studentAnswers)
        {
            int score = 0;

            for (int i = 0; i < CORRECT_ANSWERS.Length; i++)
            {
                if(CORRECT_ANSWERS[i] == studentAnswers[i])
                {
                    score++;
                }
                else
                {
                    listBox1.Items.Add($"{i + 1}. \t{studentAnswers[i]} \t(Correct = {CORRECT_ANSWERS[i]})");
                }
            }

            lblDisplay.Text = $"{score} correctly answered \n{20 - score} incorrectly answered";
        }
    }
}
