Console.WriteLine($"Alle Grossbuchstaben von A bis Z:");

for (int i = 65; i <= 90; i = i + 1)
{
    char capitalLetter = Convert.ToChar(i);
    Console.Write($"{capitalLetter} ");
}
Console.WriteLine();