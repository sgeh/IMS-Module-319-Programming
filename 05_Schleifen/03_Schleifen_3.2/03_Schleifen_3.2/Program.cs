
Console.WriteLine("Bitte Zahl eingeben:");
string inputAsString = Console.ReadLine();
Console.WriteLine(); 

int input = Convert.ToInt32(inputAsString);

for (int i = 0; i <= input; i = i + 1)
{
	Console.WriteLine($"{i}");
}
