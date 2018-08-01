using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BonusLab16
{
    class Car
    {
        //Fields to represent data (private)

        #region Fields
        private string make;
        private string model;
        private int year;
        private double price;
        #endregion Fields

        // Properties

        #region Properties
        public string Make
        {
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z ]{1,15}$"))
                {
                    throw new Exception("Make is not a valid input");
                }
                else
                {
                    make = value;
                }
            }

            get { return make; }
        }

        public string Model
        {
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z']{1,20}[ a-zA-z\d]{1,20}$"))
                {
                    throw new Exception("Model is not a valid input");
                }
                else
                {
                    model = value;
                }
            }

            get { return model; }
        }

        public int Year
        {
            set
            {
                if (!Regex.IsMatch(value.ToString(), @"^\d{1,4}$"))
                {
                    throw new Exception("The year entered is not a valid input");
                }
                else
                {
                    year = value;
                }
            }

            get { return year; }
        }

        public double Price
        {
            set
            {
                if (!Regex.IsMatch(value.ToString(), @"^\d{1,9}.\d{1,2}$"))
                {
                    throw new Exception("The price entered is not a valid");
                }
                else
                {
                    price = value;
                }
            }

            get { return price; }

        }
        #endregion Properties

        //Constructor
        #region Constructor
        public Car()
        {

        }

        public Car(string uMake, string uModel, int uYear, double uPrice)
        {
            Make = uMake;
            Model = uModel;
            Year = uYear;
            Price = uPrice;
        }

        #endregion


        //Methods

        public virtual void PrintInfo(List<Car> car)
        {
                Console.Write($"{Make, -10} {Model, -10} {Year.ToString(), -10} {String.Format($"{Price:c}"),-10}");
        }



    }


}




