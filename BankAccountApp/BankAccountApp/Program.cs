using System;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Let's do some operations with bank account!");
            Owner accountOwner = new Owner("Karim", 1223344, new DateTime(2000, 02, 06));

            BankAccount myAccount = new BankAccount("RO48RNCB12345678", accountOwner);

            myAccount.PrintAccountOperations();

            //let's make some operations
            myAccount.DepositMoney(100);
            myAccount.PrintAccountOperations();

            myAccount.DepositMoney(150);
            myAccount.DepositMoney(133);
            myAccount.AddAuthorizedPerson(new AuthorizedPerson("Mom", AuthorizedPerson.Roles.TUTOR));
            myAccount.WithdrawMoney(55);
            myAccount.PrintAccountOperations();
        }
    }
}
