
Console.WriteLine("  // ----------------------------- \\\\");
Console.WriteLine(" //  Willkommen - \"ggt\" Berechnung  \\\\");
Console.WriteLine("// --------------------------------- \\\\");

bool hasError = false;

while (!hasError) // optional R007 (SHOULD)
{ 
    Console.Write("\nBitte geben Sie a ein: ");

    string aAsString = Console.ReadLine();
    int a = Convert.ToInt32(aAsString);

    Console.Write("Bitte geben Sie b ein: ");

    string bAsString = Console.ReadLine();
    int b = Convert.ToInt32(bAsString);

    if (a > 0 && b > 0)
    { 
        double ggt = CalculateGgt(a, b);
        Console.WriteLine($"\nDer ggT von {a} und {b} ist {ggt}, weil {ggt} die grösste Zahl ist, die sowohl {a} als auch {b} ohne Rest teilt.");
    }
    else
    {
        Console.WriteLine($"\nUngültige Eingabe!");
        hasError = true; // optional R007 (SHOULD)
    }
}

int CalculateGgt(int a, int b)
{
    while (a != b)
    {
        if (a > b)
        {
            a = a - b;
        }
        else
        {
            b = b - a;
        }
    }
    return a;
}