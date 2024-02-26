namespace ExerciseOopHierarchy;

public abstract class MenuItem
{
    private string _name;
    private string _description;
    private decimal _price;


    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        private set { _description = value; }
    }

    public decimal Price 
    {
        get { return _price; }
        private set { _price = value; }
    }


    public MenuItem(string name, string description, decimal price)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
    }


    public override string ToString()
    {
        return $"{this.Name} - {this.Description} - ${this.Price}";
    }

}
