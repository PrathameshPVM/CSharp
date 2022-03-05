using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl51
{
    public class program
    {
        public static void Main(string[] args)
        {
            double n1, n2, res;

            Console.WriteLine("Enter First number :");
            n1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number :");
            n2 = Convert.ToDouble(Console.ReadLine());

            res = n1 * n2;
            Console.WriteLine(res);
        }
    }
}

