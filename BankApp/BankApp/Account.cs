using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    {
        private static int lastAccountNumber = 0;
        #region propertiesname
        public int AccountNumber { get;  }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region constructor 
        public Account ()
        {
            AccountNumber = ++lastAccountNumber;
        }
        #endregion
    }
}
