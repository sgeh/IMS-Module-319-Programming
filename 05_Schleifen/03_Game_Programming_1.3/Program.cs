using System;
using System.Threading;

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
				else
                {
					Console.WriteLine("Next Round! Please wait...");
					Thread.Sleep(1500);
					Console.Clear();
				}
            }
			Console.WriteLine("Game finished...");
		}
	}
}
