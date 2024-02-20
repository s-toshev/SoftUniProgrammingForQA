using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleCatalogue
{
    public class Truck
    {
        private readonly string Brand;
        private readonly string Model;
        private readonly int Weight;

        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string GetBrand()
        {
            return this.Brand;
        }

        public int GetWeight()
        {
            return this.Weight;
        }
        public string GetModel()
        {
            return this.Model;
        }

    }
}
