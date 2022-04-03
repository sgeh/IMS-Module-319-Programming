using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
            Console.WriteLine(" -- Willkommen - Wurzelberechnung -- ")
            Console.WriteLine("\nBitte geben Sie eine positive Zahl " +
                "zur Berechnung der Quadratwurzel nach Heron ein:");

            double input = Convert.ToDouble(Console.ReadLine());
            double sqrt = CalculateSqrt(input);
            Console.WriteLine($"\nDie Quadratwurzel von {input} ist {sqrt}.");
        }
        static double CalculateSqrt(double input)
        {
            double last;
            double sqrt = 1;

            do
            {
                last = sqrt;
                sqrt = (sqrt + (input / sqrt)) / 2;
            }
            while Math.Abs(last - sqrt) > 0.000006;
            return input;
        }
	}
}
