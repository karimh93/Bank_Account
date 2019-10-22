using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    class Owner : GeneralPerson
    {

        private int cnp;
        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            protected set { birthDate = value; }
        }


        public int CNP
        {
            get { return cnp; }
            private set { cnp = value; }
        }

        public Owner(string pName, int pCNP, DateTime pBirthDate):base(pName)
        {
            this.CNP = pCNP;
            this.BirthDate = pBirthDate;
        }

    }
}
