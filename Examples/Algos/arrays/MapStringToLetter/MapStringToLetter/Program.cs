using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapStringToLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 1111;
            PalindromeOfNumber p = new PalindromeOfNumber();
            bool result=p.ISPalindrome(Num);
            Console.WriteLine(result);
            Console.ReadKey();

            
        }
    }
}
