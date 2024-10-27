double[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

Console.Write("Bitte Anzahl zu summierender Zahlen eingeben: ");
string numberCountInput = Console.ReadLine();
double numberCount = Convert.ToDouble(numberCountInput);

if (numberCount <= 10)
{
	for (int i = 0; i < numberCount; i = i + 1)
	{
		Console.Write($"{i + 1}: ");
		string iInput = Console.ReadLine();
		double iValue = Convert.ToDouble(iInput);
		numbers[i] = iValue;
	}

	double sum = 0;
	for (int i = 0; i < numberCount; i = i + 1)
	{
		sum = numbers[i] + sum;
	}
	Console.WriteLine($"Summe: {sum:0.00000}");
	// …
}
