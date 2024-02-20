using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleCatalogue
{
    public class Car
    {
        private readonly string Brand;
        private readonly string Model;
        private readonly int HorsePower;
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string GetBrand()
        {
            return this.Brand;
        }

        public int GetHp()
        {
            return this.HorsePower;
        }
        public string GetModel()
        {
            return this.Model;
        }

    }

}
