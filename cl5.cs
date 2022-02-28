using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl5
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter any two number");
            num1 =Convert.ToInt32(Console.ReadLine());
            num2 =Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("{0} is greater ", num1);
            }
            else
            {
                Console.WriteLine("{0} is greater ", num2);
            }
        }
    }
}

