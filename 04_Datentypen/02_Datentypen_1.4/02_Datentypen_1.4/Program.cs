Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 6 ein:");

string diceInput = Console.ReadLine();
long dice = Convert.ToInt64(diceInput);

if (dice == 0)
{
    Console.WriteLine($"0 ist nicht erlaubt!");
}
else if (dice >= -6 && dice <= 6)
{
    Console.WriteLine($"Die Würfel sind gefallen: {dice}!");
}
else
{
    Console.WriteLine("Ungültige Eingabe!");
}