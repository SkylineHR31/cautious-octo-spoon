// See https://aka.ms/new-console-template for more information
bool shouldExit = false;
string consoleInput;
int dayNumber;
while (!shouldExit)
{
    Console.WriteLine("Please enter number of day(from 1 to 7). \n Enter \"exit\" to exit. \n");

    consoleInput = Console.ReadLine();

    if (int.TryParse(consoleInput, out dayNumber))
    {
        switch (dayNumber)
        {
            case 0:
                shouldExit = true;
                break;
            case < 0:
                Console.WriteLine("Please enter number of day(from 1 to 7). \n Negative numbers is not allowed. \n");
                break;
            case 1:
                Console.WriteLine("Its Monday \n");
                break;
            case 2:
                Console.WriteLine("Its Tuesday \n");
                break;
            case 3:
                Console.WriteLine("Its Wednesday \n");
                break;
            case 4:
                Console.WriteLine("Its Thursday \n");
                break;
            case 5:
                Console.WriteLine("Its Friday \n");
                break;
            case 6:
                Console.WriteLine("Its Saturday \n");
                break;
            case 7:
                Console.WriteLine("Its Sunday \n");
                break;
            default:
                Console.WriteLine("Invalid input! Please enter a number from 1 to 7. \n");
                break;
        }
    }
    else
    {
        Console.WriteLine("Please enter ONLY number of day(from 1 to 7). \n words, strings, etc. is not allowed. \n");
    }


}
