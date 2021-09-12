using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("-----------------");
			Console.WriteLine("| Repeater Game |");
			Console.WriteLine("-----------------\n");

			bool gameRunning = true;

			while (gameRunning)
            {
				Console.WriteLine("Do Next Repetition? (y = yes)");
				string input = Console.ReadLine();
				Console.WriteLine();

				if (input != "y")
                {
					gameRunning = false;
				}
            }
			Console.WriteLine("Game finished...");
		}
	}
}
