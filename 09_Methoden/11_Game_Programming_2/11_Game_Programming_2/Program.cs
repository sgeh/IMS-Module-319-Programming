
Console.WriteLine("-----------------");
Console.WriteLine("| - Dice Game - |");
Console.WriteLine("-----------------\n");

Console.WriteLine("I've picked a number between 1 and 100.\n");

int randomNumber = new Random().Next(1, 101);
int guessCount = 0;
bool gameRunning = true;

while (gameRunning)
{
	guessCount++;
	Console.WriteLine("Can you guess my number? Let's try the next one...");
	string input = Console.ReadLine();
	int guess = Convert.ToInt32(input);

	Console.WriteLine();

	if (guess == randomNumber)
	{
		Console.WriteLine($"You're right after {guessCount} turns!");
		gameRunning = false;
	}
	else
	{
		Console.Write("Nope, sorry. ");

		if (guess > randomNumber)
		{
			Console.Write("My number is lower. ");
		}
		else
		{
			Console.Write("My number is higher. ");
		}
		Console.WriteLine("Next Round! Please wait...");
		Thread.Sleep(1500);
		Console.Clear();
	}
}

Console.WriteLine("Game finished...");
