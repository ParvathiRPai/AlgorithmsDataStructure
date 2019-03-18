using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class PalindromeSubstring
    {
        public string Palindromestring( string s)
        {
            int n = s.Length;
            string res = "";
            for(int i=0;i<s.Length;i++)
            {
                for(int j=i+2;j<s.Length;j++)
                {
                    if(IsPalindrome(s,i,j)==true)
                    {
                        res=s.Substring(i, j+1);
                    }
                }
            }
            return res;
        }
        public bool IsPalindrome(string s, int start, int end)
        {
            int i = 0;
            int j = end;
            while(start<=end)
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
                start++;
                    end--;
            }
            return true;
        }
    }
}
