namespace Players;

public class Hero
{
    private string _userName;
    private int _level;

    public string UserName
    {
        get { return _userName; }
        private set { _userName = value; }
    }

    public int Level
    {
        get { return _level; }
        private set { _level = value; }
    }

    public Hero(string userName, int level)
    {
        this.UserName = userName;
        this.Level = level;
    }

    public override string ToString()
    {
        return $"Type: {this.GetType().Name} Username: {this.UserName} Level: {this.Level}";
    }

}
