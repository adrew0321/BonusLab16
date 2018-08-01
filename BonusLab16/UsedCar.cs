using System;
using System.Collections.Generic;

namespace BonusLab16
{
    class UsedCar : Car
    {
        // FIELDS
        private double mileage;
        private string miles;
        private string used;


        // PROPERTIES
        public double Mileage
        {
            set { mileage = value; }
            get { return mileage; }
        }

        public string Used
        {
            set { used = "(Used)"; }
            get { return used; }
        }


        // CONSTRUCTOR
        public UsedCar()
        {

        }

        public UsedCar(string uMake, string uModel, int uYear, double uPrice, string dUsed, double uCarMileage) : base(uMake, uModel, uYear, uPrice)
        {
            Mileage = uCarMileage;
            Used = dUsed;

        }

        // METHOD

        public override void PrintInfo(List<Car> car)
        {
            base.PrintInfo(car);
            Console.Write(" " + Used + " " + mileage, -10 + "miles");
        }

    }
}