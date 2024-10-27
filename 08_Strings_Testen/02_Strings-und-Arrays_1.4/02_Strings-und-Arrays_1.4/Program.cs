double sum = 0;
double[] numbers = { 1.41420, 2.71820, 3.14150 };
double[] results = { 0, 0, 0 };

for (int i = 0; i < numbers.Length; i = i + 1)
{
	results[i] = numbers[i] * numbers[i];
	sum = sum + numbers[i];
	Console.WriteLine($"{numbers[i]:0.00000}");
}

Console.WriteLine($"Summe: {sum:0.00000}\n");
Console.WriteLine("Nummern^2:");

for (int i = 0; i < results.Length; i = i + 1)
{
	Console.WriteLine($"{results[i]:0.00000}");
}


void Main_Alternative()
{
	double sum = 0;
	double[] numbers = { 1.41420, 2.71820, 3.14150 };
	double[] results = { 0, 0, 0 };

	for (int i = 0; i < numbers.Length; i = i + 1)
	{
		results[i] = numbers[i] * numbers[i];
		sum = sum + numbers[i];
		Console.WriteLine($"{numbers[i]:0.00000}");
	}

	Console.WriteLine($"Summe: {sum:0.00000}\n");
	Console.WriteLine("Nummern^2:");

	for (int i = 0; i < results.Length; i = i + 1)
	{
		sum = sum + results[i];
		Console.WriteLine($"{results[i]:0.00000}");
	}
	Console.WriteLine($"Summe: {sum:0.00000}\n\n");
	Console.WriteLine($"Summe total: {sum:00.00000}");
	Console.WriteLine($"             ========");
}
