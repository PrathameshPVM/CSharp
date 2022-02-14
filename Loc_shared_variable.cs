using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int fact = 2;//shared variable
        static void factorial()
        {
            int fact = 1;//locat variable
            Console.WriteLine("value of fact local varialbe inside method " +fact);

        }
        static void Main (string[] args)
        {
            factorial();
            Console.WriteLine("fact inside main  = {0}", fact);
            Console.ReadLine();

        }
    }
}