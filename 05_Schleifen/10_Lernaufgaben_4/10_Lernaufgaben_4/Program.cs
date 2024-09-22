
Console.WriteLine("Bitte Startzahl eingeben:");
string startAsString = Console.ReadLine();
int start = Convert.ToInt32(startAsString);

Console.WriteLine("Bitte Endzahl eingeben:");
string endAsString = Console.ReadLine();
int end = Convert.ToInt32(endAsString);

Console.WriteLine($"\n---------------");
Console.WriteLine($"  {start}");
int sum = start;

for (int i = start + 1; i <= end; i = i + 1)
{
	sum = sum + i;
	Console.WriteLine($"+ {i}");
}
Console.WriteLine($"= {sum}");
Console.WriteLine($"===============");



void Alternative_1() // optional
{
	Console.WriteLine("Bitte Startzahl eingeben:");
	string startAsString = Console.ReadLine();
	int start = Convert.ToInt32(startAsString);

	Console.WriteLine("Bitte Endzahl eingeben:");
	string endAsString = Console.ReadLine();
	int end = Convert.ToInt32(endAsString);

	int sum = 0;

	for (int i = start; i < end; i = i + 1)
    {
		sum = sum + i;
		Console.Write($"{i} + ");
	}

	sum = sum + end;
	Console.WriteLine($"{end} = {sum}");
}



void Alternative_2() // optional
{
	Console.WriteLine("Bitte Startzahl eingeben:");
	string startAsString = Console.ReadLine();
	int start = Convert.ToInt32(startAsString);

	Console.WriteLine("Bitte Endzahl eingeben:");
	string endAsString = Console.ReadLine();
	int end = Convert.ToInt32(endAsString);

	int sum = 0;

	for (int i = 0; i < end; i = i + 1)
	{
		if (i < start)
        {
			continue;
        }
		sum = sum + i;
		Console.Write($"{i} + ");
	}

	sum = sum + end;
	Console.WriteLine($"{end} = {sum}");
}