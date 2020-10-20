using System;
using System.Collections.Generic;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[] intArray = { a,b,c };
            Maximum<int> generic = new Maximum<int>(intArray);
            
            generic.PrintMaxValue();
        }
    }
    
}
