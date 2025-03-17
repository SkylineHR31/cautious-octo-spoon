using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14._1
{
    internal class BankAccount
    {
        public string Name { get; }
        private double balance;

        public double Balance
        {
            get { return balance; }
            private set { balance = value < 0 ? 0 : value; }
        }

        public BankAccount(string name, double initialBalance)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Account must be defined");
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} deposited into {Name}. New balance: {Balance}");
            }
            else Console.WriteLine("Deposit amount must be positive");
        }

        public void Withdrawal(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn from {Name}. New balance: {Balance}");
            }
            else Console.WriteLine("Invalid withdrawal amount");
        }
    }
}
