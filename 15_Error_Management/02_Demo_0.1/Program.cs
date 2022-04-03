using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
            /**
             * Auf welchen Zeilen können überall Fehler auftreten?
             */

            Console.WriteLine("  // ------------------------------- \\\\");
            Console.WriteLine(" //  Diese Applikation rechnet a / b  \\\\");
            Console.WriteLine("// ----------------------------------- \\\\");

            Console.WriteLine("\nBitte geben Sie a ein:");

            string aAsString = Console.ReadLine();
            int a = Convert.ToInt32(aAsString);

            Console.WriteLine("\nBitte geben Sie b ein:");
            string bAsString = Console.ReadLine();
            int b = Convert.ToInt32(bAsString);

            int c = a / b;
            Console.WriteLine("\\\\ ----------------------------------- //");
            Console.WriteLine($" \\\\        Das Resultat lautet: {c}     //");
            Console.WriteLine("  \\\\ --------------------------------//");
        }
	}
}
