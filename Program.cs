using System;
using AccountClassLibrary.Model;
namespace AccountConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            CaseStudy5();
        }
        private static void CaseStudy1()
        {
            SavingsAccount vikrant = new SavingsAccount(987231289, 8762, "Vikrant");
            PrintDetails(vikrant);
        }
        private static void CaseStudy2()
        {
            CurrentAccount dinesh = new CurrentAccount(987256789, 711, "Dinesh");
            PrintDetails(dinesh);
        }
        private static void CaseStudy3()
        {
            SavingsAccount vikrant = new SavingsAccount(987231289, 8762, "Vikrant");
            vikrant.Withdraw(6000);
            PrintDetails(vikrant, "Vikrant WithDrawn 6000");
        }
        private static void CaseStudy4()
        {
            SavingsAccount vikrant = new SavingsAccount(987231289, 8762, "Vikrant");
            vikrant.Withdraw(7000);
            vikrant.Deposit(6000);
            PrintDetails(vikrant, "Vikrant WithDrawn 7000 and Deposited 6000");
        }
        private static void CaseStudy5()
        {
            CurrentAccount dinesh = new CurrentAccount(987256789, 711, "Dinesh");
            dinesh.Withdraw(6000);
            PrintDetails(dinesh, "Dinesh Withdrawn 6000");
        }
        static void PrintDetails(Account account, string description = "Account Details")
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Account Name is {account.Name}");
            Console.WriteLine($"Account Number is {account.AccountNo}");
            Console.WriteLine($"Account Balance is {account.Balance}");
            Console.WriteLine();
        }
    }
}