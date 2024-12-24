using System;

class Program
{
    static void Main()
    {
        
        int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        
        Console.WriteLine("Array: " + string.Join(", ", array));

        
        Console.Write("Enter the number to search: ");
        int target = int.Parse(Console.ReadLine());

        
        int index = BinarySearch(array, target);

        
        if (index != -1)
        {
            Console.WriteLine($"Number {target} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Number {target} not found in the array.");
        }
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            
            if (array[mid] == target)
            {
                return mid;
            }

            
            if (array[mid] > target)
            {
                right = mid - 1;
            }
            else 
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}
