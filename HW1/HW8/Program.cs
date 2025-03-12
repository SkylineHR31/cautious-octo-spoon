string[,] baseField = {
    {"1", "2","3"},
    {"4", "5", "6"},
    {"7", "8", "9"}
};

int gameCounter = 1;
string[] firstRowPattern = { "1", "2", "3" };
string[] secondRowPattern = { "4", "5", "6" };
string[] thirdtRowPattern = { "7", "8", "9" };
string[] firstColPattern = { "1", "4", "7" };
string[] secondColPattern = { "2", "5", "8" };
string[] thirdtColPattern = { "3", "6", "9" };
string[] leftToRightDiagonalPattern = { "1", "5", "9" };
string[] RightToLeftDiagonalPattern = { "3", "5", "7" };

while (true)
{
    if (gameCounter == 10) {
        Console.WriteLine($"Its nobody win");
        return;
    };
    int currentPlayer = gameCounter % 2;
    string currentPlayerSign = currentPlayer == 0 ? "O": "X";
    if (gameCounter == 1)
    {
        Console.WriteLine($"{baseField[0, 0]} | {baseField[0, 1]} | {baseField[0, 2]}  \n" +
    $"----------\n" +
    $"{baseField[1, 0]} | {baseField[1, 1]} | {baseField[1, 2]}  \n" +
    $"----------\n" +
    $"{baseField[2, 0]} | {baseField[2, 1]} | {baseField[2, 2]}  \n");
    }
    Console.WriteLine($"Enter position from 1 to 9. Enter \"exit\" for exit. \n");
    Console.WriteLine($"Now its {(currentPlayer == 0 ? 2 : 1)} player turn({currentPlayerSign}) \n");
    string input = Console.ReadLine();

    if (input == "exit") return;

    switch (input)
    {
        case "1":
            baseField[0, 0] = currentPlayerSign;
            firstRowPattern[0] = currentPlayerSign;
            firstColPattern[0] = currentPlayerSign;
            leftToRightDiagonalPattern[0] = currentPlayerSign;
            break;
        case "2":
            baseField[0, 1] = currentPlayerSign;
            firstRowPattern[1] = currentPlayerSign;
            secondColPattern[0] = currentPlayerSign;
            break;
        case "3":
            baseField[0, 2] = currentPlayerSign;
            firstRowPattern[2] = currentPlayerSign;
            thirdtColPattern[0] = currentPlayerSign;
            RightToLeftDiagonalPattern[0] = currentPlayerSign;
            break;
        case "4":
            baseField[1, 0] = currentPlayerSign;
            secondRowPattern[0] = currentPlayerSign;
            firstColPattern[1] = currentPlayerSign;
            break;
        case "5":
            baseField[1, 1] = currentPlayerSign;
            secondRowPattern[1] = currentPlayerSign;
            secondColPattern[1] = currentPlayerSign;
            leftToRightDiagonalPattern[1] = currentPlayerSign;
            RightToLeftDiagonalPattern[1] = currentPlayerSign;
            break;
        case "6":
            baseField[1, 2] = currentPlayerSign;
            secondRowPattern[2] = currentPlayerSign;
            thirdtColPattern[1] = currentPlayerSign;
            break;
        case "7":
            baseField[2, 0] = currentPlayerSign;
            thirdtRowPattern[0] = currentPlayerSign;
            firstColPattern[2] = currentPlayerSign;
            RightToLeftDiagonalPattern[2] = currentPlayerSign;
            break;
        case "8":
            baseField[2, 1] = currentPlayerSign;
            thirdtRowPattern[1] = currentPlayerSign;
            secondColPattern[2] = currentPlayerSign;
            break;
        case "9":
            baseField[2, 2] = currentPlayerSign;
            thirdtRowPattern[2] = currentPlayerSign;
            thirdtColPattern[2] = currentPlayerSign;
            leftToRightDiagonalPattern[2] = currentPlayerSign;
            break;
    }

    Console.WriteLine($"{baseField[0, 0]} | {baseField[0, 1]} | {baseField[0, 2]}  \n" +
    $"----------\n" +
    $"{baseField[1, 0]} | {baseField[1, 1]} | {baseField[1, 2]}  \n" +
    $"----------\n" +
    $"{baseField[2, 0]} | {baseField[2, 1]} | {baseField[2, 2]}  \n");

    if (firstRowPattern.All(c => c == currentPlayerSign) ||
        secondRowPattern.All(c => c == currentPlayerSign) ||
        thirdtRowPattern.All(c => c == currentPlayerSign) ||
        firstColPattern.All(c => c == currentPlayerSign) ||
        secondColPattern.All(c => c == currentPlayerSign) ||
        thirdtColPattern.All(c => c == currentPlayerSign) ||
        leftToRightDiagonalPattern.All(c => c == currentPlayerSign) ||
        RightToLeftDiagonalPattern.All(c => c == currentPlayerSign))
    {
        Console.WriteLine($"Player {(currentPlayer == 0 ? 2 : 1)} wins!({currentPlayerSign}) \n");
        return;
    }
    else {
        gameCounter++;
    }
    
}