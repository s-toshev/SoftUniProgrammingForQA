using System;

namespace Animals.Models;

public abstract class Animal
{
    private string _name;
    private string _favouriteFood;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public string FavoriteFood
    {
        get { return this._favouriteFood; }
        set { this._favouriteFood = value; }
    }


    public virtual string ExplainSelf()
    {
       return $"I am {this.Name} and my favourite food is {this.FavoriteFood}";
    }

}
