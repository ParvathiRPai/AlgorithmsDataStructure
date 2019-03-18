using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapStringToLetter
{
    class PalindromeOfNumber
    {
        public int[] GetNumber(int N)
        {
            List<int> numbers = new List<int>();
            while(N >0)
            {
                numbers.Add(N % 10);
                N = N / 10;
            }
            numbers.Reverse();
            return numbers.ToArray();
        }
        public string MapNumberToAlphabet(int N)
        {
            int[] Numbers = GetNumber(N);
            string output = "";
            for(int i=0; i < Numbers.Length;i++)
            {
                output = (char)((char)'A' + (Numbers[i] - 1)) + output;
            }
            output.Reverse();
            return output;
        }
        public bool ISPalindrome(int N)
        {
            string s = MapNumberToAlphabet(N);
            int i = 0, j = s.Length-1;
            while(i < s.Length && j >0 )
            {
                if(s[i]!=s[j])
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }

    }
}
