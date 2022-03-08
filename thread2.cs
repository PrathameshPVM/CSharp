using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread2
{
    public class program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child Thread Start");
        }
        public static void Main(string[] args)
        {
            ThreadStart Childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main : Creating the child thread");

            Thread childThread=new Thread(Childref);
            childThread.Start();
            Console.ReadLine();
        }
    }
}

