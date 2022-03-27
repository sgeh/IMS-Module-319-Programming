using System;

namespace Bwz.Rappi
{
	class Program
	{
        static void Main()
        {
            Console.WriteLine("  // ------------------------------- \\\\");
            Console.WriteLine(" //   Willkommen - Wurzelberechnung   \\\\");
            Console.WriteLine("// ----------------------------------- \\\\");

            bool hasError = false;
            double input = 0;

            while (!hasError) // optional R006 (SHOULD)
            {
                if (input == 0) // optional R006 (SHOULD)
                {
                    Console.WriteLine("\nBitte geben Sie eine positive Zahl zur Berechnung der Quadratwurzel nach Heron ein:");
                    string inputAsString = Console.ReadLine();
                    double.TryParse(inputAsString, out input);
                }

                if (input > 0)
                {
                    double sqrt = CalculateSqrt(input);
                    Console.WriteLine($"\nDie Quadratwurzel von {input:0.######} ist {sqrt:0.######}.");

                    // optional R006 (SHOULD)
                    Console.WriteLine("\nMöchten Sie mit der letzten berechnung fortfahren? [y]=YES");
                    string doContinue = Console.ReadLine();

                    if (doContinue == "n")
                    {
                        input = 0;
                    }
                    else
                    {
                        input = sqrt;
                    }
                }
                else
                {
                    Console.WriteLine($"\nUngültige Eingabe!");
                    hasError = true; // optional R006 (SHOULD)
                }
            }
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
            while (Math.Abs(last - sqrt) > 0.000006);

            return sqrt;
        }
	}
}
