Console.WriteLine($"Alle Grossbuchstaben:");

for (int i = 0; i < 26; i = i + 1)
{
	for (int j = 0; j < i; j = j + 1)
	{
		char current = Convert.ToChar(j + 65);
		Console.Write($"{current} ");
	}
	Console.WriteLine();
}
