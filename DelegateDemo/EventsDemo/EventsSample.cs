using System;
using EventsDemo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public delegate void DelEventHandler();
    class EventsSample
    {
        public static event DelEventHandler add;
        public static void Test()
        {
            add();
        }
        public static int Canada()
        {
            return 0;
        }
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("USA");
        }
        public static void England()
        {
            Console.WriteLine("England");
        }
    }
}