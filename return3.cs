using System;

namespace returnn
{
    internal class @return3
    {
        static int divi(int a, int b, int div)
        {


            div = a / b;

            return div;
        }
        static void Main()
        {
            int a = 10, b = 5, div = 0;

            int result = divi(a, b, div);

            Console.WriteLine("Division is " + result);

        }
    }
}
