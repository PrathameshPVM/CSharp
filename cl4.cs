using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl4
{
    public class program
    {
        public static void Main(string[] args)
        {
            int a = 32, b = 47, c, x;

            Console.WriteLine("a = {0} and b = {1}",a,b);

            c = a;
            x = b;
            a = x;
            b = c;

            Console.WriteLine("SWAPPED");
            Console.WriteLine("a = {0} and b = {1}",a,b);
        }
    }
}

