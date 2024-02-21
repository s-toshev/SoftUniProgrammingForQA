using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer03
{
    public class Tire
    {
        

        public int Year { get; set; }
        public double Pressure { get; set; }
        public int V { get; }

        public Tire(int year, double pressure)
        {
            this.Pressure = pressure;
            this.Year = year;
        }

      
    }
}
