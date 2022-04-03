using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			int a = 0;
			int b = 0;
			Console.WriteLine(" -- Willkommen: Diese App berechnet c = a/b -- ");

			Console.WriteLine("Bitte geben Sie a ein:");
            try { a = Convert.ToInt32(Console.ReadLine()); }
			catch { Console.WriteLine("a muss eine Ganzzahl sein.");  }

			Console.WriteLine("Bitte geben Sie b ein:");
			try { b = Convert.ToInt32(Console.ReadLine()); }
			catch { Console.WriteLine("b muss eine Ganzzahl sein."); }

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
