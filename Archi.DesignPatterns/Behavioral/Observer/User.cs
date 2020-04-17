using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Behavioral.Observer
{
    internal class User : IObserver
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Update(int value)
        {
            WriteLine("\n Name:" + value + " Updated ");
        }
    }
}
