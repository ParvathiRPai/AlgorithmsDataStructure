using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class PalindromeSubstringCount
    {
        public int GetPalindromeStringCount(string s)
        {
            int N = s.Length;
            int count = 0;
            for (int center = 0; center <= 2 * N - 1; ++center)
            {
                int left = center / 2;
                int right = left + center % 2;
                while (left >= 0 && right < N)

                {
                    count++;
                    left--;
                    right++;
                }
            }
            return count;
        }
        
    }
}
