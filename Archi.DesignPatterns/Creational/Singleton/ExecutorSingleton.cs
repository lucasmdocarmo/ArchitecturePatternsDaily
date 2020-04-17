using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Creational.Singleton
{
    public class ExecutorSingleton
    {
        public static void Execute()
        {
            WriteLine("Repetion of 3 being initialized");
            for (int i = 0; i <= 2; i++)
            {
                WriteLine("\n Repetion number: " + i);

                Console.WriteLine("Trying to create instance s1.");
                Singleton s1 = Singleton.NewInstance;
                Console.WriteLine("Trying to create instance s2.");
                Singleton s2 = Singleton.NewInstance;

                if (s1 == s2)
                {
                    Console.WriteLine("Only one instance exists.");
                }
                else
                {
                    Console.WriteLine("Different instances exist.");
                }
            }
           
            Console.Read();
        }
    }
}
