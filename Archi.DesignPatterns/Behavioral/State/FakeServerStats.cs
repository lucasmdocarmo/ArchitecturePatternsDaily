using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Behavioral.State
{
    public class FakeServerStats
    {
        public FakeServerStats(string name, bool isRunning)
        {
            Name = name;
            IsRunning = isRunning;
            ChangeStatus(Stats);

        }

        public string Name { get; set; }
        public string Stats { get; set; }
        public bool IsRunning { get; set; }

        public string GetCurrtentState()
        {
            return Stats;
        }
        public FakeServerStats ChangeStatus(string status)
        {
            this.Stats = status;
            switch(status)
            {
                case "Running":
                    IsRunning = true;
                    break;
                case "Stalled":
                    IsRunning = false;
                    break;
                case "Stop":
                    IsRunning = false;
                    break;

            }
            WriteLine("Status is now: " + Stats);
            return this;
        }

      
    }
}
