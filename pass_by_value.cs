using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_value
{
    class Program
    {
        static void passbyvalue(int x)
        {
            x++;
            Console.WriteLine("Value inside pass by value is {0}",x);
        }
        static void Main()
        {
            int k = 6;
            passbyvalue(k);
            Console.WriteLine(k);
        }
    }
}