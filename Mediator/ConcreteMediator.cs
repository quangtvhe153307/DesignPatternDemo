using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteMediator : IMediator
    {
        private Friend friend1, friend2, boss;
        public Friend Friend1 { set {  friend1 = value; } }
        public Friend Friend2 { set {  friend2 = value; } }
        public Friend Boss { set { boss = value; } }

        public void Send(Friend fromFriend, Friend toFriend, string message)
        {
            if(toFriend.Status == "On")
            {
                Console.WriteLine("[{0} -> {1}] : {2} Last message posted {3}", fromFriend.Name, toFriend.Name, message, DateTime.Now);
                System.Threading.Thread.Sleep(1000);
            } else
            {
                Console.WriteLine("[{0} -> {1}] : {2}, you can not post message now. {3} is offline", fromFriend.Name, toFriend.Name, message, fromFriend.Name, toFriend.Name);
            }
        }
    }
}
