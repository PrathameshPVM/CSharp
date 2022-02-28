using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_1
{ 

    class Program
    {
        void display()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.display();
        }
    }
}

