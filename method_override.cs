using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_1
{
    public class animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating......");
        }
    }
    public class dog : animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Bread.....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            animal a = new dog();
            a.eat();
           
        }
    }
}

