﻿namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make}\r\nModel: {car.Model}\r\nYear: {car.Year}");


        }
    }
}
