using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl53
{
    public class program
    {
        public static void Main(string[] args)
        {
            double meter, feet;

            Console.WriteLine("Enter feet :");
            feet = Convert.ToDouble(Console.ReadLine());

            meter = feet / 3.2808399;

            Console.WriteLine(meter);
        }
    }
}

