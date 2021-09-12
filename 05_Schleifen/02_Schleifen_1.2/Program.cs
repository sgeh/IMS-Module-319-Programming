using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Bitte Zahl eingeben:");
			string inputAsString = Console.ReadLine();
			int input = Convert.ToInt32(inputAsString);
			int i = 0;

			while (i < input)
            {
				Console.WriteLine("hello world!");
				i = i + 1;
			}
		}
	}
}
