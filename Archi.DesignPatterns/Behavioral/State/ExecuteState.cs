using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.State
{
    public class ExecuteState
    {

        static FakeServerStats FakeServerStats = new FakeServerStats("Test", true);
        public static void Execute()
        {
            HandlerFakeServer handler = new HandlerFakeServer();

            handler.Running(FakeServerStats);
            handler.Stalled(FakeServerStats);
            handler.Stopped(FakeServerStats);

            Console.WriteLine("\n Wrong way"); 
            handler.Stalled(FakeServerStats);
            Console.WriteLine("\n Rigth way");
            handler.Running(FakeServerStats);
            handler.Stalled(FakeServerStats);
            handler.Stopped(FakeServerStats);
        }
    }
}
