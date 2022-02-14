using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //creating a user defined method 
        //method without parameters parameters and returing value
        static int factorial()
        {
            int fact = 1;
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            return fact;


        }
        static void Main(string[] args)
        {

            int result;
            result = factorial();
            Console.WriteLine("fact = {0}", result);
            Console.ReadLine();

        }
    }
}
