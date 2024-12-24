using System;

namespace is_even_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is an even number !", num);
            }
            else
            {
                Console.WriteLine("{0} is an odd number !", num);
            }

            Console.ReadKey();
        }
    }
}
