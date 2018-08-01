using System;
using System.Collections.Generic;

namespace BonusLab16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> car = new List<Car>(); //Makes new car list


            // ***INPUT***
            Console.WriteLine("\nWelcome to the Grand Circus Motors admin console!");

            // ***PROCESSING***

            //New Car
            Car c1 = new Car($"Nikolai", "Model S", 2017, 54999.90);
            Car c2 = new Car("Fourd", "Escapade", 2017, 31999.90);
            Car c3 = new Car("Chewie", "Chripus", 2017, 44989.95);

            //Used Car
            UsedCar u1 = new UsedCar("Hyonda", "Prior", 2017, 14795.50, "(Used)",35987.6);
            UsedCar u2 = new UsedCar("GC", "Chirpus", 2013, 8500, "(Used)", 123450.0);
            UsedCar u3 = new UsedCar("GC", "Witherell", 2016, 14450.00, "(Used)", 3500.3);

            // adds New Car to Car list
            car.Add(c1);
            car.Add(c2);
            car.Add(c3);

            // addes Used Car to Car lIst
            car.Add(u1);
            car.Add(u2);
            car.Add(u3);



            // ***OUTPUT***

            string dMake = "Make";
            string dModel = "Model";
            string dYear = "Year";
            string dPrice = "Price";
            string dMileage = "Mileage";

            Console.WriteLine($"{dMake,-10} {dModel,-10} {dYear,-10} {dPrice,-17} {dMileage}");
            Console.WriteLine("------------------------------------------------------------");
            foreach (Car c in car)
            {
                c.PrintInfo(car);
                Console.WriteLine();
            }


            // Console.WriteLine($"{String.Format($"{c1.Price:c}"),-10}");



        }
    }
}
