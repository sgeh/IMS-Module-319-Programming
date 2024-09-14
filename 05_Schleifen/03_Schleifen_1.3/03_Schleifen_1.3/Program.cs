
Console.WriteLine("Bitte Zahl eingeben:");
string inputAsString = Console.ReadLine();
Console.WriteLine(); 

int input = Convert.ToInt32(inputAsString);
int i = 0;
			
while (i <= input)
{
	/**
	 * Alternative (optional):
	 *  if (i % 2 == 0)
	 *  {
	 *     Console.WriteLine($"{i}");
	 *  }
	 */

	Console.WriteLine($"{i}");
	i = i + 1;
}
