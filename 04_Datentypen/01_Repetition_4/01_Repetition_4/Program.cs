
int secretNumber = 123456;

Console.WriteLine("Bitte geben Sie Ihre Passwort ein:\n");

string passwordAsString = Console.ReadLine();
int password = Convert.ToInt32(passwordAsString);

if (password == secretNumber)
{
	Console.WriteLine("Passwort ist richtig!");
}
else if (password < 0)
{
	Console.WriteLine("Ungültige Eingabe!");
}
else
{
	Console.WriteLine("Passwort ist falsch!");
}
