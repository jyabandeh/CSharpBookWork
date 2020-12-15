using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09PP07_EmailAddressBook
{
    class PersonEntry
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public PersonEntry(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
        public PersonEntry() { }

        public override string ToString()
        {
            return $"{Name}\n{Email}\n{Phone}";
        }
    }
}
