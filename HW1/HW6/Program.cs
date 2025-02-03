using System;

try
{
    Console.WriteLine("Enter number:");
    string input = Console.ReadLine();
    double number = Convert.ToDouble(input);
    Console.WriteLine($"You entered the number: {number}");
}
catch (FormatException)
{
    Console.WriteLine("Error: the entered value is not a number.");
}