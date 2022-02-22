using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifier1
{
    class PublicTest
    {
        public string name = "Raju Kumar";
        public void msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicTest publictest = new PublicTest();
            // Accessing public variable  
            Console.WriteLine("Hello "+publictest.name);
            // Accessing public function  
            publictest.msg("Babu Bhaiya");
        }
    }
}