using System;

namespace inheritance4
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
        public class dog:Animal
        {
            public void bark()
            {
                Console.WriteLine("Barking...");
            }
        }
        class program
        {
            public static void Main(string[] args)
            {
                dog d1 = new dog();

                d1.eat();
                d1.bark();
            }
        }

    }
}