using System.Security.Principal;

namespace HW14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Account", 100.00);
            BankAccount swissAccount = new BankAccount("SwissAccount", 1000000.00);

            account.Withdrawal(20);
            Console.WriteLine("Account balance is: " + account.Balance);

            swissAccount.Deposit(200);
            Console.WriteLine("swissAccount balance is: " + swissAccount.Balance);
        }
    }
}
