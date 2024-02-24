using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private string _model;
        private string _color;
        private int _battery;

        public int Battery 
        {
           get {  return _battery; }
            set { _battery = value; }
        }

        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        public string Color
        {
            get { return (this._color); }
            set { this._color = value; }
        }

        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Break!";
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries{Environment.NewLine}{this.Start()}{Environment.NewLine}{this.Stop()}";
        }

    }
}
