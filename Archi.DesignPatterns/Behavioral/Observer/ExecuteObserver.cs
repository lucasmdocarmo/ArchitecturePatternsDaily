using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Observer
{
    public class ExecuteObserver
    {
        public static void Execute()
        {
            IObserver myObserver1 = new User("Lucas");
            IObserver myObserver2 = new Account("10", myObserver1 as User);

            Subject subject = new Subject();

            subject.Register(myObserver1);
            subject.Register(myObserver2);

            Console.WriteLine(" Setting Value = 1. If The FLAG Changes. Everyone is Notified.");
            subject.ChangeValue(1);
            subject.HasChanged = true;

            Console.WriteLine(" Setting Value = 2. If The FLAG Changes. Everyone is Notified.");
            subject.Unregister(myObserver1);
            subject.HasChanged = false;


            subject.HasChanged = false;
            subject.ChangeValue(2);
           
            subject.Register(myObserver1);
            Console.WriteLine("Setting Value = 3. If The FLAG Changes. Everyone is Notified.");
            subject.ChangeValue(3);

        }
    }
}
