using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace queue1
{
    public class program
    {
        public static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');
            Console.WriteLine("Current queue: ");
            foreach (char c in q)
            {
                Console.WriteLine(c+"");
            }
            Console.WriteLine();
            Console.WriteLine("Removing Some Values");
            char ch=(char)q.Dequeue();
            Console.WriteLine(ch);

            Console.WriteLine("Removing Some Values");
            ch = (char)q.Dequeue();
            Console.WriteLine(ch);
        }
    }
}

