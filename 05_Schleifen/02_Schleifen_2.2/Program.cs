using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Bitte Zahl eingeben:");
			string inputAsString = Console.ReadLine();
			Console.WriteLine();

			int input = Convert.ToInt32(inputAsString);
			int i = 1;

			do
			{
				Console.WriteLine($"{i}");
				i = i + 1;
			}
			while (i <= input);
		}

		static void Main_Alternative()
		{
			Console.WriteLine("Bitte Zahl eingeben:");
			string inputAsString = Console.ReadLine();
			Console.WriteLine();

			int input = 0;
			int i = 1;

			do
			{
				Console.WriteLine($"{i}");
				input = Convert.ToInt32(inputAsString);
				i = i + 1;
			}
			while (i <= input);
		}
	}
}
