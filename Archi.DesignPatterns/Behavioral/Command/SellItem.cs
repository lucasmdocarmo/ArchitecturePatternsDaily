using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Command
{
    internal class SellItem : ICommander
    {
        private readonly Store _store;

        public SellItem(Store store)
        {
            _store = store;
        }

        public void Execute()
        {
            Console.WriteLine("Sell Executed");
            _store.Sell();
        }
    }
}
