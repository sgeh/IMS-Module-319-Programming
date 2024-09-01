
Console.WriteLine($"Bitte geben Sie eine positive Ganzzahl ein:");

string numberInput = Console.ReadLine();
int number = Convert.ToInt32(numberInput);

if (number > 0)
{
    Console.WriteLine($"Eingabe akzeptiert!");
}

Console.WriteLine($"Programm wird beendet...");
