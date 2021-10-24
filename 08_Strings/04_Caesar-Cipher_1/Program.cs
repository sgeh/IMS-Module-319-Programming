using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			char[] encrypted = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

			for (int i = 0; i < encrypted.Length; i = i + 1)
			{
				Console.WriteLine($"Please enter a lower case character to encrypt ({i + 1} of {encrypted.Length}) or any other to abort:");
				string lowerCharInput = Console.ReadLine();

				if (lowerCharInput.Length == 0)
                {
					Console.WriteLine($"Empty input, encryption cancelled.");
					break;
				}

				char lowerChar = lowerCharInput[0];
				int asciiValue = Convert.ToInt32(lowerChar);

				if (asciiValue < 97 || asciiValue > 122)
                {
					Console.WriteLine($"Invalid input, encryption cancelled.");
					break;
				}
	
				encrypted[i] = Convert.ToChar(asciiValue - 30); // Convert from a to C (Caesar Cipher)
			}

			Console.WriteLine($"\nEncrypted data:");

			for (int i = 0; i < encrypted.Length; i = i + 1)
			{
				Console.Write($"{encrypted[i]}");
			}
			Console.WriteLine();
		}
	}
}
