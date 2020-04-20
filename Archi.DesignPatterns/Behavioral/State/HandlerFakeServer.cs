using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Daily.DesignPatterns.Behavioral.State
{
    internal class HandlerFakeServer : IStates<FakeServerStats>
    {
        public HandlerFakeServer()
        {
            WriteLine("Fake Server Inicitated.");
            WriteLine("Stpes: RUNNING => STALLED => STOP ");
        }

        public FakeServerStats Running(FakeServerStats stat)
        {
            stat.Stats = "Running";
            var server = stat.ChangeStatus(stat.Stats);
            WriteLine("You have Iniciated the server.");
            return server;
        }
         
        public FakeServerStats Stalled(FakeServerStats stat)
        {
            if (stat.IsRunning)
            {
                WriteLine("You have Stalled the server. You Must Inicate Again in the next State or Stop.");
                stat.Stats = "Stalled";
                var server = stat.ChangeStatus(stat.Stats);
                return server;
            }
            else
            {
                var server = stat.ChangeStatus(stat.Stats);
                WriteLine("You tried to Stall the server, but the status is: {0}. You must Iniciate again", server.Stats);
                return server;
            }

        }

        public FakeServerStats Stopped(FakeServerStats stat)
        {
            if (!stat.IsRunning && stat.Stats == "Stalled")
            {
                WriteLine("Fake Server is Stoped. You Must Inicate Again in the next state.");
                stat.Stats = "Stopped";
                var server = stat.ChangeStatus(stat.Stats);
                return server;
            }
            else
            {
                var server = stat.ChangeStatus(stat.Stats);
                WriteLine("You tried to Stop the server, but the status is: {0}. You must Iniciate again", server.Stats);
                return server;
            }

        }
    }
}
