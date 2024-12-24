using System;

public class Program
{
    static void Main(string[] args) {

        int[,] matrix_a = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        int[,] matrix_b = {{11, 12, 13}, {14, 15, 16}, {17, 18, 19}};

        int[,] matrix_sum = new int[3,3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix_sum[i, j] = matrix_a[i, j] + matrix_b[i, j];
            }
        }


        Console.WriteLine("1st Matrix:\n");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matrix_a[i, j]}\t");
            }
            Console.WriteLine("");
        }

        
        Console.WriteLine("\n2nd Matrix:\n");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matrix_b[i, j]}\t");
            }
            Console.WriteLine("");
        }

        
        Console.WriteLine("\n1st Matrix + 2nd Matrix:\n");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matrix_sum[i, j]}\t");
            }
            Console.WriteLine("");
        }
    }
}