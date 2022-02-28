using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_1
{

    public class program
    {
        public static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Amit");
            ar.Add("Rahul");
            ar.Add("Raju");

            foreach (string obj in ar)
            {
                Console.WriteLine("Student Name : "+obj);
            }
        }
    }
}

