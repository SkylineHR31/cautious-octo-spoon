Console.WriteLine("Enter full name: ");
string fullName = Console.ReadLine();
bool isEqual = false;

string[] parsedName = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

if (parsedName.Length > 1)
{
    for (int i = 0; i < parsedName.Length - 1; i++)
    {
        if (char.ToUpper(parsedName[i][0]) == char.ToUpper(parsedName[i + 1][0]))
        {
            isEqual = true;
            break;
        }
    }
}

if (isEqual)
{
    Console.WriteLine("First letter in both words are equal");
} else Console.WriteLine("First letter in both words are NOT equal");