using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_4
{
    public class program
    {
        public static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(12);
            ar.Add(13);

            Console.WriteLine("array list colection without sorting");

            foreach (int i in ar)
            {
                Console.WriteLine("Student RNO : "+i);
            }

            ar.Insert(2, 17);
            Console.WriteLine("array list colection after adding element at 2 position");

            foreach(int i in ar)
            {
                Console.WriteLine("Student RNO : "+i);
            }
        }
    }
}

