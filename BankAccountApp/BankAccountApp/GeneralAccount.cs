using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    class GeneralAccount
    {
        private string accountID;
        private DateTime creationDate;

        public DateTime CreationDate
        {
            get { return creationDate; }
            private set { creationDate = value; }
        }


        public string AccountID
        {
            get { return accountID; }
            private set { accountID = value; }
        }

        public GeneralAccount(string accountID)
        {
            AccountID = accountID;
            CreationDate = DateTime.Now ;
        }
    }
}
