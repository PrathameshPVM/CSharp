using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class hello
    {
        public void sayhello()
        {
            Console.WriteLine("Hello first namespace");
        }
    }
    
}
namespace second
{
    public class hello
    {
        public void sayhello()
        {
            Console.WriteLine("Hello second namespace");
        }
    }
}
namespace namespace_2
{
    class program
    {
        public static void Main(string[] args)
        {
            first.hello h1 = new first.hello();
            second.hello h2 = new second.hello();

            h1.sayhello();
            h2.sayhello();
        }
    }
}

