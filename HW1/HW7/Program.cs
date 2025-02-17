﻿/*
 *  Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. 
 *  Після отримання всіх значень програма має обчислити та вивести середній заробіток.
 */
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

//double avrSalary = 0;
//int avrSalaryCounter = 0;

//while(true)
//{
//    Console.WriteLine("Please enter salary, to exit -- enter \"exit\"");
//    string input = Console.ReadLine();
//    if (input == "exit") break;

//    avrSalary += Convert.ToDouble(input);
//    avrSalaryCounter++;

//    Console.WriteLine($"Average salary is: {avrSalary/avrSalaryCounter}");
//}

/*
 *  Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок. 
 *  Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок.
 */

//Console.Write("Enter X asix value: ");

//if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
//{
//    Console.Write("Enter Y asix value: ");
//    if (int.TryParse(Console.ReadLine(), out int columns) && columns > 0)
//    {
//        for (int i = rows; i >= 0; i--)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                if (j == i * columns / rows) 
//                {
//                    Console.Write("*");
//                }
//                else
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//    else
//    {
//        Console.WriteLine("Input error");
//    }
//}
//else
//{
//    Console.WriteLine("Input error");
//}

/*
 *  Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. 
 *  Просте число - це число, яке ділиться лише на 1 і на себе.
 */

//Console.Write("Enter number: ");
//if (int.TryParse(Console.ReadLine(), out int limit) && limit > 0)
//{
//    Console.WriteLine("Generated primes:");
//    for (int num = 2; num <= limit; num++)
//    {
//        bool isPrime = true;
//        for (int i = 2; i * i <= num; i++)
//        {
//            if (num % i == 0)
//            {
//                isPrime = false;
//                break;
//            }
//        }
//        if (isPrime)
//        {
//            Console.Write(num + " ");
//        }
//    }
//    Console.WriteLine();
//}
//else
//{
//    Console.WriteLine("Invalid input");
//}

/*
 *  Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача. Пароль вважається прийнятним, якщо він містить принаймні 8 символів,
 *  з яких принаймні один символ - це цифра, а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).
 */

//while (true)
//{
//    Console.WriteLine("Please enter password, to exit -- enter \"exit\"");
//    string input = Console.ReadLine();
//    if (input == "exit") break;

//    string pattern = @"^(?=.*\d)(?=.*[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>?/`~])(?=.*[a-zA-Z]).{8,}$";
//    if (Regex.IsMatch(input, pattern))
//    {
//        Console.WriteLine("Password valid");
//    }
//    else
//    {
//        Console.WriteLine("Password invalid. Must be at least 8 symbols, contained at least 1 digit and 1 special symbol");
//    }

//}

/*
 *  Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі. Послідовність Фібоначчі починається з 0 і 1, 
 *  а кожне наступне число є сумою двох попередніх чисел у послідовності.
 */

//Console.Write("Enter the number of Fibonacci numbers: ");
//if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//{
//    long a = 0, b = 1;
//    Console.WriteLine("Fibonacci numbers:");
//    for (int i = 0; i < n; i++)
//    {
//        Console.Write(a + " ");
//        long temp = a;
//        a = b;
//        b = temp + b;
//    }
//    Console.WriteLine();
//}
//else
//{
//    Console.WriteLine("Invalid input");
//}

/*
 *  Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. 
 *  Після введення значень програма має обчислити та вивести оплату за день.
 */

//while (true)
//{
//    Console.WriteLine("Enter the number of hours worked(e.g. 10,5), to exit -- enter \"exit\"");
//    string input = Console.ReadLine();
//    if (input == "exit") break;

//    double hoursWorked = Convert.ToDouble(input);

//    Console.Write("Enter the hourly rate (e.g. 15,35): ");
//    double hourlyRate = Convert.ToDouble(Console.ReadLine());

//    double dailyEarnings = hoursWorked * hourlyRate;
//    Console.WriteLine($"Daily earnings: {dailyEarnings:F2}");

//}

/*
 * Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число, 
 * а потім генерує таблицю множення для цього числа від 1 до 10.
 */

//Console.Write("Enter number: ");
//if (int.TryParse(Console.ReadLine(), out int number))
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{number} x {i} = {number * i}");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input");
//}

/*
 *  Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим. 
 *  Число вважається простим, якщо воно ділиться лише на 1 і на себе.
 */

Console.Write("Enter a number: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    bool isPrime = number > 1;

    for (int i = 2; i * i <= number && isPrime; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
        }
    }

    Console.WriteLine($"{number} is {(isPrime ? "a prime" : "not a prime")} number.");
}
else
{
    Console.WriteLine("Invalid input");
}