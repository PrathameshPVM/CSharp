using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //wap to accept 2 no. and display addtion of 2 no.
            int num1, num2, res;
            Console.WriteLine("enter height");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            num2 = Convert.ToInt32(Console.ReadLine());
            res = num1*num1;
            Console.WriteLine("Area of rectangle = " + res);
            Console.ReadLine();
        }
    }
}
