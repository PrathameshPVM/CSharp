using System;

namespace abstract_1
{
    abstract class person
    {
        public abstract void display();

        public void showdata()
        {
            Console.WriteLine("Show data non abstrsct method");
        }
    }
    class student :person
    {
        public override void display()
        {
            Console.WriteLine("hello from display method");
        }
    }
    class program
    {
        static void Main()
        {
            //person person = new person();Error since person is abstract class
            student s1 = new student();
            s1.display();
            s1.showdata();
        }
    }
}