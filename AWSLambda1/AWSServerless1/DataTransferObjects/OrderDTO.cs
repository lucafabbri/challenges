using AWSServerless1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSServerless1.DataTransferObjects
{
    public class OrderDTO
    {
        public IEnumerable<Item> Items { get; set; }
    }
}
