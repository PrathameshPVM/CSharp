using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception2
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter number First : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number Second : ");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            try
            {
                res = num / n;//error will come here and program terminates
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Divide by Zero");
            }
            Console.WriteLine("res = "+res);
            Console.WriteLine("BYE");
        }
    }
}

