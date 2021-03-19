using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class CDAccount:SavingsAccount
    {

        //Field
        private string _maturityDate;

        //constructor
        public CDAccount()
        {
            _maturityDate = "";

       
         }

        //maturitydate property
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }

        }
    }
}
