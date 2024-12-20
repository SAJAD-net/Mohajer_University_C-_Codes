using System;


namespace Kth_smallest
{
    public class Program
    {
        public void Main(string[] args)
        {
            int[] array = { 8, 10, 4, 3, 20, 15, 6, 2, 5, 9 };
            int k = 5;

            int result = FindKthSmallest(array, k);

            if (result != int.MinValue)
            {
                Console.WriteLine($"The Kth smallest number is : {result}");
            }
            else
            {
                Console.WriteLine("K is invalid !");
            }

            Console.ReadKey();
        }

        static int FindKthSmallest(int[] array, int k)
        {
            if (k <= 0 || k > array.Length)
            {
                return int.MinValue;
            }

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        count++;
                    }
                }

                if (count == k - 1)
                {
                    return array[i];
                }

            }

            return int.MinValue;
        }
    }
}
