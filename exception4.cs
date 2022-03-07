using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception4
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("enter number1");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            try
            {
                res = num / n;
            }
            catch (Exception ee)
            {
                Console.WriteLine("catch block is executing");
                Console.WriteLine("Connot divide by zero");

            }
            finally
            {
                Console.WriteLine("Finally Block is executing");
                Console.WriteLine("Res = "+res);
            }
            Console.WriteLine("BYE");
        }
    }
}

