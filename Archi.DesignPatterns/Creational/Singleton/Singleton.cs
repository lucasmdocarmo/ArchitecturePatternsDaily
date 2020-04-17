using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Creational.Singleton
{
    internal class Singleton
    {
        private static Singleton Instance { get; set; } = new Singleton();

        public int calledTimes { get; set; } = 0;

        public Singleton()
        {
            WriteLine("Initialization of Singleton Class");
            calledTimes++;
            WriteLine("Initialization of Singleton Class...so far "  + calledTimes + " => this should NOT CHANGE");
        }

        public static Singleton NewInstance
        {
            get
            {
                WriteLine("Called Instance Already Created via Constructor");
                return Instance;
            }
        }
    }
}
