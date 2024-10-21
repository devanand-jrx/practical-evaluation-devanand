using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PracticalEvaluationDevanand.Task2
{
    public class BankAccount
    {
        private string accountNumber;
        public double balance;
        public string accountHolderName;

        public BankAccount(string accountNumber, double initialBalance, string accountHolderName)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.accountHolderName = accountHolderName;
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero");
            }

            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero");
            }

            if (balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds for withdrawal");
            }

            balance -= amount;
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Balance: Rs." + balance);
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Create a Bank Account:");
            BankAccount EDSTEM123AXIS = new BankAccount("EDSTEM123AXIS", 0, "DEVANAND");

            EDSTEM123AXIS.DisplayAccountDetails();

            Console.WriteLine("Enter the deposit amount to EDSTEM123AXIS:");
            double depositAmount;
            while (!double.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
            {
                Console.WriteLine("Please enter an amount greater than 0:");
            }
            EDSTEM123AXIS.Deposit(depositAmount);
            Console.WriteLine("New balance Rs." + depositAmount + ": Rs." + EDSTEM123AXIS.Balance);

            Console.WriteLine("Enter amount to withdraw from EDSTEM123AXIS:");
            double withdrawAmount;
            while (!double.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount <= 0)
            {
                Console.WriteLine("Please enter amount greater than 0:");
            }

            EDSTEM123AXIS.Withdraw(withdrawAmount);
            Console.WriteLine("New balance Rs." + withdrawAmount + ": Rs." + EDSTEM123AXIS.Balance);
        }
    }

}



