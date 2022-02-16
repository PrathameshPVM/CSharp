using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class Program
    {
        static int add(int a,int b)
        {
            return a + b;
        }
        static int add(int a,int b,int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("addition of 2 no. " + add(1, 2));
            Console.WriteLine("addition of 3 no. " +add(1,2, 3));
        }
    }
}

