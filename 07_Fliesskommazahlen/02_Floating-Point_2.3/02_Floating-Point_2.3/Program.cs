
const double epsilon = 0.0000001;
double a = 0.2;
double b = 0.1;
double c1 = a + b;
double c2 = 0.3;

double delta = Math.Abs(c1 - c2);
bool isEqual = (delta < epsilon); // TODO: hier Ihre bessere Implementation
Console.WriteLine("a + b = c1");
Console.WriteLine($"{a} + {b} = {c1}");
Console.WriteLine($"c2 = {c2} => is c1 equal to c2? {isEqual} ");
