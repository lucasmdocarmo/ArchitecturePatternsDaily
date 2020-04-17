using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Daily.DesignPatterns.Creational.Prototype
{
    public class ExecutePrototype
    {
        public static void Execute()
        {
            Car uniqueCar = new Fiat("LaFerrari", "Ferrari", "2020", "Brazil");
            Car baseCar = new Fiat("Uno", "Fiat", "2020", "Brazil");

            Car copyCar = baseCar.ManualClone();

            copyCar.Model = uniqueCar.Model; 

            WriteLine("Copy Car is: {0}. Model Changed. {1} ", copyCar.Manufacturer, copyCar.Model);
            WriteLine("Original Car is: {0}, and it's name:. {1} ", baseCar.Manufacturer, baseCar.Model);

            WriteLine("Now....Using ICLONABLE");

            var fordCar = new Ford("Ranger", "FORD", "2020", "Brazil");

            var copy = (Ford) fordCar.Clone(); //Explict Cast. Otherwise is a Object Copy
            
            WriteLine("Original Car is: {0}. Model {1} ", fordCar.Manufacturer, fordCar.Model);
            WriteLine("Copy of Original to new Object: => Car is: {0}. Model {1} ", copy.Manufacturer, copy.Model);
        }
    }
}
