using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {

        public static void Main()
        {
            //if else 
            //wap to accept 2 no and print greater no.
            int n1, n2;
            Console.WriteLine("enter 2 no.");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
                Console.WriteLine("n1 is greter");
            else
                Console.WriteLine("n2 is greater");




            Console.ReadLine();
        }
    }
}
