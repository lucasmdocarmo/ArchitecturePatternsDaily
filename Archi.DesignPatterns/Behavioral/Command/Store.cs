using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Behavioral.Command
{
    internal class Store
    {
        private string Name = "ABC";
        private int Quantity = 10;

        public void Buy()
        {
            WriteLine("Store " + Name + "Stock:" + Quantity + " Bought");
        }
        public void Sell()
        {
            WriteLine("Store " + Name + "Stock:" + Quantity + " Sold");
        }
    }
}
