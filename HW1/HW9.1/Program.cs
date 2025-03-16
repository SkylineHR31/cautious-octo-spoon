var rand = new Random();

//1
int[,] array2 = new int[5, 5];
int minValue = 0;
int maxValue = 0;
string minIndex = "";
string maxIndex = "";
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {

        array2[i, j] = rand.Next(-100, 100);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array2[i, j] < minValue)
        {
            minValue = array2[i, j];
            minIndex = $"[{i},{j}]";
        }
        if (array2[i, j] > maxValue)
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

//end 1
