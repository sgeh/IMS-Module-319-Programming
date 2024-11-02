bool inputValid = true;
string firstName = "";

// read first name
Console.WriteLine("Bitte Vorname eingeben:");
int tryCountFirstName = 0;

do
{
    if (tryCountFirstName == 3)
    {
        inputValid = false;
        break;
    }

    tryCountFirstName = tryCountFirstName + 1;
    firstName = Console.ReadLine();
}
while (firstName.Length < 3);

Console.WriteLine("Bitte Nachname eingeben:");
string lastName = Console.ReadLine();

// output user data if valid
if (inputValid)
{

    Console.WriteLine($"\n{firstName} {lastName}");
}
else
{
    Console.WriteLine("Eingabe des Namens ungültig.");
}
