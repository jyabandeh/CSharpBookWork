using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10PP04_PersonCustomerClass
{
    class PreferredCustomer : Customer
    {
        public decimal TotalPurchases { get; set; }
        public int DiscountPercent
        {
            get
            {
                if (TotalPurchases >= 2000)
                    return 10;
                else if (TotalPurchases >= 1500)
                    return 7;
                else if (TotalPurchases >= 1000)
                    return 6;
                else if (TotalPurchases >= 500)
                    return 5;
                else return 0;
            }
        }

        public PreferredCustomer(string name, string address, string phone, int custNum, bool mailList, decimal totPurch)
            : base(name, address, phone, custNum, mailList)
        {
            TotalPurchases = totPurch;
        }
    }
}
