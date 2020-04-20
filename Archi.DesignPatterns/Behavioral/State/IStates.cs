using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Daily.DesignPatterns.Behavioral.State
{
    public interface IStates<T> where T: class
    {
        T Running(T stat);
        T Stalled(T stat);
        T Stopped(T stat);
    }
}
 