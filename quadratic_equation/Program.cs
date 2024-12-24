using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());


        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic equation (a cannot be 0).");
            return;
        }


        double discriminant = b * b - 4 * a * c;

        Console.WriteLine($"\nThe quadratic equation is: {a}x^2 + {b}x + {c} = 0");


        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The equation has two real and distinct roots:");
            Console.WriteLine($"Root 1: {root1}");
            Console.WriteLine($"Root 2: {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("The equation has one real and repeated root:");
            Console.WriteLine($"Root: {root}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("The equation has two complex roots:");
            Console.WriteLine($"Root 1: {realPart} + {imaginaryPart}i");
            Console.WriteLine($"Root 2: {realPart} - {imaginaryPart}i");
        }
    }
}
