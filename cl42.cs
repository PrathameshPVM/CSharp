using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 22, 33, 44, 55, 66 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Marks = {0}", marks[i]);
            }
        }
    }
}

