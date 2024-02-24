using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        private string _model;
        private string _color;


        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }


        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
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
            return $"{this.Color} Seat {this.Model}{Environment.NewLine}{this.Start()}{Environment.NewLine}{this.Stop()}";
        }

    }
}
