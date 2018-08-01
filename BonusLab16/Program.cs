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

            Console.Write("How many cars are you entering: ");
            int userInput = int.Parse(Console.ReadLine());



            // ***Processing***
            for (int i = 0; i < userInput; i++)
            {
                Console.Write($"What is the Make of the car: ");
                string Make = Console.ReadLine();

                Console.Write($"What is the Model of the car: ");
                string Model = Console.ReadLine();

                Console.Write("What is the Year of the car: ");
                int Year = int.Parse(Console.ReadLine());

                Console.Write("What is the Price of the car: ");
                double Price = double.Parse(Console.ReadLine());

                Car temp = new Car(Make, Model, Year, Price);

                car.Add(temp);

            }


            // ***OUTPUT * **
            //Console.WriteLine("Current Inventory: \n");
            //Console.WriteLine("Make".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Price".PadRight(10));
            //Console.WriteLine("--------------------------------------------+");
            Car.PrintInfo(car);



        }
    }
}
