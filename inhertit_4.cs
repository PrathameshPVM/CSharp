using System;

namespace inherit_4
{
    public class animal
    {
        public void eat()
        {
            Console.WriteLine("Eating..........");
            
        }
    }
    public class dog:animal
    {
        public void bark()
        {
            Console.WriteLine("Barking..........");
        }
    }
    public class program
    {
        public static void Main()
        {
            dog d1 = new dog();

            d1.eat();
            d1.bark();
        }
        
    }
}