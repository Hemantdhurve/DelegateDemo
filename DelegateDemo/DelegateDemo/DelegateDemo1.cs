using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate int operation(int a, int b);
    internal class DelegateDemo1
    {
       
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Addition123(int a, int b, int c)
        {
            return a + b;
        }

    }
}
