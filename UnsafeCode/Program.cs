﻿ // See https://aka.ms/new-console-template for more information
using System;

namespace UnsafeCode
{
    class Test
    {
        static unsafe void Main(string[] args)
        {
            int var=20;
            int *p=&var;

            Console.WriteLine("Data is : {0}", var);
            Console.WriteLine("Address is : {0}", (int)p);
            Console.ReadKey();
        }
    }
}