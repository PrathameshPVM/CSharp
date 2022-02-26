using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggrigation
{
    public class address
    {
        public string addressLine, city, state;
        public address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }

    }
    public class Employee
    {
        public int id;
        public string name;
        public address address; 
        public Employee(int id, string name, address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +
              address.addressLine + " " + address.city + " " + address.state);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            address a1 = new address("G-13, Sec-3", "Noida", "UP");
            Employee e1 = new Employee(1, "Sonoo", a1);
            e1.display();

        }
    }
}

