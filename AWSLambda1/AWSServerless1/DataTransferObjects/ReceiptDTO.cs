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
                return Items.Sum(i => i.Total);
            }
        }
        public double SalesTaxes
        { 
            get
            {
                return Items.Sum(i => i.SalesTax);
            }
        }

        public ReceiptDTO(IEnumerable<Item> items)
        {
            Items = new List<Item>(items);
        }
    }
}
