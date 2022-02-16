using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_out
{
    class Program
    {
        static void passbyout(out int x)
        {
            x = 5;
            x++;
            Console.WriteLine("value inside passbyref method is " + x);
        }
        static void Main()
        {
            int k;
            passbyout(out k);
            Console.WriteLine("value after calling method in main " + k);
        }
    }
}