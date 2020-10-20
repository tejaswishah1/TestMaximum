using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestMaximum
{
    public class Maximum<T> where T : IComparable
    {
        public T[] value;

        public Maximum(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        void add(params int[] a) { }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);

            return sorted_values[sorted_values.Length - 1]; ////Returns maximum value 
        }

        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}

