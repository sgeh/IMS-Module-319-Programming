using System;

namespace Bwz.Rappi
{
	public class Program
	{
		static void Main()
		{
            Console.WriteLine("  // ------------------------------- \\\\");
            Console.WriteLine(" //   Willkommen - Wurzelberechnung   \\\\");
            Console.WriteLine("// ----------------------------------- \\\\");

            Console.WriteLine("\nBitte geben Sie eine positive Zahl zur Berechnung der Quadratwurzel nach Heron ein:");

            string inputAsString = Console.ReadLine();
            double input = 0;
            bool parseOk = double.TryParse(inputAsString, out input);

            if (parseOk && input > 0)
            { 
                double sqrt = CalculateSqrt(input);
                Console.WriteLine($"\nDie Quadratwurzel von {input:0.######} ist {sqrt:0.######}.");
            }
            else
            {
                Console.WriteLine($"\nUngültige Eingabe!");
            }
        }

        public static double CalculateSqrt(double input)
        {
            double last;
            double sqrt = 1;

            do
            {
                last = sqrt;
                sqrt = (sqrt + (input / sqrt)) / 2;
            }
            while (Math.Abs(last - sqrt) > 0.000006);

            return sqrt;
        }

        public static double CalculatePythagorasC(double a, double b)
        {
            return CalculateSqrt(a * a + b * b);
        }

        public static double CalculatePythagorasB(double c, double a)
        {
            double sqrt = c * c - a * a;
            if (sqrt > 0)
            {
                return CalculateSqrt(sqrt);
            }
            else
            {
                return 0;
            }
        }

        public static double CalculatePythagorasA(double c, double b)
        {
            double sqrt = c * c - b * b;
            if (sqrt > 0)
            {
                return CalculateSqrt(sqrt);
            }
            else
            {
                return 0;
            }
        }
    }
}
