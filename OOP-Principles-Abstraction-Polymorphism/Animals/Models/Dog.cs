using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Dog : Animal
    {

        public Dog(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favouriteFood;
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + $"{Environment.NewLine}BORK";
        }

    }
}
