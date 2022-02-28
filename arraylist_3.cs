using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_3

{
    public class program
    {
        public static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(25);
            a1.Add(21);
            a1.Add(3);

            Console.WriteLine("array list collection without sorting");

            foreach(int i in a1)
            {
                Console.WriteLine("Student Roll no"+i);
            }
            a1.Sort();
            Console.WriteLine("array list collection with sorting");

            foreach (int i in a1)
            {
                Console.WriteLine("Student Roll no :"+i);
            }
        }
    }
}

