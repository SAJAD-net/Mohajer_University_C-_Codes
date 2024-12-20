using System;

namespace GCD
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.Write("- Enter the 1st number: ");
            int first_num = Convert.ToInt32(Console.ReadLine());

            Console.Write("- Enter the 2nd number: ");
            int second_num = Convert.ToInt32(Console.ReadLine());

            int gcd = GCD(first_num, second_num);

            Console.WriteLine($"\n- {first_num} and {second_num}'s GCD is {gcd} !");

            Console.ReadKey();
        }


        static int GCD(int first_num, int second_num)
        {
            while (second_num != 0)
            {
                int temp = second_num;
                second_num = first_num % second_num;
                first_num = temp;
            }

            return first_num;
        }
    }
}
