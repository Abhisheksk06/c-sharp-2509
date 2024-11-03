using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Bank21
    {
        //List
        public List<Customer> customers = new List<Customer>();

        //Method to add a new customer
        public void AddCustomer(string name)
        {
            customers.Add(new Customer(name));
        }

        //Method to add a new account
        public void AddAccount(string customerName, int accountNumber, double initialBalance)
        {
            Customer customer = customers.Find(c => c.Name == customerName);
            if (customer != null)
            {
                customer.AddAccount(accountNumber, initialBalance);
            }
            else
            {
                Console.WriteLine($"Customer {customerName} not found");
            }
        }

        public void DisplayCustomerDetails()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer Name: {customer.Name}");
                foreach (var account in customer.Accounts)
                {
                    Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
                }
            }
        }


        //Nested Customer class
        public class Customer
        {
            public string Name;
            public List<Account> Accounts;

            //constructor
            public Customer(string name)
            {
                Name = name;
                Accounts = new List<Account>();
            }

            public void AddAccount(int accountNumber, double initialBalance)
            {
                Accounts.Add(new Account(accountNumber, initialBalance));
            }
        }

        //Nested Account class
        public class Account
        {
            public int AccountNumber;
            public double Balance;

            //constructor
            public Account(int accountNumber, double balance)
            {
                AccountNumber = accountNumber;
                Balance = balance;
            }

        }
    }
}
