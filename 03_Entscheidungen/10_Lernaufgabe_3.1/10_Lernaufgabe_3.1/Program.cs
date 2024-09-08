Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 6 ein:");

string diceInput = Console.ReadLine();
int dice = Convert.ToInt32(diceInput);

if (dice >= -6 && dice <= 6)
{
    /*
    if (number < 0)  // optional (Aufgabe b)
    {
        dice = -dice;
    }
    */
    Console.WriteLine($"Die Würfel sind gefallen: {dice}!");
}
else if (dice == 0)
{
    Console.WriteLine($"0 ist nicht erlaubt!");
}
else
{
    Console.WriteLine("Ungültige Eingabe!");
}