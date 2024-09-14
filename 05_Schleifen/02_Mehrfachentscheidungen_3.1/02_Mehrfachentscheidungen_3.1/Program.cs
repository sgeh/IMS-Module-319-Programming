
Console.WriteLine("Bitte wählen Sie die gewünschte Funktion aus:");
Console.WriteLine("\t1) Neue Transaktion erfassen.");
Console.WriteLine("\t2) Existierende Transaktion mutieren.");
Console.WriteLine("\t3) Alle Transaktionen auflisten.");
Console.WriteLine("\t4) Beenden");

string menuSelection = Console.ReadLine();

switch (menuSelection)
{
	case "1":
		Console.WriteLine("Bitte geben Sie einen Betrag [CHF] ein:");
		string input = Console.ReadLine();
		int chfValue = Convert.ToInt32(input);
		Console.WriteLine($"Der Betrag {chfValue}.- CHF wurde übermittelt.");
		break;

	case "2":
		Console.WriteLine("Keine existierenden Transaktionen vorhanden.");
		break;

	case "3":
		Console.WriteLine("Keine existierenden Transaktionen vorhanden.");
		break;
}
Console.WriteLine("Programm beendet.");
