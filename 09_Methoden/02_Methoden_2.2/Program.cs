using System;

namespace Bwz.Rappi
{
	class Program
	{
        static void Main()
        {
            const string hello = " > Hello World";
            PrintWithFor(hello);
            PrintWithDoWhile(hello);
            PrintWithWhile(hello);
        }

        static void PrintWithFor(string helloMessage)
        {
            Console.WriteLine("for(...)");
            for (int i = 0; i < 3; i = i + 1)
            {
                Console.WriteLine(helloMessage);
            }
        }

        static void PrintWithDoWhile(string helloMessage)
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

        static void PrintWithWhile(string helloMessage)
        {
            Console.WriteLine("\nwhile(...)");
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine(helloMessage);
                k = k + 1;
            }
        }
    }
}
