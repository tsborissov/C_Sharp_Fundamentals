using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();




        }
    }

    public class Item
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public Item(string itemName, double itemPrice)
        {
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
        }
    }

    //Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item ItemName { get; set; }
        public double ItemQuantity { get; set; }
        public string BoxPrice { get; set; }

        public Box(string serialNumber, string itemName, double itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.ItemName = itemName;
            this.ItemQuantity = itemQuantity;

            double itemPrice = 
        }

    }


}
