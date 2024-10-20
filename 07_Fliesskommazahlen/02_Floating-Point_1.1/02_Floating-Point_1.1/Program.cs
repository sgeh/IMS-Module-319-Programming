
Console.WriteLine("Bitte Startzahl eingeben: ");
string startAsString = Console.ReadLine();
int start = Convert.ToInt32(startAsString);

Console.WriteLine("Bitte Endzahl eingeben: ");
string endAsString = Console.ReadLine();
int end = Convert.ToInt32(endAsString);

if (start >= end)
{
	Console.WriteLine("Start muss vor dem Ende liegen.");
}
else
{
	int sum = start;
	Console.Write($"\n{start}");

	for (int i = start + 1; i <= end; i = i + 1)
	{
		sum = sum + i;
		Console.Write($" + {i}");
	}
	Console.WriteLine($" = {sum}");
}
