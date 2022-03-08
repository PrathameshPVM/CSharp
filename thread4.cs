using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace thread4
{
    public class program
    {
        public void display()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
                Thread.Sleep(1000);
            }
        }
        public static void Main(string[] args)
        {
            program p = new program();
            ThreadStart ts = new ThreadStart(p.display);

            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            Thread t3 = new Thread(ts);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}

