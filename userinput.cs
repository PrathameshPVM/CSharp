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
            //wap to accet no. from the user and print sq
            int num, sq;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            sq = num * num;
            Console.WriteLine("Sq = " + sq);
            Console.ReadLine();
        }
    }
}
