using Daily.DesignPatterns.Behavioral.Command;
using Daily.DesignPatterns.Behavioral.Mediator;
using Daily.DesignPatterns.Behavioral.Observer;
using Daily.DesignPatterns.Creational.Prototype;
using Daily.DesignPatterns.Creational.Singleton;
using System;
using static System.Console;

namespace Daily.DesignPatterns
{
    public class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("------------------------");
            WriteLine("Choose:");
            WriteLine("1 - Creational Patterns");
            WriteLine("2 - Structural Patterns");
            WriteLine("3 - Behavioral Patterns");
            WriteLine("------------------------");
            var option = Convert.ToString(ReadLine());

            switch (option)
            {
                case "1":
                    CreationalPatterns.Call();
                    break;
                case "2":
                    BehaivioralPatterns.Call(); 
                    break;
                case "3":
                    StructuralPatterns.Call();
                    break;
            }

            ReadKey();
            Clear();
            Main();
        }

    }
    public static class CreationalPatterns
    {
        public static void Call()
        {
            WriteLine("Choose:");
            WriteLine("\n");
            WriteLine("Creational Patterns");
            WriteLine("1 - Abstract Factory");
            WriteLine("2 - Method Factory");
            WriteLine("3 - Singleton");
            WriteLine("4 - Prototype");
            WriteLine("\n");

            var option = Convert.ToString(ReadLine());

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
                    ExecutePrototype.Execute();
                    break;
            }
        }

    }
    public static class BehaivioralPatterns
    {
        public static void Call()
        {
            WriteLine("Choose:");
            WriteLine("\n");
            WriteLine("Structural Patterns");
            WriteLine("1 - Adapter");
            WriteLine("2 - Facade");
            WriteLine("3 - Composite");
            WriteLine("4 - Bridge");
            WriteLine("5 - Flyweight");
            WriteLine("6 - Proxy");
            WriteLine("\n");

            var option = Convert.ToString(ReadLine());

            switch (option)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":
                  
                    break;
                case "4":
                 
                    break;
                case "5":
                   
                    break;
                case "6":
                   
                    break;
            }
        }
    }

    public static class StructuralPatterns
    {
        public static void Call()
        {
            WriteLine("Choose:");
            WriteLine("\n");
            WriteLine("Behavioral Patterns");
            WriteLine("1 -  Command");
            WriteLine("2 -  Mediator");
            WriteLine("3 -  Observer");
            WriteLine("4 - State");
            WriteLine("5 - Strategy");
            WriteLine("6 - Visitor");
            WriteLine("\n");


            var option = Convert.ToString(ReadLine());

            switch (option)
            {
                case "1":
                    ExecutionCommand.Execute();
                    break;
                case "2":
                    MediatorExecutor.Execute();
                    break;
                case "3":
                    ExecuteObserver.Execute();
                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
            }
        }
    }



}
