using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap_1
{
    class student
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            
            student.id = "101";
            student.name = "Mohan Ram";
            student.email = "mohan@example.com";
              
            Console.WriteLine("ID = " + student.id);
            Console.WriteLine("Name = " + student.name);
            Console.WriteLine("Email = " + student.email);

        }
    }
}

