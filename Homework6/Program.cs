using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Fiat";
            car1.Model = "500C";
            car1.Year = 2013;
            car1.Kilometer = 115000;
            car1.Color = "White";
            car1.Price = 142000;
            car1.Location = "Istanbul, Bakirkoy";

            Car car2 = new Car();
            car2.Brand = "Volkswagen";
            car2.Model = "Polo";
            car2.Year = 2017;
            car2.Kilometer = 62000;
            car2.Color = "Black";
            car2.Price = 177500;
            car2.Location = "Denizli, Merkezefendi";

            Car car3 = new Car();
            car3.Brand = "Renault";
            car3.Model = "Clio";
            car3.Year = 2020;
            car3.Kilometer = 4000;
            car3.Color = "Red";
            car3.Price = 134500;
            car3.Location = "Konya, Selcuklu";



            Car[] cars = new Car[] { car1, car2, car3};

            foreach (var car in cars)
            {
                Console.WriteLine(car.Brand + ", " + car.Model + ", " + car.Year + ", " + car.Kilometer + ", " + car.Color + ", " + car.Price + ", " + car.Price);
            }
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Kilometer { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }

    }
}
