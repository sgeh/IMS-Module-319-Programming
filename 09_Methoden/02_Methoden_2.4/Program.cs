using System;

namespace Bwz.Rappi
{
	class Program
	{
        static void Main()
        {
            for (int i = 1; i < 21; i = i + 1)
            {
                Console.Write($"{i}: ");
                PrintMultiplication(i, i);
            }

            for (double j = 0.1; j < 2.1; j = j + 0.1)
            {
                Console.Write($"{j}: ");
                PrintMultiplication(j, j);
            }
        }

        static void PrintMultiplication(int x, int y)
        {
            Console.WriteLine($"{x * y}");
        }

        static void PrintMultiplication(double x, double y)
        {
            Console.WriteLine($"{x * y}");
        }
    }
}
