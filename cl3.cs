using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl3
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num1, num2, rev = 0, rem;

            Console.WriteLine("Enter any 4 digit number");

            num1=Convert.ToInt32(Console.ReadLine());

            num2 = num1;

            rem = num1 % 10;
            rev = rev * 10 + rem;
            num1 = num1 / 10;

            rem = num1 % 10;
            rev = rev * 10 + rem;
            num1 = num1 / 10;

            rem = num1 % 10;
            rev = rev * 10 + rem;
            num1 = num1 / 10;

            rem = num1 % 10;
            rev = rev * 10 + rem;
            num1 = num1 / 10;

            Console.WriteLine("Reverse :{0}={1}",num2,rev);
        }
    }
}

