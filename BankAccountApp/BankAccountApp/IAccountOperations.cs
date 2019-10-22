using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public interface IAccountOperations
    {
        void DepositMoney(decimal amount);
        void WithdrawMoney(decimal amount);
        void CloseAccount();
        void OpenAccount();
    }
}
