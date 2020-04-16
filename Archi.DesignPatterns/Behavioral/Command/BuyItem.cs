using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Command
{
    internal class BuyItem : ICommander
    {
        private readonly Store _store;

        public BuyItem(Store store)
        {
            _store = store;
        }

        public void Execute()
        {
            Console.WriteLine("Buy Executed");
            _store.Buy();
        }
    }
}
