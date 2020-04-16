using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Behavioral.Mediator
{
    public class MediatorExecutor
    {
        public static void Execute()
        {
            MediatorHandler mediator = new MediatorHandler();

            User user1 = new User("Lucas", mediator);
            User user2 = new User("Joao", mediator);
            User user3 = new User("Jose", mediator);
            User user4 = new User("Maria", mediator);

            //Register to Mediator
            mediator.Register(user1);
            mediator.Register(user2);
            mediator.Register(user3);
            mediator.Register(user4);
            //Display Items
            mediator.Notify();

            user1.Send("First Message");
            user2.Send("First Message");
            user3.Send("First Message");
            user4.Send("First Message");

            //Send to a User
            mediator.Send(user1, user2, "hi");
            mediator.Send(user2, user1, "hello, how are you?");

            Read();

        }

    }
}
