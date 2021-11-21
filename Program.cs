using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank1 = new Bank();
            
            BasicAccount account = new BasicAccount(AccountType.Account);
            account.IncreaseBalance(2000M);
            
            BasicAccount savingAccount = new BasicAccount(AccountType.SavingAccount);
            savingAccount.IncreaseBalance(1000M);
            savingAccount.IncreaseInterest(100);

            bank1.AddAccount(account);
            bank1.AddAccount(savingAccount);

            Console.WriteLine(bank1.GetValue());


        }
    }
}
