using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class CountChar
    {
        public void CountChars(string str)
        {
            int LowerCase = 0;
            int upperCase = 0;
            int specialChar = 0;
            int numbers = 0; 
            for(int i=0; i< str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && str[i] <= 'Z')
                    upperCase++;
            }
            Console.WriteLine(upperCase);
            Console.ReadKey();
        }
    }
}
