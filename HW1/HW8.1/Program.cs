

//1
var rand = new Random();
int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 10);
}

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0) Console.WriteLine($"array{i}={array[i]}");
}
//end 1

//2
int accumulator = 0;
for (int i = 0; i < array.Length; i++)
{
    accumulator += array[i];
}

if (accumulator < 0) {
    Console.WriteLine($"Sum of array is negative({accumulator})");
} else Console.WriteLine($"Sum of array is positive({accumulator})");
//end 2

//3
string[,] multiplicationTable = new string[9,9];

for (int i = 0;i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        int leftOperand = i + 1;
        int rightOperand = j + 1;
        multiplicationTable[i, j] = $"{leftOperand}*{rightOperand}={leftOperand * rightOperand}";
    }
}

for (int i = 0;i < 9; i++)
{
    string buffer = "";
    for (int j = 0; j < 9; j++)
    {
        buffer += $"{multiplicationTable[i, j]}\t";
    }
    Console.WriteLine($"{buffer}\n");
}
//end 3

//4
int[,] array2 = new int[5, 5];
int minValue = 0;
int maxValue = 0;
string minIndex = "";
string maxIndex = "";
for (int i = 0; i < 5 ; i++)
{
    for(int j = 0;j < 5 ; j++) { 
    
    array2[i,j] = rand.Next(-100, 100);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array2[i,j] < minValue)
        {
            minValue = array2[i, j];
            minIndex = $"[{i},{j}]";
        }
        if (array2[i,j] > maxValue)
        {
            maxValue = array2[i, j];
            maxIndex = $"[{i},{j}]";
        }
    }
}

for (int i = 0; i < 5; i++)
{
    string buffer = "";

    for (int j = 0; j < 5; j++)
    {
        buffer += $"{array2[i, j]}\t";
    }
    Console.WriteLine($"{buffer}\n");
}

Console.WriteLine($"Min value = {minValue} at index {minIndex}");
Console.WriteLine($"Max value = {maxValue} at index {maxIndex}");

//end 4

//5
Console.Write("Enter number of days: ");
if (int.TryParse(Console.ReadLine(), out int days))
{
    DaysOfWeek startDay = DaysOfWeek.Monday;
    DaysOfWeek resultDay = (DaysOfWeek)(((int)startDay + days - 1) % 7 + 1);
    Console.WriteLine($"The day after {days} days will be: {resultDay}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

//end 5

enum DaysOfWeek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}