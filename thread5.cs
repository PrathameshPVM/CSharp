using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread5
{
    public class program
    {
        public static void CallToChildThraed()
        {
            Console.WriteLine("Child Thread Starts");
            int sleepfor = 5000;

            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        public static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThraed);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();

        }
    }
}

