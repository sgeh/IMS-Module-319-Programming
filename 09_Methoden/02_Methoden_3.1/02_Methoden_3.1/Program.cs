for (int i = 1; i < 21; i = i + 1)
{
    Console.WriteLine($"{i}: {Multiply(i, i)}");
}

for (double j = 0.1; j < 2.1; j = j + 0.1)
{
    Console.WriteLine($"{j}: {MultiplyF(j, j)}");
}

int Multiply(int x, int y)
{
    int result = x * y;
    return result; // shorter syntax: return (x * y);
}

double MultiplyF(double x, double y)
{
    return (x * y);
}
