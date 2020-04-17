using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Observer
{
    public interface IObserver
    {
        void Update(int value);
    }
}
