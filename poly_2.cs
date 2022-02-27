using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace poly_2
{
    public class animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...........");
        }
    }
    public class dog : animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Bread..........");
            //base.eat();
        }
    }
    public class program
    {
        public static void Main()
        {
            animal a = new dog();
            a.eat();
        }
    }
}