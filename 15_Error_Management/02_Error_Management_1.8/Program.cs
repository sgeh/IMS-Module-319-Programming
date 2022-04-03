using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(" -- Willkommen: Diese App berechnet c = a/b -- ");

            try
			{
				Console.WriteLine("Bitte geben Sie a ein:");
				int a = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Bitte geben Sie b ein:");

				try
				{
					int b = Convert.ToInt32(Console.ReadLine());
					int c = a / b;
					Console.WriteLine($"Das Resultat lautet: c={c}");
				}
				catch (FormatException nfe)
                {
					Console.WriteLine("b muss eine Ganzzahl sein.");
				}
				catch (DivideByZeroException dbze)
				{
					Console.WriteLine("Division /0 ist nicht erlaubt.");
				}
			}
			catch
			{
				Console.WriteLine("a muss eine Ganzzahl sein.");
			}
		}
	}
}
