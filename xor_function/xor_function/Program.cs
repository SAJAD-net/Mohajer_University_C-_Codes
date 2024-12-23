using System;

namespace xor_function
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;

            bool result = XOR(ref a, b);

            Console.WriteLine(a);
            Console.WriteLine($"a XOR b : {result}");

            Console.ReadKey();
        }

        static bool XOR(ref bool c, bool d)
        {
            c = false;

            if (c==d)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
