using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Creational.Singleton
{
    internal class Singleton
    {
        private static Singleton Instance { get; set; } = new Singleton();
        private static object _lock = new Object();
        public int calledTimes { get; set; } = 0;

        public Singleton()
        {
            WriteLine("Initialization of Singleton Class");
            calledTimes++;
            WriteLine("Initialization of Singleton Class...so far " + calledTimes + " => this should NOT CHANGE");
        }

        public static Singleton NewInstance
        {
            get
            {
                if(Instance == null) 
                { 
                    lock(_lock) //Only a Single Thread
                    NewInstance = new Singleton(); 
                }
                WriteLine("Called Instance Already Created via Constructor");
                return Instance;
            }
            set
            {

            }
        }
    }
}
