for (int i = 1; i < 21; i = i + 1)
{
    Console.Write($"{i}: ");
    PrintMultiplication(i, i);
}

for (double j = 0.1; j < 2.1; j = j + 0.1)
{
    Console.Write($"{j}: ");
    PrintMultiplicationF(j, j);
}

void PrintMultiplication(int x, int y)
{
    Console.WriteLine($"{x * y}");
}

void PrintMultiplicationF(double x, double y)
{
    Console.WriteLine($"{x * y}");
}
