using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class LongestSubString
    {
        public int Longest(string s)
        {
            int n = s.Length;
            int ans = 0;
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if(IsUnique(s, i,j))
                    {
                        ans = Math.Max(ans, j - i);
                    }
                }
            }
            return ans;
        }
        public bool IsUnique(string s, int start, int end)
        {
            HashSet<char> set = new HashSet<char>();
            int i = 0;
            while (end > start)
            {
               
                    if (set.Contains(s[i]))
                    {
                        return false;
                    }
                    else
                    {
                        set.Add(s[i]);
                         i++;
                        start++;
                    }
                
            }
            return true;
        }
    }
}
