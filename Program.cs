using System;
using System.Collections.Generic;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] intArray = { 112, 344, 432, 555, 678 };
            Maximum<int> generic = new Maximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            Maximum<double> genericDouble = new Maximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333", "55", "999" };
            Maximum<string> genericString = new Maximum<string>(stringArray);
            genericString.PrintMaxValue();

        }
    }

}