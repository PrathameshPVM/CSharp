using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(String[] args)
        {
            int i, j;
            for(i=1;i<10;i++)
            {
                for(j=1;j<10;j++)
                {
                    Console.WriteLine(j + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}