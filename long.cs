using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 1236541623;
            long longValue = intValue;//implicit conversion from int to long
            Console.WriteLine("(long) {0} = {1}", intValue, longValue);

        }
    }
}

