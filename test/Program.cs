namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog doggie = new Dog("Naomi","stray", 3);

            doggie.Bark();

            //if you have only properties with no constructor, you can add name, breed and age by this way:
            //doggie.Name = "Naomi";
            //doggie.Breed = "stray";
            //doggie.age = 3;

        }
    }

    public class Dog
    {
        private string Name { get; set; }

        private string Breed { get; set; }

        private int Age { get; set; }

        public Dog(string name, string breed, int age)
        {
            this.Name = name;
            this.Breed = breed;
            this.Age = age;
        }

        public void Bark()
        {

            Console.WriteLine("Bark!");
        }
    }
}
