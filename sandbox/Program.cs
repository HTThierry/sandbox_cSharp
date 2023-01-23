//calculator console app

using System;

Console.WriteLine("enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter operator");
string op = Console.ReadLine();

switch (op)
{
    case "+" or "add":
        Console.WriteLine(num1 + num2);
        break;
    case "-":
        Console.WriteLine(num1 - num2);
        break;
    case "*":
        Console.WriteLine(num1 * num2);
        break;
    case "/":
        Console.WriteLine(num1 / num2);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}