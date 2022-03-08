using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread3
{
    public class program
    {
        public void display()
        {
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine("i = "+i);
            }
        }
        public static void Main(string[] args)
        {
            program p = new program();
            Thread t1 = new Thread(p.display);
            Thread t2 = new Thread(p.display);
            Thread t3 = new Thread(p.display);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}

