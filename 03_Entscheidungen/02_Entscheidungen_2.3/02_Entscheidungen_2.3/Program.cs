using System;

namespace Bwz.Rappi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Bitte geben Sie eine positive Ganzzahl ein:");

            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput);

            if (number > 0)
            {
                Console.WriteLine($"Eingabe akzeptiert!");
            }
            else
            {
                Console.WriteLine($"Ungültige Eingabe!");
            }
            Console.WriteLine($"Programm wird beendet...");
        }
    }
}
