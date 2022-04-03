using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(" -- Willkommen: Diese App berechnet c = a/b -- ");

			Console.WriteLine("Bitte geben Sie a ein:");
			int a = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Bitte geben Sie b ein:");
			int b = Convert.ToInt32(Console.ReadLine());

			try
			{
				int c = a / b;
				Console.WriteLine($"Das Resultat lautet: c={c}");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Division /0 ist nicht erlaubt.");
			}
		}
	}
}
