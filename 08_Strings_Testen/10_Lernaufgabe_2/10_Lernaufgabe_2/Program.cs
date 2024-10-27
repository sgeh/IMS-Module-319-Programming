/**
* Solution for exercise "Mexican Army Cipher" (additional task).
* 
* Remarks: "Caesar Code" solution is located at ..\04_Caesar-Cipher_1.
*/
char[] encrypted = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
char[] ciphers = { 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B' };

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

	int cipherIndex = asciiValue - 97; // Convert from a to 0, b to 1, etc...
	encrypted[i] = Convert.ToChar(ciphers[cipherIndex]);
}

Console.WriteLine($"\nEncrypted data:");

for (int i = 0; i < encrypted.Length; i = i + 1)
{
	Console.Write($"{encrypted[i]}");
}
Console.WriteLine();
