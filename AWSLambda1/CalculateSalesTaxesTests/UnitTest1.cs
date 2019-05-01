using AWSServerless1.DataTransferObjects;
using AWSServerless1.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item { Name = "book", Quantity = 2, UnitPrice = 12.49, Category = ItemCategory.BOOK });
            items.Add(new Item { Name = "music CD", Quantity = 1, UnitPrice = 14.99, Category = ItemCategory.MUSIC });
            items.Add(new Item { Name = "chocolate bar", Quantity = 1, UnitPrice = 0.85, Category = ItemCategory.FOOD });

            ReceiptDTO receipt = new ReceiptDTO(items);
            Assert.True(receipt.SalesTaxes == 1.5, "Sales Taxes: " + receipt.SalesTaxes);
            Assert.True(receipt.GrandTotal == 42.32, "Grand Total: " + receipt.GrandTotal);
        }

        [Test]
        public void Test2()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item { Name = "box of chocolates", Quantity = 1, UnitPrice = 10, Category = ItemCategory.FOOD, IsImported = true });
            items.Add(new Item { Name = "bottle of perfume", Quantity = 1, UnitPrice = 47.50, Category = ItemCategory.PERSONALCARE, IsImported = true });

            ReceiptDTO receipt = new ReceiptDTO(items);
            Assert.True(receipt.SalesTaxes == 7.65, "Sales Taxes: "+ receipt.SalesTaxes);
            Assert.True(receipt.GrandTotal == 65.15, "Grand Total: " + receipt.GrandTotal);
        }

        [Test]
        public void Test3()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item { Name = "bottle of perfume", Quantity = 1, UnitPrice = 27.99, Category = ItemCategory.PERSONALCARE, IsImported = true });
            items.Add(new Item { Name = "bottle of perfume", Quantity = 1, UnitPrice = 18.99, Category = ItemCategory.PERSONALCARE });
            items.Add(new Item { Name = "packet of headache pills", Quantity = 1, UnitPrice = 9.75, Category = ItemCategory.MEDICAL });
            items.Add(new Item { Name = "box of chocolates", Quantity = 3, UnitPrice = 11.25, Category = ItemCategory.FOOD, IsImported = true });

            ReceiptDTO receipt = new ReceiptDTO(items);
            Assert.True(receipt.SalesTaxes == 7.9, "Sales Taxes: " + receipt.SalesTaxes);
            Assert.True(receipt.GrandTotal == 98.38, "Grand Total: " + receipt.GrandTotal);
        }
    }
}