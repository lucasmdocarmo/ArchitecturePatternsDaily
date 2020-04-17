using Daily.DesignPatterns.Behavioral.Command;
using Daily.DesignPatterns.Behavioral.Mediator;
using Daily.DesignPatterns.Behavioral.Observer;
using Daily.DesignPatterns.Creational.Singleton;
using System;
using static System.Console;

namespace Daily.DesignPatterns
{
    public class Program
    {
        static void Main()
        {
            WriteLine("Choose:");
            WriteLine("------------------------");
            WriteLine("Creational Patterns");
            WriteLine("------------------------");
            WriteLine("1 - Abstract Factory");
            WriteLine("2 - Method Factory");
            WriteLine("3 - Singleton");
            WriteLine("4 - Prototype");
            WriteLine("------------------------");
            WriteLine("Structural Patterns");
            WriteLine("------------------------");
            WriteLine("5 - Adapter");
            WriteLine("6 - Facade");
            WriteLine("7 - Composite");
            WriteLine("8 - Bridge");
            WriteLine("9 - Flyweight");
            WriteLine("10 - Proxy");
            WriteLine("------------------------");
            WriteLine("Behavioral Patterns");
            WriteLine("------------------------");
            WriteLine("11 -  Command");
            WriteLine("12 -  Mediator");
            WriteLine("13 -  Observer");
            WriteLine("14 - State");
            WriteLine("15 - Strategy");
            WriteLine("16 - Visitor");
            WriteLine("------------------------");

            var option = Convert.ToString(ReadLine());

            WriteLine("");
            WriteLine("------------------------");
            WriteLine("");

            switch (option)
            {
                case "1":
                
                    break;
                case "2":
                   
                    break;
                case "3":
                    ExecutorSingleton.Execute();
                    break;
                case "4":
                   
                    break;
                case "5":
                   
                    break;
                case "6":
                 
                    break;
                case "7":
                    ExecutionCommand.Execute();
                    break;
                case "8":
                    MediatorExecutor.Execute();
                    break;
                case "9":
                    ExecuteObserver.Execute();
                    break;
                    
                case "10":
                
                    break;
                case "11":
                   
                    break;
                case "12":
                   
                    break;
            }

            ReadKey();
            Clear();
            Main();
        }
    }
}
