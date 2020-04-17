using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Observer
{
    internal interface IObservable
    {
        void Register(IObserver _observer);
        void Unregister(IObserver _observer);
        void Notify(int value);
    }
}
