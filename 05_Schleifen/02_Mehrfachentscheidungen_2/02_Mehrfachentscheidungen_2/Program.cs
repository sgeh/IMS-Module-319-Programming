Console.WriteLine("Bitte Wert eingeben:");
string valueAsString = Console.ReadLine();
int inputValue = Convert.ToInt32(valueAsString);

switch (inputValue)
{
	case 1:
		Console.WriteLine("Eins\n");
		break;

	case 2:
		Console.WriteLine("Zwei\n");
		break;

	case 3:
		Console.WriteLine("Drei\n");
		break;

	case 4:
	case 5:
		Console.WriteLine("Vier\n");
		break;

	case 6:
		Console.WriteLine("Sechs\n");
		break;

	default:
		Console.WriteLine("Etwas anderes...\n");
		break;
}
