using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Creational.Prototype
{
    public abstract class Car
    {
        protected Car(string model, string manufacturer, string year, string country)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            Country = country;
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Year { get; set; }
        public string Country { get; set; }

        public abstract Car ManualClone();

    }
}
