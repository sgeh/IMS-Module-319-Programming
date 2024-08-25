
int a = 5;
int b = 0;

Console.WriteLine($"Bitte geben Sie b ein: ");

string bInput = Console.ReadLine();
b = Convert.ToInt32(bInput);

int c = a * b;
Console.WriteLine($"({a} * {b}) = {c}");
