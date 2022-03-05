using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl55
{
    public class program
    {
        public static void Main(string[] args)
        
            
            {
                int number;
                Console.WriteLine("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                
                if (number % 2 == 0)
                {
                    Console.WriteLine("Entered Number is an Even Number");
                }

                else
                {
                    Console.WriteLine("Entered Number is odd Number");
                }
                    

                Console.ReadLine();
            }
        
    }
}

