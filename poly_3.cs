using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace poly_3
{
    public class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing......");
        }
    }
    public class rectangle:shape
    {
        public override void draw()
        {
            Console.WriteLine("its rectangle.......");
        }
    }
    public class circle:shape
    {
        public override void draw()
        {
            Console.WriteLine("its circle.......");
        }
    }
    public class program
    {
        public static void Main()
        {
            //shape s = new rectangle();
            //s.draw();
            shape s;
            s = new shape();
            s.draw();
            s=new rectangle();
            s.draw();
            s=new circle();
            s.draw();
        }
    }
}