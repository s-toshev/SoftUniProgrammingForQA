namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Catalog catalog = new Catalog();


            while (command != "end")
            {
                string[] input = command.Split("/").ToArray();

                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int hpOrWeight = int.Parse(input[3]);


                if (type == "Car")
                {
                    Car cars = new Car(brand, model, hpOrWeight);

                    catalog.Cars.Add(cars);
                }

                if (type == "Truck")
                {
                    Truck trucks = new Truck(brand, model, hpOrWeight);

                    catalog.Trucks.Add(trucks);

                }


                command = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                catalog.Cars = catalog.Cars.OrderBy(car => car.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (Car car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

                if (catalog.Trucks.Count > 0)
                {
                    catalog.Trucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();
                    Console.WriteLine("Trucks:");

                    foreach (Truck truck in catalog.Trucks)
                    {
                        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

                    }
                }
            }
        }
    }


    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;

        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;

        }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }

        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
    }
}