using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread7
{
    
    public class program
    {
        public static void callToChildThread()
        {
            try
            {
                Console.WriteLine("Child Thread Started");
                for (int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(i);

                }
                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Coudn't Catch the Thread Exception");
            }
        }
        public static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(callToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread t1 = new Thread(ts);
            t1.Start();

            Thread.Sleep(2000);

            Console.WriteLine("In Main : Aborting the child thread");
            t1.Abort();
            Console.ReadLine();
        }
    }
}

