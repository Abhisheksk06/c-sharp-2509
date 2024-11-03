using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class BankAccount
    {
        public string AccountNumber;
        public string AccountHolderName;
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }
                balance = value;
            }
        }

        public BankAccount(string accountNumber, string accountHolderName)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive");
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount} into account {AccountNumber}. New Balance: {Balance}");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawl amount mst be positive");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw {amount} from account {AccountNumber}. New Balance: {Balance}");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Account Holder: {AccountHolderName}, Balance: {Balance}");
        }
    }
}
