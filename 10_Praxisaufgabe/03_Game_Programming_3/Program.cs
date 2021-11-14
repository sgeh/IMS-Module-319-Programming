using System;
using System.Threading;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			bool gameRunning = true;
			string field1 = " "; // enthält "O" für Spieler 1, "X" für Spieler 2
			string field2 = " "; // enthält "O" für Spieler 1, "X" für Spieler 2
			string field3 = " "; // enthält "O" für Spieler 1, "X" für Spieler 2
			string field4 = " "; // enthält "O" für Spieler 1, "X" für Spieler 2
			string field5 = " "; // enthält "O" für Spieler 1, "X" für Spieler 2
			string field6 = " "; // enthält "O" für Spieler 1, "X" für Spieler 2
			string field7 = " "; // enthält "O" für Spieler 1, "X" für Spieler 2
			string field8 = " "; // enthält "O" für Spieler 1, "X" für Spieler 2
			string field9 = " "; // enthält "O" für Spieler 1, "X" für Spieler 2
			string currentPlayer = "O"; // O steht für Spieler 1, X für Spieler 2

			while (gameRunning)
			{
				Console.WriteLine("Tic-Tac-Toe Spielfeld:");
				Console.WriteLine("----------------------");
				Console.WriteLine($"|1  {field1}  |2  {field2}  |3  {field3}  |");
				Console.WriteLine("----------------------");
				Console.WriteLine($"|4  {field4}  |5  {field5}  |6  {field6}  |");
				Console.WriteLine("----------------------");
				Console.WriteLine($"|7  {field7}  |8  {field8}  |9  {field9}  |");
				Console.WriteLine("----------------------");

				if (currentPlayer == "O") { Console.WriteLine($"Player 1 (0) ist am Zug.\n"); }
				else { Console.WriteLine($"Player 2 (X) ist am Zug.\n"); }

				Console.WriteLine("Bitte geben Sie 1-9 ein. Nur unbelegte Felder dürfen gesetzt werden.");

				string fieldInput = Console.ReadLine();
				if (fieldInput == "1" && field1 == " ") { field1 = currentPlayer; }
				else if (fieldInput == "2" && field2 == " ") { field2 = currentPlayer; }
				else if (fieldInput == "3" && field3 == " ") { field3 = currentPlayer; }
				else if (fieldInput == "4" && field4 == " ") { field4 = currentPlayer; }
				else if (fieldInput == "5" && field5 == " ") { field5 = currentPlayer; }
				else if (fieldInput == "6" && field6 == " ") { field6 = currentPlayer; }
				else if (fieldInput == "7" && field7 == " ") { field7 = currentPlayer; }
				else if (fieldInput == "8" && field8 == " ") { field8 = currentPlayer; }
				else if (fieldInput == "9" && field9 == " ") { field9 = currentPlayer; }

				if ((field1 == currentPlayer && field2 == currentPlayer && field3 == currentPlayer)
					|| (field4 == currentPlayer && field5 == currentPlayer && field6 == currentPlayer)
					|| (field7 == currentPlayer && field8 == currentPlayer && field9 == currentPlayer)
					|| (field1 == currentPlayer && field4 == currentPlayer && field7 == currentPlayer)
					|| (field2 == currentPlayer && field5 == currentPlayer && field8 == currentPlayer)
					|| (field3 == currentPlayer && field6 == currentPlayer && field9 == currentPlayer)
					|| (field1 == currentPlayer && field5 == currentPlayer && field9 == currentPlayer)
					|| (field7 == currentPlayer && field5 == currentPlayer && field3 == currentPlayer))
				{
					Console.WriteLine($"{currentPlayer} hat gewonnen!");
					gameRunning = false;
				}
				else if (field1 != " " && field2 != " " && field3 != " "
						&& field4 != " " && field5 != " " && field6 != " "
						&& field7 != " " && field8 != " " && field9 != " ")
				{
					Console.WriteLine("Unentschieden!");
					gameRunning = false;
				}
				else
				{
					if (currentPlayer == "O")
					{
						currentPlayer = "X";
					}
					else
					{
						currentPlayer = "O";
					}

					Console.WriteLine("Nächste Runde! Bitte warten...");
					Thread.Sleep(500);
					Console.Clear();
				}
			}
			Console.WriteLine("Game Over");
		}
	}
}