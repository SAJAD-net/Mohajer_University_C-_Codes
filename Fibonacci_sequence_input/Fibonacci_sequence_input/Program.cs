using System;

namespace Fibonacci_sequence_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Fibonacci sequence to generate: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", Calculate(i));
            }

            Console.ReadKey();
        }

        public static int Calculate(int n)
        {
            if (n < 2)
                return n;

            else
                return Calculate(n - 1) + Calculate(n - 2);

        }
    }
}
