using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_specifier2
{
    class ProtectedTest
    {
         protected string name="Shashikant"
            protected void Msg(string msg)
        {
            Console.WriteLine("Hello "+msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProtectedTest protectedTest = new ProtectedTest();
            Console.WriteLine("Hello " + protectedTest.name);
            ProtectedTest.Msg("Shyam");
        }
    }
}
//Compile time error
//'ProtectedTest.name' is inaccessible due to its protection level.
