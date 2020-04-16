using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Behavioral.Mediator
{
    internal class MediatorHandler : IMediator
    {
        List<User> participants = new List<User>();


        public void Notify()
        {
            WriteLine("At present, registered Participants are:");
            foreach (var item in participants)
            {
                Console.WriteLine("{0}", item.Name);
            }
        }

        public void Register(User user)
        {
            participants.Add(user);
        }

        public void Send(User user, string msg)
        {
            if (participants.Contains(user))
            {
                WriteLine("User: " + user.Name + " Message: " + msg);
            }
            else
            {
                WriteLine("User: " + user.Name + " Says: " + msg);
            }
        }

        public void Send(User user, User userTo, string msg)
        {
            if (participants.Contains(userTo))
            {
                WriteLine("User: " + user.Name + " Says to : " + userTo .Name + " Message:"+ msg + " At " + DateTime.Now);
            }
            else
            {
                WriteLine("User: " + user.Name + " Says: " + msg);
            }
        }
    }
}
