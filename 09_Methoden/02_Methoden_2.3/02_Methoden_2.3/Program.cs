using System;

namespace Bwz.Rappi
{
	class Program
	{
        static void Main()
        {
            for (int i = 1; i < 21; i = i + 1)
            {
                PrintSquare(i);
            }
        }

        static void PrintSquare(int x)
        {
            Console.WriteLine($"{x * x}");
        }
    }
}
