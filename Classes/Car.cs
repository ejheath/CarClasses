using System;
namespace Classes
{
    public class Car
    {
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car()
        {

        }
        public string Make { get; set; } //get = read set = write
        public string Model { get; set; }
        public int Year { get; set; }
    }
   
}
