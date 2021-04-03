using System;

namespace BankEncapsulation
{
    class program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("How much you would ike to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you, your Balance is now {account.GetBalance()}");
        }
    }
}
