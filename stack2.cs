using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack2
{
    public class program
    {
        public static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push("Amar");
            st.Push("Maria");
            st.Push("Gomes");
            st.Push("Wilson");
            Console.WriteLine("Current stack: ");

            foreach (string c in st)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();

            st.Push("Vinita");
            st.Push("Harshal");

            Console.WriteLine("The next possible value in stack : {0}",st.Peek());
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The next poppable value in stack: {0}", st.Pop());
            foreach (String c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

        }
    }
}

