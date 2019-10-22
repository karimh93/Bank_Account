using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    class AuthorizedPerson : GeneralPerson
    {
        public enum Roles { TUTOR, LEGAL_AUTHORIZED_PERSON}

        private Roles role;

        public Roles Role
        {
            get { return role; }
            set { role = value; }
        }

        public AuthorizedPerson(string pName,Roles role):base(pName)
        {
            this.Role = role;
        }
    }
}
