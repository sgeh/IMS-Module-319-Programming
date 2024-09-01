
int rangeStart = 50;
int rangeEnd = 100;
Console.WriteLine(
    $"Bitte positive Ganzzahl zwischen {rangeStart} und {rangeEnd} eingeben: \n",
    rangeStart,
    rangeEnd);

string inputAsString = Console.ReadLine();
int userInput = Convert.ToInt32(inputAsString);

userInput = (userInput < 0) ? userInput * -1 : userInput;
userInput = (userInput > rangeEnd) ? rangeEnd : userInput;
userInput = (userInput < rangeStart) ? rangeStart : userInput;

/**
	* Alternative:
	*   userInput = (userInput < 0)
	*		? userInput * -1
	*		: (userInput > rangeEnd)
	*			? rangeEnd
	*			: (userInput < rangeStart) ? rangeStart : userInput;
	*/
Console.WriteLine($"Ihre Eingabe (validiert): {userInput}");



void Vorlage()
{
	int rangeStart = 50;
	int rangeEnd = 100;
	Console.WriteLine(
		$"Bitte positive Ganzzahl zwischen {rangeStart} und {rangeEnd} eingeben: \n",
		rangeStart,
		rangeEnd);

	string inputAsString = Console.ReadLine();
	int userInput = Convert.ToInt32(inputAsString);

	if (userInput < 0) // mittels ? : lösen
	{
		userInput = userInput * -1;
	}
	if (userInput > rangeEnd) // mittels ? : lösen
	{
		userInput = rangeEnd;
	}
	if (userInput < rangeStart)  // mittels ? : lösen
	{
		userInput = rangeStart;
	}
	Console.WriteLine($"Ihre Eingabe (validiert): {userInput}");
}


