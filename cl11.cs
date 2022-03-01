using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl11
{
    public class program
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch>=0 && ch<=9)
            {
                Console.WriteLine("You have entered number ");
            }
            else if (ch>='a' && ch<='z')
            {
                Console.WriteLine("You have entered lower case alphabet");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("You have entered Upper case alphabet");
            }
            else
                switch (ch)
                {
                    case ' ':
                    case '\n':
                    case '\t':
                    case '\r':
                    case '\f':
                        Console.WriteLine("You have entered wide space character");
                        break;

                    default:
                        Console.WriteLine("You have entered special character");
                        break;
                }
        }
    }
}

