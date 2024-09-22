for (int i = 0; i < 26; i = i + 1)
{
	for (int j = 65; j <= 90; j = j + 1)
	{
		char current = Convert.ToChar(j);
		Console.Write($"{current} ");
	}
	Console.WriteLine();
}
