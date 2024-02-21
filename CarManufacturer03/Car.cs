using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer03
{
    public class Car
    {


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public double FuelQty { get; set; }
        public double FuelConsumption { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQty = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQty, double fuelConsumption) : this(make, model, year) 
        {
            this.FuelQty= fuelQty;
            this.FuelConsumption= fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQty, double fuelConsumption, Engine engine, Tire[] tires) : this(make,model, year, fuelQty, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

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
            return $"Make: {this.Make}\r\nModel: {this.Model}\r\nYear: {this.Year}\r\nFuel: {this.FuelQty:F2}";
        }
    }
}
