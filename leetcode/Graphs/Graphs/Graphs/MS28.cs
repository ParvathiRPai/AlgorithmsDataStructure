using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS28
    {
        public int Palindrome(string s)
        {
            int count = 0; 
            for(int i=0; i<s.Length;i++)
            {
                for(int j=i; j<s.Length;j++)
                {
                    bool res = IsPalindrome(s, i, j);
                    if(res==true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private bool IsPalindrome(string s, int i, int j)
        {
            int low = i;
            int high = j;
            while(i<=j)
            {
                if(s[i]!=s[j])
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
