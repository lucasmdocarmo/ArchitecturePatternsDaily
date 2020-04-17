using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Behavioral.Observer
{
    internal class Account : IObserver
    {
        public Account(string value, User user)
        {
            Value = value;
            User = user;
        }

        public string Value { get; set; }
        public User User { get; set; }


        public void Update(int value)
        {
            WriteLine("\n Account with Value: " + Value + " Updated from User: " + User.Name);
        }
    }
}
