using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_ref
{
    class Program
    {
        static void passbyref(ref int x)
        {
            x++;
            Console.WriteLine("value inside passbyref method is " + x);
        }
        static void Main()
        {
            int k = 6;
            passbyref(ref k);
            Console.WriteLine("value after calling method in main " + k);
        }
    }
}