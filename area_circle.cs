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
            //wap to accept radius and print area and circ of circle
            int radius;
            float area, circ;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = (float)3.14f * radius * radius;
            circ = (float)2 * 3.14f * radius;
            Console.WriteLine("area " + area);
            Console.WriteLine("circ " + circ);
            Console.ReadLine();
        }
    }
}
