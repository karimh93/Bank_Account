using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountApp
{
    class BankAccount : GeneralAccount, IAccountOperations
    {
        public enum Account_Status { Open, Closed };

        private decimal balance;
        private Owner owner;
        private Account_Status accountStatus;
        private List<Operation> listaOperatii;
        private List<AuthorizedPerson> listaPersoaneAutorizate;   

        public List<AuthorizedPerson> ListaPersoaneAutorizate
        {
            get { return listaPersoaneAutorizate; }
            set { listaPersoaneAutorizate = value; }
        }


        public List<Operation> ListaOperatii
        {
            get { return listaOperatii; }
            private set { listaOperatii = value; }
        }




        public Account_Status AccountStatus
        {
            get { return accountStatus; }
            set { accountStatus = value; }
        }


        public Owner AccountOwner
        {
            get { return owner; }
            set { owner = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }


        public decimal CheckBalance()
        {
            return Balance;
        }
        public BankAccount(string accountID, Owner owner) : base(accountID)
        {
            this.AccountOwner = owner;
            OpenAccount();
            this.Balance = 0;  //initial amount
            this.ListaOperatii = new List<Operation>();
            this.ListaPersoaneAutorizate = new List<AuthorizedPerson>();
        }

        public void DepositMoney(decimal amount)
        {
            if (this.AccountStatus == Account_Status.Open && amount >= 0)  
            {
                this.Balance = this.Balance + amount;
                this.ListaOperatii.Add(new Operation(Operation.OPERATION_TYPE.DEPOSIT, amount));  
            }
        }

        public void WithdrawMoney(decimal amount)
        {
            if (this.AccountStatus == Account_Status.Open && amount >= 0)  
            {
                this.Balance = this.Balance - amount;
                this.ListaOperatii.Add(new Operation(Operation.OPERATION_TYPE.WITHDRAWAL, amount));
            }
        }


        public void CloseAccount()
        {
            this.AccountStatus = Account_Status.Closed;
        }

        public void OpenAccount()
        {
            this.AccountStatus = Account_Status.Open;  
        }

        public void AddAuthorizedPerson(AuthorizedPerson person)
        {
            this.ListaPersoaneAutorizate.Add(person);
        }

        public void PrintAccountOperations()
        {
            //afisare informatii cont si titular cont
            Console.WriteLine($"Lista operatii pentru contul {this.AccountID}, titular {this.AccountOwner.Name}, CNP: {this.AccountOwner.CNP}, stare {this.AccountStatus}");
            //afisare lista persoanelor autorizate pe acest cont
            Console.WriteLine("Persoane autorizate pe acest cont:");
            foreach (var persoana in ListaPersoaneAutorizate)
            {
                Console.WriteLine($"Persoana autorizata: {persoana.Name}, rol: {persoana.Role}");
            }
            //afisare lista operatiunilor pe acest cont
            Console.WriteLine("Lista operatii:");
            foreach (var operatie in ListaOperatii)
            {
                Console.WriteLine($"Tip tranzactie: {operatie.OperationType}, valoare: {operatie.OperationAmount}"); 
            }
            Console.WriteLine($"Sold final: {this.Balance}");
            int numberOfDepositOperations = listaOperatii.Count(x => x.OperationType == Operation.OPERATION_TYPE.DEPOSIT);
            int numberOfWitdrawalOperations = ListaOperatii.Count(x => x.OperationType == Operation.OPERATION_TYPE.WITHDRAWAL);
            Console.WriteLine($"Numar total de tranzactii: {this.ListaOperatii.Count}, din care " +
                $" depuneri: {numberOfDepositOperations}, retrageri: {numberOfWitdrawalOperations}");
           
            Console.WriteLine("----------------------------------");
        }
    }
}
