Console.WriteLine($"Bitte einen Kleinbuchstaben eingeben:");
bool doNext = true;

do
{
	string input = Console.ReadLine();
	char inputChar = Convert.ToChar(input);
	int newCharAsInt = Convert.ToInt32(inputChar) - 32;

	if (newCharAsInt >= 65 && newCharAsInt <= 90)
    {
		char newChar = Convert.ToChar(newCharAsInt);
		Console.WriteLine($"Konvertierter Character: {inputChar} zu {newChar}");
	}
	else
    {
		Console.WriteLine($"Ungültige Eingabe!");
		doNext = false;
	}
}
while (doNext);
