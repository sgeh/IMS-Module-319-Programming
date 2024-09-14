/* void Vorlage()
{
	Console.WriteLine("Bitte Wert zwischen 1-3 eingeben:");
	string inputValue = Console.ReadLine();
	if (inputValue == "1")
	{
		Console.WriteLine("Eins");
	}
	else if (inputValue == "2")
	{
		Console.WriteLine("Zwei");
	}
	else if (inputValue == "3")
	{
		Console.WriteLine("Drei");
	}
	else
	{
		Console.WriteLine("Etwas falsches");
	}
	Console.WriteLine(" wurde eingegeben.");
}
*/

Console.WriteLine("Bitte Wert zwischen 1-3 eingeben:");
string inputValue = Console.ReadLine();

switch (inputValue)
{
	case "1":
		Console.WriteLine("Eins");
		break;

	case "2":
		Console.WriteLine("Zwei");
		break;

	case "3":
		Console.WriteLine("Drei");
		break;

	default:
		Console.WriteLine("Etwas falsches");
		break;
}
Console.WriteLine(" wurde eingegeben.");
