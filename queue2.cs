using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue2
{
    public class program
    {
        public static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Anand");
            q.Enqueue("Maria");
            q.Enqueue("Gomes");
            q.Enqueue("William");

            Console.WriteLine("Current queue: ");
            foreach (String c in q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            q.Enqueue("Vinita");
            q.Enqueue("Harshal");
            Console.WriteLine("Current queue: ");

            foreach (string c in q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing some values ");
            String ch = (String)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            Console.WriteLine("Current queue: ");

            foreach (string c in q)
            {
                Console.Write(c + " ");
            }

            ch = (String)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            Console.WriteLine("Current queue: ");

            foreach (string c in q)
            {
                Console.Write(c + " ");
            }

            Console.ReadLine();
        }
    }
}

