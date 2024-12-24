using System;

namespace digit_units_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 100 and 999: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 100 && num <= 999)
            {


                int hundreds = num / 100;
                int tens = (num % 100) / 10;
                int ones = num % 10;

                Console.WriteLine("ones : {0}", ones);
                Console.WriteLine("tens : {0}", tens);
                Console.WriteLine("hundreds : {0}", hundreds);
            }

            else
            {
                Console.WriteLine("{0} is not between 100 and 999 !", num);
            }

            Console.ReadKey();
        }
    }
}
