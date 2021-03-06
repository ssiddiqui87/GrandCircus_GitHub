﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._3_UCL
{
    class Car
    {
        private string vin;
        private string make;
        private string model;
        private int year;
        private double price;

        public string Vin { get => vin; set => vin = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public Car()
        {
            this.vin = RandomString(5);
            this.make = "";
            this.model = "";
            this.year = 0;
            this.price = 0.0;
        }
        public Car(string make, string model, int year, double price)
        {
            this.vin = RandomString(5);
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public override string ToString()
        {
            return $"Vin: {vin}\nMake: {make}\nModel: {model}\nYear: {year}\nPrice: {price.ToString("C")}";
        }

        // Generate a random string with a given size  
        public string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
