using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleCatalogue
{
    public class Catalog
    {
        private readonly List<Car> ListCar;
        private readonly List<Truck> ListTruck;

        public Catalog(List<Car> listCar, List<Truck> listTruck)
        {
            this.ListTruck=listTruck;
            this.ListCar = listCar;

        }

        public List<Car> GetCarList()
        {
            return this.ListCar;
        }

        public List<Truck> GetTruckList()
        {
            return this.ListTruck;
        }


    }
}
