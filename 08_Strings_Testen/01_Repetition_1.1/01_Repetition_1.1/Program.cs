bool hasError = false;

while (!hasError)
{
    double result = 0;

    Console.WriteLine("Bitte geben Sie einen ersten Operanden ein:");
    string leftOpAsString = Console.ReadLine();
    double leftOp = Convert.ToDouble(leftOpAsString);

    Console.WriteLine("\nBitte geben Sie einen Operator ein:");
    Console.WriteLine($" - Minus");
    Console.WriteLine($" + Plus");
    Console.WriteLine($" / Division");
    Console.WriteLine(" * Multiplikation");
    string operand = Console.ReadLine();

    Console.WriteLine("\nBitte geben Sie einen zweiten Operanden ein:");
    string rightOpAsString = Console.ReadLine();
    double rightOp = Convert.ToDouble(rightOpAsString);

    switch (operand)
    {
        case "+":
            {
                result = leftOp + rightOp;
                break;
            }
        case "-":
            {
                result = leftOp - rightOp;
                break;
            }
        case "/":
            {
                if (rightOp != 0)
                {
                    result = leftOp / rightOp;
                }
                else
                {
                    hasError = true;
                    Console.WriteLine("Error: Falscheingabe!");
                }
                break;
            }
        case "*":
            {
                result = leftOp * rightOp;
                break;
            }
        default:
            {
                hasError = true;
                Console.WriteLine("Error: Ungültiger Operator!");
                break;
            }
    }

    if (!hasError)
    {
        Console.WriteLine("\nResultat:");
        Console.WriteLine($" {leftOp,21:0.0000000000}");
        Console.WriteLine($"{operand}{rightOp,21:0.0000000000}");
        Console.WriteLine($"={result,21:0.0000000000}\n");
    }
}