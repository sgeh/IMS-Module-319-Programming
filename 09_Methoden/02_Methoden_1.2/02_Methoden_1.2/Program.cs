bool inputValid = true;
string firstName = "";
string lastName = "";

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

if (!inputValid)
{
    // read last name
    Console.WriteLine("Bitte Nachname eingeben:");
    int tryCountLastname = 0;

    do
    {
        if (tryCountLastname == 3)
        {
            inputValid = false;
            break;
        }

        tryCountLastname = tryCountLastname + 1;
        lastName = Console.ReadLine();
    }
    while (lastName.Length < 3);
}

// output user data if valid
if (inputValid)
{

    Console.WriteLine($"\n{firstName} {lastName}");
}
else
{
    Console.WriteLine("Eingabe des Namens ungültig.");
}
