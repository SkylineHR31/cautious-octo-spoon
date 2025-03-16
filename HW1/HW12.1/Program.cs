namespace HW12._1
{
    static class Fibonacci
    {
        public static int CalculateFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Fibonacci number: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                int result = Fibonacci.CalculateFibonacci(number - 1);
                Console.WriteLine($"Fibonacci at position {number} is: {result}");
            }
            else Console.WriteLine("Invalid input");
        }
    }
}
