using System;

namespace abstract_2
{
    public abstract class shape
    {
        public abstract void draw();
    }
    public class rectangle:shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle..........");
        }
    }
    public class circle :shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle..........");
        }
    }
    public class program
    {
        public static void Main()
        {
            shape shape = new rectangle();
            shape.draw();
            shape shape1 = new circle();
            shape1.draw();
        }
    }
}