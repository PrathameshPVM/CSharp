using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashable1
{
    public class program
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("1", "zara Ali");
            ht.Add("2", "Raju");
            ht.Add("3", "Amit");
            ht.Add("4", "zara");
            ht.Add("5", "Ali");
            ht.Add("6", "vivek");
            ht.Add("7", "Ritesh");

            if (ht.ContainsValue("Aman"))
            {
                Console.WriteLine("The student name is already in the list");
            }
            else
            {
                ht.Add("8", "Aman");
            }
            // Get a collection of the keys.
            ICollection key = ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k+":"+ht[k]);
            }
            Console.ReadKey();
        }
    }
}

