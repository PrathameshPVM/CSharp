using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_6
{
    public static class mymath
    {
        public static float pi = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Value of PI :"+mymath.pi);
            Console.WriteLine("Cube of 3 is :"+mymath.cube(3));
        }
    }
}

