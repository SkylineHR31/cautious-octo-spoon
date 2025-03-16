Console.Write("Enter a string with words separated by commas: ");
string input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Invalid input. Please enter a valid string.");
    return;
}
Console.WriteLine($"String without spaces: {input.Replace(" ", "")}");
