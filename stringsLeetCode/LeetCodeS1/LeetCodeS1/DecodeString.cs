using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class DecodeString
    {
        public int Decode(string s)
        {
            if (s.Length == 0 || s[0] == '0') return 0;

            int[] dp = new int[s.Length + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    if (s[i - 1] != '1' && s[i - 1] != '2') return 0;
                    dp[i + 1] = dp[i - 1];
                }
                else if (s[i - 1] == '1' || (s[i - 1] == '2' && s[i] - '0' <= 6))
                {
                    dp[i + 1] = dp[i] + dp[i - 1];
                }
                else
                {
                    dp[i + 1] = dp[i];
                }
            }

            return dp[s.Length];
        }
    }
}
