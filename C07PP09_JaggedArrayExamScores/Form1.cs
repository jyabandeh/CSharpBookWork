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

namespace C07PP09_JaggedArrayExamScores
{
    public partial class Form1 : Form
    {
        public const int SEC1SIZE = 12;
        public const int SEC2SIZE = 8;
        public const int SEC3SIZE = 10;
        public const double TOTAL_SIZE = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get exam scores in jagged array
            int[][] allScores = CreateAllScoresArray();
            //display scores in the first 3 listboxes
            ListBox[] listboxes = { listBox1, listBox2, listBox3 };
            for (int i = 0; i < allScores.Length; i++)
            {
                for (int j = 0; j < allScores[i].Length; j++)
                {
                    listboxes[i].Items.Add(allScores[i][j]);
                }
            }
            //get average of each section and display
            double[] avgs = CalcAvgEachSection(allScores);
            for (int i = 0; i < avgs.Length; i++)
            {
                listBox4.Items.Add($"Section {i + 1} Average = {avgs[i]:f1}");
            }
            //get average of all sections and display
            listBox4.Items.Add($"Average of All Sections = " +
                $"{(avgs[0] * (SEC1SIZE / TOTAL_SIZE) + avgs[1] * (SEC2SIZE / TOTAL_SIZE) + avgs[2] * (SEC3SIZE / TOTAL_SIZE)):f1}");
            //get highest exam score and section (then display)
            int highest = FindHighestScore(allScores, out int secHighest);
            listBox4.Items.Add($"Highest Score is {highest} from Section {secHighest}");
            //get lowest exam score and section (then display)
            int lowest = FindLowestScore(allScores, out int secLowest);
            listBox4.Items.Add($"Lowest Score is {lowest} from Section {secLowest}");

        }

        public int[] ReadExamScore(int size, string path)
        {
            StreamReader inputFile = File.OpenText(path);
            int[] scores = new int[size];
            int i = 0;
            while (i < scores.Length && !inputFile.EndOfStream)
            {
                scores[i] = int.Parse(inputFile.ReadLine());
                i++;
            }
            inputFile.Close();
            return scores;
        }
        public int[][] CreateAllScoresArray()
        {
            //section 1
            string sec1Path = @"E:\C# Programming 1\student_sample_programs\student_sample_programs\Chap07\Section1.txt";
            int[] sec1Scores = ReadExamScore(SEC1SIZE, sec1Path);

            //section 2
            string sec2Path = @"E:\C# Programming 1\student_sample_programs\student_sample_programs\Chap07\Section2.txt";
            int[] sec2Scores = ReadExamScore(SEC2SIZE, sec2Path);

            //section 3
            string sec3Path = @"E:\C# Programming 1\student_sample_programs\student_sample_programs\Chap07\Section3.txt";
            int[] sec3Scores = ReadExamScore(SEC3SIZE, sec3Path);

            int[][] allScores = new int[3][];
            allScores[0] = sec1Scores;
            allScores[1] = sec2Scores;
            allScores[2] = sec3Scores;

            return allScores;
        }

        public double[] CalcAvgEachSection(int[][] scores)
        {
            double[] averages = new double[3];
            for (int i = 0; i < scores.Length; i++)
            {
                double total = 0;
                for (int j = 0; j < scores[i].Length; j++)
                {
                    total += scores[i][j];
                }
                averages[i] = total / scores[i].Length;
            }
            return averages;
        }

        public int FindHighestScore(int[][] scores, out int section)
        {
            int highest = scores[0][0];
            section = 1;
            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = 0; j < scores[i].Length; j++)
                {
                    if (scores[i][j] > highest)
                    {
                        highest = scores[i][j];
                        section = i + 1;
                    }
                }
            }
            return highest;
        }

        public int FindLowestScore(int[][] scores, out int section)
        {
            int lowest = scores[0][0];
            section = 1;
            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = 0; j < scores[i].Length; j++)
                {
                    if (scores[i][j] < lowest)
                    {
                        lowest = scores[i][j];
                        section = i + 1;
                    }
                }
            }
            return lowest;
        }
    }
}
