using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl57
{
    public class program
    {
        public static void Main(string[] args)


        {
            int Candiateage;

            Console.WriteLine("Input the age of the candidate : ");
            Candiateage = Convert.ToInt32(Console.ReadLine());

            if (Candiateage < 18)
            {
                Console.WriteLine("Sorry, You are not eligible to caste your vote.\n");
                Console.WriteLine(18 - Candiateage + "You would be able to caste your vote after %d year.\n");
            }

            else
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.\n");
            }

            Console.ReadLine();
        }

    }
}

