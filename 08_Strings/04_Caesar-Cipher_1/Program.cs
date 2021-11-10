using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			string result = "";

			for (int i = 0; i < 10; i = i + 1)
			{
				Console.WriteLine($"Please enter a lower case character to encrypt ({i + 1} of 10) or any other to abort:");
				string lowerCharInput = Console.ReadLine();

				if (lowerCharInput == "a") { result = result + "C"; }
				else if (lowerCharInput == "b") { result = result + "D"; }
				else if (lowerCharInput == "c") { result = result + "E"; }
				else if (lowerCharInput == "d") { result = result + "F"; }
				else if (lowerCharInput == "e") { result = result + "G"; }
				else if (lowerCharInput == "f") { result = result + "H"; }
				else if (lowerCharInput == "g") { result = result + "I"; }
				else if (lowerCharInput == "h") { result = result + "J"; }
				else if (lowerCharInput == "i") { result = result + "K"; }
				else if (lowerCharInput == "j") { result = result + "L"; }
				else if (lowerCharInput == "k") { result = result + "M"; }
				else if (lowerCharInput == "l") { result = result + "N"; }
				else if (lowerCharInput == "m") { result = result + "O"; }
				else if (lowerCharInput == "n") { result = result + "P"; }
				else if (lowerCharInput == "o") { result = result + "Q"; }
				else if (lowerCharInput == "p") { result = result + "R"; }
				else if (lowerCharInput == "q") { result = result + "S"; }
				else if (lowerCharInput == "r") { result = result + "T"; }
				else if (lowerCharInput == "s") { result = result + "U"; }
				else if (lowerCharInput == "t") { result = result + "V"; }
				else if (lowerCharInput == "u") { result = result + "W"; }
				else if (lowerCharInput == "v") { result = result + "X"; }
				else if (lowerCharInput == "w") { result = result + "Y"; }
				else if (lowerCharInput == "x") { result = result + "Z"; }
				else if (lowerCharInput == "y") { result = result + "A"; }
				else if (lowerCharInput == "z") { result = result + "B"; }
				else
				{
					Console.WriteLine($"Invalid input, encryption cancelled.");
					break;
				}
			}

			Console.WriteLine($"\nEncrypted data:\n{result}");
		}


		static void Main_WithArrays()
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

				int asciiEncrypted = asciiValue - 30;  // convert from a to C (Caesar Cipher)

				/**
				 * Optional - edge case:
				 *  the result may be larger than 'Z' (90)
				 *  e.g. 'z' - 30 (122 - 30) results in '\' (92), thus reduce result by 26
				 *  which means,
				 *    > '[' (91) results in 'A',
				 *    > '\' (92) results in 'B'
				 *    > ...
				 */
				if (asciiEncrypted > 90)
				{
					asciiEncrypted = asciiEncrypted - 26;
				}
				encrypted[i] = Convert.ToChar(asciiEncrypted);
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