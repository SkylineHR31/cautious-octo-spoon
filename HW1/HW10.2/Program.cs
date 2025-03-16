using System.Text;

DateTime now = DateTime.Now;
int counter = 1;
StringBuilder sb = new StringBuilder("Report ", 50);
sb.Append($"{now.ToString("yyyy-MM-dd")} \n");
sb.Append("Events:\n");
sb.ToString();
Console.WriteLine(sb);

while (true)
{
    string input = Console.ReadLine();
    if (input == "exit" || input == null) break;
    sb.Append($"{input} \n");
    counter++;
}

sb.ToString();

Console.WriteLine(sb);