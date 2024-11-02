const string hello = " > Hello World";
PrintWithFor(hello);
PrintWithDoWhile(hello);
PrintWithWhile(hello);

void PrintWithFor(string helloMessage)
{
    Console.WriteLine("for(...)");
    for (int i = 0; i < 3; i = i + 1)
    {
        Console.WriteLine(helloMessage);
    }
}

void PrintWithDoWhile(string helloMessage)
{
    Console.WriteLine("\ndo-while(...)");
    int j = 0;
    do
    {
        Console.WriteLine(helloMessage);
        j = j + 1;
    }
    while (j < 3);
}

void PrintWithWhile(string helloMessage)
{
    Console.WriteLine("\nwhile(...)");
    int k = 0;
    while (k < 3)
    {
        Console.WriteLine(helloMessage);
        k = k + 1;
    }
}
