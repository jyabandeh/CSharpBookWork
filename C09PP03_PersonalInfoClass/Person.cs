using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09PP03_PersonalInfoClass
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Name}\n  Age: {Age}\n  Address: {Address}\n  Phone: {PhoneNumber}";
        }
    }
}
