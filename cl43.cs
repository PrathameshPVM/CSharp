using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl43
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 22, 33, 44, 55, 66 };
            
            int sum = 0;
            int i;
            for (i = 0; i < 5; i++)
            {
                sum = sum + marks[i];

            }
            Console.WriteLine("Sum of Marks = "+sum);
        }
    }
}

