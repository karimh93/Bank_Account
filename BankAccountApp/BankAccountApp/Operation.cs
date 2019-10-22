using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    class Operation
    {
        public enum OPERATION_TYPE { DEPOSIT, WITHDRAWAL}

        private decimal amount;
        private OPERATION_TYPE operationType;

        public OPERATION_TYPE OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }


        public decimal OperationAmount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Operation(OPERATION_TYPE operationType, decimal amount)
        {
            OperationType = operationType;
            OperationAmount = amount;
        }
    }
}
