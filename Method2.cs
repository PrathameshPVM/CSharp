using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("fact = " +fact);

        }
        static void Main(string[] args)
        {
            int num;
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            factorial(num);
            Console.ReadLine();
        }
    }
}