﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gen_stack
{
    public class program
    {
        public static void Main(string[] args)
        {
            Stack<int> stc = new Stack<int>();

            stc.Push(1);
            stc.Push(4);
            stc.Push(3);
            stc.Push(6);
            stc.Push(4);

            Console.WriteLine(stc.Pop());
            Console.WriteLine(stc.Peek());
            Console.WriteLine(stc.Peek());
            Console.WriteLine();

            foreach (int item in stc)
            {
                Console.WriteLine(item);
            }
        }
    }
}

