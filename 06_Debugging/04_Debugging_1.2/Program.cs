using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main_Vorlage()
		{
			Console.WriteLine($"Alle Zahlen von 65 bis 90:");

			for (int i = 65; i <= 90; i = i + 1)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();
		}

		static void Main()
		{
			Console.WriteLine($"Alle Grossbuchstaben von A bis Z:");

			for (int i = 65; i <= 90; i = i + 1)
			{
				char capitalLetter = Convert.ToChar(i);
				Console.Write($"{capitalLetter} ");
			}
			Console.WriteLine();
		}
	}
}
