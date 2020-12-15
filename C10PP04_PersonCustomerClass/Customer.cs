using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10PP04_PersonCustomerClass
{
    class Customer : Person
    {
        public int CustNumber { get; set; }
        public bool MailList { get; set; }

        public Customer(string name, string address, string phone, int custNum, bool mailList)
            : base(name, address, phone)
        {
            CustNumber = custNum;
            MailList = mailList;
        }
    }
}
