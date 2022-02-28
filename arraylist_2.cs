using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_2
{
    public class program
    {
        public static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);

            foreach (int i in ar)
            {
                Console.WriteLine("Student RollNo :"+i);
            }
            Console.WriteLine("Capacity :"+ar.Capacity);
            Console.WriteLine("Count :"+ar.Count);
        }
    }
}

