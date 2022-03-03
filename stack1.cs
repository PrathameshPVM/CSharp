using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace stack1
{
    class program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('B');
            st.Push('A');
            st.Push('C');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current Stack :");

            foreach (char c in st)
            {
                Console.WriteLine(c+" ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');

            Console.WriteLine("The Next Poppable value in stack : {0}", st.Peek);
            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            {
                Console.WriteLine(c+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing Value");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("Current stack: ");
            foreach(char c in st)
            {
                Console.WriteLine(c+" ");
            }
            Console.ReadLine();
        }

    }
}