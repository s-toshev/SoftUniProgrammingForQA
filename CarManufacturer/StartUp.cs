namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQty = 200;
            car.FuelConsumption = 200;

            car.Drive(20000);

            Console.WriteLine(car.WhoAmI());


        }
    }
}
