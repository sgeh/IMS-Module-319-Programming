using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
            Console.WriteLine("Divisionsprogramm");
            Console.WriteLine("--\n");
            Console.WriteLine("Bitte geben Sie den Dividend ein:");

            string dividendAsString = Console.ReadLine();
            double dividend = Convert.ToDouble(dividendAsString);

            Console.WriteLine("Bitte geben Sie den Divisor ein:");

            string divisorAsString = Console.ReadLine();
            double divisor = Convert.ToDouble(divisorAsString);

            if (divisor != 0)
            {
                double result = dividend / divisor;
                Console.WriteLine($"Das Divisionsresultat lautet:\n{result:0.####}");
            }
            else
            {
                Console.WriteLine($"Ungültige Eingabe!");
            }
        }
	}
}
