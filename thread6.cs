using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread6
{
    public class program
    {
        public void display1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("i = " + i);
            }

        }
        public void display2()
        {
            for (int i = 20; i <= 25; i++)
            {
                Console.WriteLine("i = " + i);
            }
        }

        public void display3()
        {
            for (int i = 10; i <= 15; i++)
            {
                Console.WriteLine("i = " + i);
            }
        }

        public static void Main(string[] args)
        {
            program p = new program();
            ThreadStart ts1 = new ThreadStart(p.display1);
            ThreadStart ts2 = new ThreadStart(p.display2);
            ThreadStart ts3 = new ThreadStart(p.display3);

            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);
            Thread t3 = new Thread(ts3);

            t1.Start();
            t2.Start();
            t3.Start();

        }
    }
}

