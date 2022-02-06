 // See https://aka.ms/new-console-template for more information
using System;

namespace UnsafeCode1
{
    class Test1
    {
        static void Main(string[] args)
        {
            unsafe
            { 
                int var=20;
                int *p=&var;

                Console.WriteLine("Data is : {0}", var);
                Console.WriteLine("Address is : {0}", (int)p);
            }
            
            Console.ReadKey();
        }
    }
}
