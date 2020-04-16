using Daily.DesignPatterns.Behavioral.Command;
using Daily.DesignPatterns.Behavioral.Mediator;
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
            WriteLine("------------------------");
            WriteLine("Structural Patterns");
            WriteLine("------------------------");
            WriteLine("4 - Adapter");
            WriteLine("5 - Facade");
            WriteLine("6 - Composite");
            WriteLine("------------------------");
            WriteLine("Behavioral Patterns");
            WriteLine("------------------------");
            WriteLine("7 -  Command");
            WriteLine("8 -  Mediator");
            WriteLine("9 -  Observer");
            WriteLine("10 - State");
            WriteLine("11 - Strategy");
            WriteLine("12 - Visitor");
            WriteLine("------------------------");

            var option = ReadKey();

            WriteLine("");
            WriteLine("------------------------");
            WriteLine("");

            switch (option.KeyChar)
            {
                case '1':
                
                    break;
                case '2':
                   
                    break;
                case '3':
                   
                    break;
                case '4':
                   
                    break;
                case '5':
                   
                    break;
                case '6':
                 
                    break;
                case '7':
                    ExecutionCommand.Execute();
                    break;
                case '8':
                    MediatorExecutor.Execute();
                    break;
                case '9':
                   
                    break;
            }

            ReadKey();
            Clear();
            Main();
        }
    }
}
