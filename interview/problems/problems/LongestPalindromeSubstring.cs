using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class LongestPalindromeSubstring
    {
        public string LongestPalindrome(string s)
        {
            List<char> l = new List<char>();
            for(int i=0; i<s.Length;i++)
            {
                for(int j=i+1; j<s.Length-1;j++)
                {
                    bool result = isPalindrome(s, i, j);
                    if(result==true)
                    {
                        for(int m=i; m<=j;m++)
                        {
                            l.Add(s[m]);
                        }
                    }

                    
                }
            }
            return l.ToString();
        }
        public bool isPalindrome(string s, int start, int end)
        {
            int i = start;
            int j = end;
            while(i<end && j > start)
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
