using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main (string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                goto Even;
            Console.WriteLine("Number is Odd");
            goto End;
        Even:
            Console.WriteLine("Number is Even");
        End:;
        Console.ReadLine();
        }
        
    }
}