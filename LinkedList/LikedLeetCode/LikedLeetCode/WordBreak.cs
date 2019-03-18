using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class WordBreak
    {
        public bool IsWordBreak(string s,HashSet<string> dict)
        {
            for (int i = 0; i < s.Length; i++)
            {
                bool res=WordBreakHelper(s, dict, i);
                if (res == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool WordBreakHelper(string s, HashSet<string> dic, int start)
        {
            if(start==s.Length)
            {
                return true;
            }
            foreach(string str in dic)
            {
                int len = str.Length;
                int end = start + len;

                if (s.Substring(start, end).Equals(str))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
