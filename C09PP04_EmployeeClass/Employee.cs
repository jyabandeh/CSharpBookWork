using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09PP04_EmployeeClass
{
    class Employee
    {
        public string Name { get; }
        public int IdNumber { get; }
        public string Department { get; }
        public string Position { get; }

        public Employee(string name, int idNumber, string department, string position)
        {
            Name = name;
            IdNumber = idNumber;
            Department = department;
            Position = position;
        }
        public Employee(string name, int idNumber)
        {
            Name = name;
            IdNumber = idNumber;
        }
        public Employee() { }

        public override string ToString()
        {
            return $"{Name}\n  ID Number: {IdNumber}\n  Department: {Department}\n  Position: {Position}";
        }
    }
}
