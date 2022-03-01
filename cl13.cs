using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl13
{
    public class program
    {
        public static void Main(string[] args)
        {
            ulong num, num1, rev = 0, rem;
            Console.WriteLine("Enter any number");
            num=Convert.ToUInt64(Console.ReadLine());

            for ( num1 = num; num1 >0; num1=num1/10)
            {
                rem = num1 % 10;
                rev = rev * 10 + rem;

            }
            Console.WriteLine("Rev of "+num +"is " +rev);

        }
    }
}

