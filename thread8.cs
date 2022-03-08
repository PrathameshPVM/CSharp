using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread8
{
    public class program
    {
        public static void display()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("i = " + i);
                Thread.Sleep(500);
            }
        }

        public static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(display);
            Thread t1 = new Thread(display);
            Thread t2 = new Thread(display);

            t1.Start();
            t1.Join();
            t2.Start();
        }
    }
}

