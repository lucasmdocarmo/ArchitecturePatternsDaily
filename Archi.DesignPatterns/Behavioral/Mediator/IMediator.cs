using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Mediator
{
    internal interface IMediator
    {
        void Notify();
        void Register(User user);
        void Send(User user, string msg);
        void Send(User user, User userTo, string msg);
    }
}
