using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09PP05_RetailItemClass
{
    class RetailItem
    {
        public string Description { get; }
        public int UnitsOnHand { get; }
        public decimal Price { get; }

        public RetailItem(string description, int unitsOnHand, decimal price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }

        public override string ToString()
        {
            return $"Item: {Description}\nUnits: {UnitsOnHand}\nPrice: {Price:c}\n\n";
        }
    }
}
