var rand = new Random();

//1
int[,] array = new int[5, 5];
int secondMaxValue = 0;
int maxValue = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i, j] = rand.Next(-100, 100);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array[i, j] > maxValue)
        {
            secondMaxValue = maxValue;
            maxValue = array[i, j];
        }
    }
}

for (int i = 0; i < 5; i++)
{
    string buffer = "";

    for (int j = 0; j < 5; j++)
    {
        buffer += $"{array[i, j]}\t";
    }
    Console.WriteLine($"{buffer}\n");
}

Console.WriteLine($"Max value = {maxValue}, second max value is {secondMaxValue}");

//end 1

//2

int rows = array.GetLength(0);
int cols = array.GetLength(1);
int length = rows * cols;

Console.WriteLine("OriginalArray:");

for (int i = 0; i < 5; i++)
{
    string buffer = "";

    for (int j = 0; j < 5; j++)
    {
        buffer += $"{array[i, j]}\t";
    }
    Console.WriteLine($"{buffer}\n");
}

for (int i = 0; i < length - 1; i++)
{
    for (int j = 0; j < length - i - 1; j++)
    {
        int row1 = j / cols;
        int col1 = j % cols;
        int row2 = (j + 1) / cols;
        int col2 = (j + 1) % cols;

        if (array[row1, col1] > array[row2, col2])
        {
            int temp = array[row1, col1];
            array[row1, col1] = array[row2, col2];
            array[row2, col2] = temp;
        }
    }
}

Console.WriteLine("Sorted array:");


for (int i = 0; i < 5; i++)
{
    string buffer = "";

    for (int j = 0; j < 5; j++)
    {
        buffer += $"{array[i, j]}\t";
    }
    Console.WriteLine($"{buffer}\n");
}

//end 2

//3
int[] array2 = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine("Original Array: " + string.Join(", ", array2));

Console.Write("Enter index to remove: ");
if (int.TryParse(Console.ReadLine(), out int index))
{
    if (index < 0 || index >= array2.Length)
    {
        Console.WriteLine("Invalid index.");
        return;
    }

    int[] newArray = new int[array2.Length - 1];
    for (int i = 0, j = 0; i < array2.Length; i++)
    {
        if (i != index)
            newArray[j++] = array2[i];
    }

    array2 = newArray;
    Console.WriteLine("\nArray after removal: " + string.Join(", ", array2));
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

//end 3

//4
int diagonalSum = 0;
Console.WriteLine("Original array:");


for (int i = 0; i < 5; i++)
{
    string buffer = "";

    for (int j = 0; j < 5; j++)
    {
        if (i == j) diagonalSum += array[i,j];
        buffer += $"{array[i, j]}\t";
    }
    Console.WriteLine($"{buffer}\n");
}

Console.WriteLine($"{diagonalSum}\n");
//end 4