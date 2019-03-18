using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // object is an instance of a class
            //object initialization 
            var account = new Account
            {
                
                Balance = 1001.50M,
                AccountType = "CHECKING"
            };
            Console.WriteLine($"AN:{account.AccountNumber},balance:{account.Balance:C}");
            var account2 = new Account
            {
                Balance = 45465M
            };
            Console.WriteLine($"AN:{account2.AccountNumber}");
        }

    }
}
