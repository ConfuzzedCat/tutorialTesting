using System;

namespace tutorialTesting
{
    static class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Cat", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} inintial balance. ");
        }
    }
}
