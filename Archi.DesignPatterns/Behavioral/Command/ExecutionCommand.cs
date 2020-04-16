using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Command
{
    public class ExecutionCommand
    {
        public static void Execute()
        {
            Store abcStock = new Store();

            BuyItem buyStockOrder = new BuyItem(abcStock);
            SellItem sellStockOrder = new SellItem(abcStock);

            CommandInvoker broker = new CommandInvoker();
            broker.BuyCommand(buyStockOrder);
            broker.SellCommand(sellStockOrder);

            broker.CheckOutCommand();
        }
    }
}
