using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public delegate void EventHandler(string x);
    class EventHandling
    {
        public static event EventHandler add;
        public class Operation
        {
            public event EventHandler xyz;
            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz.Invoke(a);

                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        private static void CatchEvent1(string s)
        {
            Console.WriteLine("Method Calling1");
        }
        public static void ImplementEvent()
        {
            Operation obj = new Operation();
            obj.Action("Event Calling");
            Console.WriteLine();
            obj.xyz += new EventHandler(CatchEvent);
            obj.xyz += new EventHandler(CatchEvent1);
            obj.Action("Event Called");
        }
    }
}

