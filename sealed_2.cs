using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_2
{
    sealed public class animal
    {
        public void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : animal
    {
        public void bark() 
        { 
            Console.WriteLine("barking..."); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            d.bark();

        }
    }
}

