
int spaghetti = 0;
int cannelloni = 0;
int pizza = 0;
bool doAbort = false;

while (!doAbort)
{
	Console.WriteLine("\nBitte Menü auswählen:");
	Console.WriteLine("\t1) Spaghetti");
	Console.WriteLine("\t2) Cannelloni");
	Console.WriteLine("\t3) Pizza");
	Console.WriteLine("\t...andere Eingabe beendet die Menü-Auswahl.");

	string option = Console.ReadLine();

	switch (option)
	{
		case "1":
			{
				Console.WriteLine("Spaghetti sind notiert.");
				spaghetti++;
				break;
			}
		case "2":
			{
				Console.WriteLine("Cannelloni sind notiert.");
				cannelloni++;
				break;
			}
		case "3":
			{
				Console.WriteLine("Pizza ist notiert.");
				pizza++;
				break;
			}
		default:
			{
				doAbort = true;
				break;
			}
	}
}

Console.WriteLine("Sie haben gewählt:");
Console.WriteLine($"\t{spaghetti} x Spaghetti");
Console.WriteLine($"\t{cannelloni} x Cannelloni");
Console.WriteLine($"\t{pizza} x Pizza");

