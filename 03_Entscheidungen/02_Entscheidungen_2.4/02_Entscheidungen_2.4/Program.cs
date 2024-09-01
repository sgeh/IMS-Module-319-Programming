
Console.WriteLine("[ a * (b + c) = d ]");

Console.WriteLine("Bitte geben Sie a ein:");
string aInput = Console.ReadLine();
int a = Convert.ToInt32(aInput);

if (a > 0)
{
    Console.WriteLine("Bitte geben Sie b ein:");
    string bInput = Console.ReadLine();
    int b = Convert.ToInt32(bInput);

    if (b > 0)
    {
        Console.WriteLine("Bitte geben Sie c ein:");
        string cInput = Console.ReadLine();
        int c = Convert.ToInt32(cInput);

        if (c > 0)
        {
            int d = a * (b + c);
            Console.WriteLine($"[ {a} * ({b} + {c}) = {d} ]");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe!");
        }
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe!");
    }
}
else
{
    Console.WriteLine("Ungültige Eingabe!");
}
