using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBoxes
{
    public class Item
    {
        private string Name {  get; set; }

        private decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string GetName()
        {
            return this.Name;
        }

        public decimal GetPrice()
        {
            return this.Price;
        }
    }
}
