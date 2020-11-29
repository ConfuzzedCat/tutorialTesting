using System;

namespace tutorialTesting
{
    static class Program
    {
        static void Main(string[] args)
        {
            
            var account = new BankAccount("Cat", 3500);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} inintial balance. ");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            account.MakeDeposit(356, DateTime.Now, "Got paid for work");
            account.MakeWithdrawal(1000, DateTime.Now, "Taxes");
            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
