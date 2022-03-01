using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl10
{
    public class program
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any Alphabet");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("Entered Alphabet is VOWEL");
                    break;

                default:
                    Console.WriteLine("Entered Alphabel is NOT VOWEL");
                    break;
            }
        }
    }
}

