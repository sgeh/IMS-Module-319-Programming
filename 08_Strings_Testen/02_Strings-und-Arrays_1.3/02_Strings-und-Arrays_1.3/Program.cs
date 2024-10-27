double sum = 0;
double[] numbers = { 1.41420, 2.71820, 3.14150 };

for (int i = 0; i < numbers.Length; i = i + 1)
{
	sum = sum + numbers[i];
	Console.WriteLine($"{numbers[i]:0.00000}");
}
Console.WriteLine($"Summe: {sum:0.00000}");
