using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2008;// dot notation


            var honda = new Car()
            {
                Make = "Honda",
                Model = "CRV",
                Year = 2015
            };

            var ford = new Car( "Ford", "Gran Torino", 1972 );

            var carList = new List<Car>() { myCar, honda, ford};

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}");
            }

        }
    }
}
