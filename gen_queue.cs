using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gen_queue
{
    public class program
    {
        public static void Main(string[] args)
        {
            Queue<string> msgs = new Queue<string>();

            msgs.Enqueue("Message 1");
            msgs.Enqueue("Message 2");
            msgs.Enqueue("Message 3");
            msgs.Enqueue("Message 4");
            msgs.Enqueue("Message 5");

            Console.WriteLine(msgs.Dequeue());
            Console.WriteLine(msgs.Peek());
            Console.WriteLine(msgs.Peek());

            Console.WriteLine();

            foreach (string msg in msgs)
            {
                Console.WriteLine(msg);
            }
        }
    }
}

