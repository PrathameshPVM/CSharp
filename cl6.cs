using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl6
{
    public class program
    {
        public static void Main(string[] args)
        {
            float sp, cp;
            Console.WriteLine("Enter costprice and selling price");
            cp = Convert.ToSingle(Console.ReadLine());
            sp = Convert.ToSingle(Console.ReadLine());

            if (cp < sp)
            {
                Console.WriteLine("Profit amount is Rs : {0}", sp - cp);
            }
            else
            {
                Console.WriteLine("Loss amount is Rs : {0}",cp-sp);
            }
        }
    }
}

