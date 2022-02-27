using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_1
{
    public interface drawable
    {
        void draw();
    }
    public class reactangle:drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class circle : drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            drawable d = new reactangle();
            d.draw();
            drawable d2 = new circle();
            d2.draw();
        }
    }
}

