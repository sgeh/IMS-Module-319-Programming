Console.WriteLine("Dieses Programm berechnet die Seite c in einem rechtwinkligen Dreieck.");
Console.WriteLine("Bitte geben Sie a ein:");
string aInput = Console.ReadLine();
double a;
bool aValid = double.TryParse(aInput, out a);

Console.WriteLine("Bitte geben Sie b ein:");
string bInput = Console.ReadLine();
double b;
bool bValid = double.TryParse(bInput, out b);

// Advanced - TryParse() with invariant culutre:
//  double.TryParse(bInput, NumberStyles.Number, CultureInfo.InvariantCulture, out b);

if (aValid && bValid)
{
	double c = CalculateC(a, b);
	Console.WriteLine("Die Länge von c ist:");
	Console.WriteLine($"{c}");
}
else
{
	Console.WriteLine("Ungültige Eingabe!");
}


double CalculateC(double a, double b)
{
	return Math.Sqrt(a * a + b * b);
}


bool CalculateC_Advanced(double a, double b, out double result)
{
	if (a >= 0 && b >= 0 )
    {
		result = Math.Sqrt(a * a + b * b);
		return true;
	}

	result = 0; // invalid input
	return false;
}
