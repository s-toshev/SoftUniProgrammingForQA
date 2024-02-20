using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBoxes
{
    public class Box
    {
        private string SerialNumber {  get; set; }  
        private Item Item { get; set; }
        private int ItemQty { get; set; }
        private decimal PricePerBox { get; set; }

        public Box(string serialNumber, Item item, int itemQty, decimal pricePerBox)
        {
            this.Item = item;
            this.SerialNumber = serialNumber;
            this.ItemQty = itemQty;
            this.PricePerBox = pricePerBox;
        }


        public string GetSerialNumber()
        {
            return this.SerialNumber;
        }

        public Item GetItem()
        {
            return this.Item;
        }
        public int GetItemQty()
        {
            return this.ItemQty;
        }

        public decimal GetPricePerBox()
        {
            return Item.GetPrice() * this.ItemQty;
        }

    }
}
