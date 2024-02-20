namespace vehicleCatalogue
{
    public class Execute
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Car> listCar = new List<Car>();
            List<Truck> listTruck = new List<Truck>();  


            while (command != "end")
            {
                string[] input = command.Split("/");
                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int hpOrWeight = int.Parse(input[3]);

                if (type == "Car")
                {
                    Car currentCar = new(brand, model, hpOrWeight);
                    listCar.Add(currentCar);
                }
                else if (type == "Truck")
                {
                    Truck currentTruck = new(brand, model, hpOrWeight);
                    listTruck.Add(currentTruck);
                }


                command = Console.ReadLine();
            }

            listCar = listCar.OrderBy(s => s.GetBrand()).ToList();  
            listTruck = listTruck.OrderBy(s => s.GetBrand()).ToList();

            Catalog catalogue = new(listCar,listTruck);

            if (catalogue.GetCarList().Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalogue.GetCarList())
                {
                    Console.WriteLine($"{car.GetBrand()}: {car.GetModel()} - {car.GetHp()}hp");
                }
            }
           
            if(catalogue.GetTruckList().Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in catalogue.GetTruckList())
                {
                    Console.WriteLine($"{truck.GetBrand()}: {truck.GetModel()} - {truck.GetWeight()}kg");
                }
            }
        }
    }
}
