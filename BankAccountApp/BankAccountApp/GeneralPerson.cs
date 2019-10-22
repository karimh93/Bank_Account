using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    class GeneralPerson
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public GeneralPerson(string pName)
        {
            this.Name = pName;
        }

    }
}
