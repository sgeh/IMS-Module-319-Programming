// Aufgabe 1.1 mit Konstanten
const double priceSpaghetti = 25.60;
const double priceCannelloni = 28.35;
const double pricePizza = 23.80;

double total = 0;

int spaghetti = 0;
int cannelloni = 0;
int pizza = 0;
bool doAbort = false;

while (!doAbort)
{
	Console.WriteLine("\nBitte Menü auswählen:");
	Console.WriteLine($"\t1) Spaghetti  {priceSpaghetti,10:0.00} CHF"); // 1.2
	Console.WriteLine($"\t2) Cannelloni {priceCannelloni,10:0.00} CHF"); // 1.2
	Console.WriteLine($"\t3) Pizza      {pricePizza,10:0.00} CHF"); // 1.2
	Console.WriteLine("\t...andere Eingabe beendet die Menü-Auswahl.");

	string option = Console.ReadLine();

	switch (option)
	{
		case "1":
			{
				Console.WriteLine("Spaghetti sind notiert.");
				spaghetti++;
				total = total + priceSpaghetti; // 1.3
				break;
			}
		case "2":
			{
				Console.WriteLine("Cannelloni sind notiert.");
				cannelloni++;
				total = total + priceCannelloni; // 1.3
				break;
			}
		case "3":
			{
				Console.WriteLine("Pizza ist notiert.");
				pizza++;
				total = total + pricePizza; // 1.3
				break;
			}
		default:
			{
				doAbort = true;
				break;
			}
	}
}



Console.WriteLine("Sie haben gewählt:"); // Aufgabe 1.2
Console.WriteLine($"\t{spaghetti} x Spaghetti   à  {priceSpaghetti:00.00} CHF");
Console.WriteLine($"\t{cannelloni} x Cannelloni  à  {priceCannelloni:00.00} CHF");
Console.WriteLine($"\t{pizza} x Pizza       à  {pricePizza:0.00} CHF");
Console.WriteLine("-------------------------------------");
Console.WriteLine($" Total:                   {total,6:0.00} CHF");
Console.WriteLine("=====================================");

/**
 * Zusatzaufgabe:
 * double totalSpaghetti = spaghetti * priceSpaghetti;
 * double totalCannelloni = cannelloni * priceCannelloni;
 * double totalPizza = pizza * pricePizza;
 * 
 * Console.WriteLine("Sie haben gewählt:");
 * Console.WriteLine($"\t{spaghetti} x Spaghetti   à  {priceSpaghetti,6:00.00} = {totalSpaghetti,6:0.00} CHF");
 * Console.WriteLine($"\t{cannelloni} x Cannelloni  à  {priceCannelloni,6:00.00} = {totalCannelloni,6:0.00} CHF");
 * Console.WriteLine($"\t{pizza} x Pizza       à  {pricePizza,6:0.00} = {totalPizza,6:0.00} CHF");
 * Console.WriteLine("-----------------------------------------------");
 * Console.WriteLine($" Total:                             {total,6:0.00} CHF");
 * Console.WriteLine("===============================================");
 */
