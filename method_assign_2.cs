//create a class cirlce having fields radius and method calculatearea and calculatecircumferance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_assign_2
{
    class circle
    {
        public double radius;
        public double res; 

        public int area(double radius)
        {
            res = 3.14f*radius*radius;
            return (int)res; 
        }
        public int circum(double radius)
        {
            res = 2 * 3.14f * radius;
            return (int)res;
        }

       
    }
    class Program
    {
        public static void Main (string[] args)
        {
            circle circle = new circle();
            double b;

            Console.WriteLine("Enter Radius ");
            b = Convert.ToDouble(Console.ReadLine());

            
       
            Console.WriteLine(circle.area(b));
            Console.WriteLine(circle.circum(b));

        }

    }
}

