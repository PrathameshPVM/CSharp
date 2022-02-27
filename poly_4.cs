using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_4
{
    public class animal
    {
        public string color = "white";
    }
    public class dog : animal
    {
        public string color = "black";
    }
    public class program
    {
        public static void Main()
        {
            animal d= new dog();
            Console.WriteLine(d.color);
        }
    }
}