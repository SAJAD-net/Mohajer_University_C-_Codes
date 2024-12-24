using System;

namespace Fibonacci_sequence_input_2nd_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Fibonacci sequence to generate: ");
            int count = Convert.ToInt32(Console.ReadLine());
            
            int a = 0;
            int b = 1;
            int fib = 0;
            Console.Write("{0} {1} ", 0, 1);

            for (int i = 2; i < 20; i++)
            {
                fib = a + b;
                Console.Write("{0} ", fib);
                a = b;
                b = fib;
            }

            Console.ReadKey();
        }
    }
}
