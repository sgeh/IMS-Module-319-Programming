
Console.WriteLine("[ a * b = c ]");

Console.WriteLine("Bitte geben Sie a ein:");
string aInput = Console.ReadLine();
int a = Convert.ToInt32(aInput);

Console.WriteLine("Bitte geben Sie b ein:");
string bInput = Console.ReadLine();
int b = Convert.ToInt32(bInput);

int c = a * b;
Console.WriteLine($"[ {a} * {b} = {c} ]");
