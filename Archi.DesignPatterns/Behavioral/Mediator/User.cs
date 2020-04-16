using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Mediator
{
    internal class User 
    {
        protected IMediator _mediator;

        public User(string name, IMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public string Name { get; set; }

        public string GetUserName()
        {
            return Name;
        }

        public void Send(string msg)
        {
            _mediator.Send(this, msg);
        }
    }
}
