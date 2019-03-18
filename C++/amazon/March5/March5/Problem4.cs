using System;
using System.Collections.Generic;
using System.Text;

namespace March5
{
    class Problem4
    {
        public string LPS(string s)
        {
            int start =0, end =0;
            for(int i=0; i<s.Length;i++)
            {
                int len1 = PalindromeExpand(s, i, i);
                int len2 = PalindromeExpand(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if(len> end-start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end + 1);
        }
        public int PalindromeExpand(string s , int left, int right)
        {
            int L = left, R = right;
            while(L >= 0 && right < s.Length && s[L]==s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}
