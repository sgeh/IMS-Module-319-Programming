PrintWithFor();
PrintWithDoWhile();
PrintWithWhile();

void PrintWithFor()
{
    Console.WriteLine("for(...)");
    for (int i = 0; i < 3; i = i + 1)
    {
        Console.WriteLine(" > Hello World");
    }
}

void PrintWithDoWhile()
{
    Console.WriteLine("\ndo-while(...)");
    int j = 0;
    do
    {
        Console.WriteLine(" > Hello World");
        j = j + 1;
    }
    while (j < 3);
}

void PrintWithWhile()
{
    Console.WriteLine("\nwhile(...)");
    int k = 0;
    while (k < 3)
    {
        Console.WriteLine(" > Hello World");
        k = k + 1;
    }
}
