﻿bool hasError = false;
double result = 0;

Console.WriteLine("Bitte geben Sie einen ersten Operanden ein:");
string leftOpAsString = Console.ReadLine();
double leftOp = Convert.ToDouble(leftOpAsString);

Console.WriteLine("\nBitte geben Sie einen Operator ein:");
Console.WriteLine($" - Minus");
Console.WriteLine($" + Plus");
Console.WriteLine($" / Division");
Console.WriteLine(" * Multiplikation");
string op = Console.ReadLine();

Console.WriteLine("\nBitte geben Sie einen zweiten Operanden ein:");
string rightOpAsString = Console.ReadLine();
int rightOp = Convert.ToInt32(rightOpAsString);

switch (op)
{
    case "+":
        {
            result = leftOp + rightOp;
            break;
        }
    case "-":
        {
            result = rightOp - leftOp;
            break;
        }
    case "/":
        {
            result = rightOp / leftOp;
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
    Console.WriteLine($" {leftOp,9:0.0000}");
    Console.WriteLine($"{op}{rightOp,9:0.0000}");
    Console.WriteLine($"={result,9:0.0000}\n");
}
