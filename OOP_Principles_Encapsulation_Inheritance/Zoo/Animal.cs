namespace Zoo;

public class Animal
{
    private string _name;

    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public Animal(string name)
    {
        this.Name = name;
    }

}
