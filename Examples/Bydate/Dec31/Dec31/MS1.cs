using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS1
    {
        public string LPS(string s)
        {
            int palIndexStart=0;
            int palIndexEnd=0;
           for(int i=0; i<s.Length;i++)
            {
                for(int j=i+1; j<s.Length-1;j++)
                {
                    bool res = IsPalindrome(s, i, j);
                    if (res == true)
                    {
                        palIndexStart = i;
                        palIndexEnd = j;
                    }
                }
            }
            string res1 = s.Substring(palIndexStart, palIndexEnd);
            return res1;
        }
        public bool IsPalindrome(string s, int i, int j)
        {

            while(i<=j && j >= 0)
            {
                if(s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
