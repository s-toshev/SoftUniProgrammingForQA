using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {

        private string _make;
        private string _model;
        private int _year;
        private double _fuelQty;
        private double _fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public double FuelQty { get; set; }
        public double FuelConsumption { get; set; }


        public void Drive(double distance)
        {
            if ((this.FuelQty - (distance * this.FuelConsumption)) > 0)
            {
                this.FuelQty = this.FuelQty - (distance * this.FuelConsumption);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\r\nModel: { this.Model}\r\nYear: { this.Year}\r\nFuel: { this.FuelQty:F2}";
        }
    }
}
