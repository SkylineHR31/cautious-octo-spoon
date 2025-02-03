// See https://aka.ms/new-console-template for more information

string consoleInput;
int leftOperand = 0;
int rightOperand = 0;

for (int i = 0; i < 2; i++) {
    consoleInput = Console.ReadLine();


    switch (i) {
        case 0:
            if (!int.TryParse(consoleInput, out leftOperand))
            {
                Console.WriteLine("Not a number, please re-run program");
                return;
            }
            break;
        case 1:
            if (!int.TryParse(consoleInput, out rightOperand))
            {
 
                Console.WriteLine("Not a number, please re-run program");
                return;
            }
            try
            {
                if (rightOperand == 0)
                    throw new DivideByZeroException("Division by zero is not allowed.");

                double result = leftOperand / rightOperand;
                Console.WriteLine($"Division result: {result}\n");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}\n");
            }
            break;
    }
}