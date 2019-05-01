using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSServerless1.Models
{
    public class Item
    {
        double _netTotal { get { return (Quantity * UnitPrice); } }
        public string Name { get; set; }
        public bool IsImported { get; set; }
        public ItemCategory Category { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Total { get { return _netTotal + SalesTax; } }

        public double SalesTax { get { return CalculateSalesTaxes(); } }
        double CalculateSalesTaxes()
        {
            double rate = 0;
            if (Category != ItemCategory.FOOD && Category != ItemCategory.BOOK && Category != ItemCategory.MEDICAL)
            {
                rate = 0.1;
            }
            if (IsImported)
            {
                rate += 0.05;
            }
            return Math.Round(_netTotal * rate * 20) / 20;
        }
    }
}