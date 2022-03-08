using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread9
{
    public class program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Thread 0");

            }

        }
        public static void ThreadMethod1()
        {
              
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Thread 1");

            }

        }

        public static void Main(string[] args)
        {
            Thread t = new Thread(ThreadMethod);
            t.Start();
            t.Join();
            Thread t1 = new Thread(ThreadMethod1);
            t1.Start();
            Console.ReadLine();
        }
    }
}

