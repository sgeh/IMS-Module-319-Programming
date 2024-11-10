Console.WriteLine("Dieses Programm berechnet die Seite c in einem rechtwinkligen Dreieck.");
Console.WriteLine("Bitte geben Sie a ein:");
string aInput = Console.ReadLine();
double a = Convert.ToDouble(aInput);

Console.WriteLine("Bitte geben Sie b ein:");
string bInput = Console.ReadLine();
double b = Convert.ToDouble(bInput);

double c = CalculateC(a, b);
Console.WriteLine("Die Länge von c ist:");
Console.WriteLine($"{c}");


double CalculateC(double a, double b)
{
	double result = Math.Sqrt(a * a + b * b);
	return result;
}
