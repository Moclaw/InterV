using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fibonacci1
{
    public class Program
    {
        public static int[] Fibonacci(int number)
        {
            int[] a = new int[number];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < number; i++)
            {
                a[i] = a[i - 2] + a[i - 1];
            }
            return a;
        }
        public static void Main(string[] args)
        {
            var b = Fibonacci(10);
            foreach (var elements in b)
            {
                Console.WriteLine(elements);
            }
        }
    }
}