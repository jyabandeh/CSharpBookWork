using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmWorkbench
{
    class Program
    {
        static void Main(string[] args)
        {
            //01-------------------------------------------------------------------
            string[] names = new string[20];
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }


            //02--------------------------------------------------------------------
            int[] numberArray1 = new int[100];
            int[] numberArray2 = new int[100];
            for (int i = 0; i < numberArray1.Length; i++)
            {
                numberArray2[i] = numberArray1[i];
            }


            //03------------------------------------------------------------------
            int[] values = new int[20];
            bool found = false;
            int index = 0;
            int position = -1;
            //search the array
            while (!found && index < values.Length)
            {
                if(values[index] == -1)
                {
                    found = true;
                    position = index;
                }
                index++;
            }
            //display message
            if (found)
            {
                Console.WriteLine($"-1 found at index {index}");
            }
            else
            {
                Console.WriteLine($"-1 not found in array");
            }


            //04------------------------------------------------------------
            int[,] grades = new int[18, 12];


            //05------------------------------------------------------------
            int total;
            for(int col = 0; col<12; col++)
            {
                total = 0;
                for (int row = 0; row < 18; row++)
                {
                    total += grades[row, col];
                }
                Console.WriteLine($"The total of column {col} is {total}");
            }


            //06------------------------------------------------------------
            List<string> stringList = new List<string>();
            int first = 0;
            int last = stringList.Count - 1;
            int middle;
            int place = -1;
            bool located = false;
            string a = "A";
            //search for the value
            while (!located && first <= last)
            {
                middle = (first + last) / 2;
                if (string.Compare(stringList[middle], a, false) == 0)
                {
                    located = true;
                    place = middle;
                }
                else if (string.Compare(stringList[middle], a, false) > 0)
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle + 1;
                }
            }
            //display
            if (located)
            {
                Console.WriteLine($"The string '{a}' was found at index {place}");
            }
            else
            {
                Console.WriteLine($"The string '{a}' was not found");
            }



            Console.ReadLine();
        }
    }
}
