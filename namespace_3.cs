using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using first;
using second;

namespace first
{
    public class hello
    {
        public void sayhello() 
        {
            Console.WriteLine("Hello from namespace");
        }
        
    }
}
namespace second
{
    public class welcome
    {
        public void saywelcome()
        {
            Console.WriteLine("Welcome Namespace");
        }
    }
}


namespace namespace_3
{ 
    public class program
    {
        public static void Main(string[] args)
        {
            hello h = new hello();
            welcome w = new welcome();

            h.sayhello();
            w.saywelcome();
        }
    }
}

