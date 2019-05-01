using AWSServerless1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AWSServerless1.DataTransferObjects
{
    public class ReceiptDTO
    {
        public List<Item> Items { get; set; }
        public double GrandTotal
        {
            get
            {
                return Math.Round(Items.Sum(i => i.Total),2);
            }
        }
        public double SalesTaxes
        { 
            get
            {
                return Math.Round(Items.Sum(i => i.SalesTax),2);
            }
        }

        public ReceiptDTO(IEnumerable<Item> items)
        {
            Items = new List<Item>(items);
        }
    }
}
