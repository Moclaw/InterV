using System;

namespace fibonacci2
{
    class Program
    {
        static void Main2(string[] args)
        {
            int i;
            Console.Write("10 so dau tien cua day so Fibonacci: \n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", fibonacci2(i));
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        public static int fibonacci2(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return fibonacci2(n - 1) + fibonacci2(n - 2);
            }
        }
    }
}
