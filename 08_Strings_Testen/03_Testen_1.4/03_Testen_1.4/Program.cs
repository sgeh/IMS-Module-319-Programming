// Step 1
char[] encrypted = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

for (int i = 0; i < encrypted.Length; i = i + 1)
{
    Console.WriteLine($"Please enter a lower case character "
        + $"to encrypt ({i + 1} of {encrypted.Length}) or any other to abort:");

    // Step 2 (and 💡 Step 4)
    string lowerCharInput = Console.ReadLine();

    if (lowerCharInput.Length == 0) // 💡 Step 4, a
    {
        Console.WriteLine($"Empty input, encryption cancelled.");
        break;
    }

    char lowerChar = lowerCharInput[0];

    if (lowerChar < 'a' || lowerChar > 'z') // 💡 Step 4, b
    {
        Console.WriteLine($"Invalid input, encryption cancelled.");
        break;
    }

    int asciiValue = Convert.ToInt32(lowerChar);
    int asiiEncrypted = asciiValue - 30;
    
    if (asiiEncrypted > 'Z') // 💡 Step 4, c
    {
        asiiEncrypted = asiiEncrypted - 26;
    }

    char encryptedChar = Convert.ToChar(asiiEncrypted);

    // Step 3
    encrypted[i]= encryptedChar;
}

Console.WriteLine($"\nEncrypted data:");
Console.WriteLine(encrypted);




void Main_WithString() { 
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
}


void Main_WithArrays_Advanced()
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