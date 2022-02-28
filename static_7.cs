using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_7
{
    public class account
    {
        public int id;
        public string name;
        public static float roi;

        public account (int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        static account()
        {
            Console.WriteLine("static constructor is called ");
            roi = 9.5f;

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}

