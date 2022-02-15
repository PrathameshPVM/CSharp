using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main()
        {
            float c, a, r;
            Console.WriteLine("Enter radius ");
            r = Convert.ToSingle(Console.ReadLine());
           
            c = 2 * 3.14f * r;
            

            a = 3.14f * r * r;
           

            Console.WriteLine("Circumfarance= " +c);
            Console.WriteLine("Enter Area= " +a);

            Console.ReadLine();
        }
    }
}