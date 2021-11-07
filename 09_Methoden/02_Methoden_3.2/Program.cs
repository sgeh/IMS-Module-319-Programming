using System;

namespace Bwz.Rappi
{
	class Program
	{
        static void Main()
        {
            for (int i = 1; i < 21; i = i + 1)
            {
                int output = 0;
                Multiply(i, i, out output);
                Console.WriteLine($"{i}: {output}");
            }

            for (double j = 0.1; j < 2.1; j = j + 0.1)
            {
                double output = 0;
                Multiply(j, j, out output);
                Console.WriteLine($"{j}: {output}");
            }
        }

        static void Multiply(int x, int y, out int res)
        {
            res = (x * y);
        }

        static void Multiply(double x, double y, out double res)
        {
            res = (x * y);
        }
    }
}
