
Console.WriteLine("[ a * (b + c) = d ]");

Console.WriteLine("Bitte geben Sie a ein:");
string aInput = Console.ReadLine();
int a = Convert.ToInt32(aInput);

Console.WriteLine("Bitte geben Sie b ein:");
string bInput = Console.ReadLine();
int b = Convert.ToInt32(bInput);

Console.WriteLine("Bitte geben Sie c ein:");
string cInput = Console.ReadLine();
int c = Convert.ToInt32(cInput);

int d = a * (b + c);
Console.WriteLine($"[ {a} * ({b} + {c}) = {d} ]");
