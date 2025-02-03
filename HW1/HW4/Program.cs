// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Xml.Linq;

bool shouldExit = false;
string consoleInput;
int leftOperand = 0;
int rightOperand = 0;
string calcOperator = "";

while (!shouldExit) {
    Console.WriteLine("Please enter two numbers and one operator(+, -, *, / are allowed) one by one. \n Enter \"exit\" to exit. \n");

    for (int i = 0; i < 3; i++) {
        consoleInput = Console.ReadLine();
        if (consoleInput == "exit")
        {
            shouldExit = true;
            return;
        }

        switch (i)
        {
            case 0:
                if (!int.TryParse(consoleInput, out leftOperand)) {
                    Console.WriteLine("Not a number, please re-run program");
                    shouldExit = true;
                    return;
                }
                    break;
            case 1:
                if (!int.TryParse(consoleInput, out rightOperand)) {
                    Console.WriteLine("Not a number, please re-run program");
                    shouldExit = true;
                    return;
                }
                    break;
            case 2:
                if (consoleInput != "+" && consoleInput != "-" && consoleInput != "*" && consoleInput != "/") {
                    Console.WriteLine("Wrong operator, please re-run program");
                    shouldExit = true;
                    return;
                }
                calcOperator = consoleInput;
                break;
        }
    }

    switch (calcOperator) {
        case "+":
            Console.WriteLine($"Result is: {leftOperand + rightOperand}. \n");
            break;
        case "-":
            Console.WriteLine($"Result is: {leftOperand - rightOperand}. \n");
            break;
        case "*":
            Console.WriteLine($"Result is: {leftOperand * rightOperand}. \n");
            break;
        case "/":
            if (calcOperator == "/" && rightOperand == 0) {
                Console.WriteLine("Please learn math better, schoolboy");
                shouldExit = true;
                return;
            }
            Console.WriteLine($"Result is: {leftOperand / rightOperand}. \n");
            break;
    }
}
