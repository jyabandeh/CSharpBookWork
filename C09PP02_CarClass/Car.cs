using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09PP02_CarClass
{
    class Car
    {
        public int Year { get; }
        public string Make { get; }
        public int Speed { get; set; }

        public Car(int year, string make)
        {
            Year = year;
            Make = make;
            Speed = 0;
        }

        public void Accelerate()
        {
            Speed += 5;
        }

        public void Brake()
        {
            if (Speed != 0)
            {
                Speed -= 5;
            }                
        }
    }
}
