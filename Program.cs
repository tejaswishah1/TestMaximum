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

            Console.WriteLine("Enter First decimal value: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second decimal value: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third decimal value: ");
            double z = Convert.ToDouble(Console.ReadLine());

            double[] doubleArray = { x, y, z };
            Maximum<double> genericDouble = new Maximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            Console.WriteLine("Enter first value: ");
            string value1 = Console.ReadLine();
            Console.WriteLine("Enter second value: ");
            string value2 = Console.ReadLine();
            Console.WriteLine("Enter third value: ");
            string value3 = Console.ReadLine();

            string[] stringArray = {value1,value2,value3 };
            Maximum<string> genericString = new Maximum<string>(stringArray);
            genericString.PrintMaxValue();

        }
    }
    
}
