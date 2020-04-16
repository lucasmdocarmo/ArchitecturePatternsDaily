using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Command
{
    internal class CommandInvoker
    {
        private readonly List<ICommander> _commands = new List<ICommander>();

        public void BuyCommand(ICommander order)
        {
            Console.WriteLine("Calling Invoker Class");
            Console.WriteLine("Buy Command");

            _commands.Add(order);
        }

        public void SellCommand(ICommander order)
        {
            Console.WriteLine("Calling Invoker Class");
            Console.WriteLine("Sell Command");

            _commands.Add(order);
        }

        public void CheckOutCommand()
        {

            foreach (var order in _commands)
            {
                order.Execute();
            }
            _commands.Clear();
        }
    }
}
