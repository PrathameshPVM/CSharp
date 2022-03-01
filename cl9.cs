using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl8
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any colour code");
            string code=Console.ReadLine();

            switch (code)
            {
                case "blue":
                Console.WriteLine("You Have Selected Blue");
                
                break;

                case "green":
                    Console.WriteLine("you have selected green");
                    break ;

                default:
                    Console.WriteLine("Undifined Color");
                    break;
            }
        }
    }
}

