using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
{ 
    public class program
    {
        delegate void del_display();

        public void display()
        {
            Console.WriteLine("hello from display method");
        }
        public static void Main(string[] args)
        {
            program p = new program();

            del_display d1= new del_display(p.display);
            d1();
        }
    }
}

