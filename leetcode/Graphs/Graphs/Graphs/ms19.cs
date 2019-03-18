using System;

namespace Graphs
{
    class ms19
    {
        public int NumDecodings(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            int result_2 = 0, result_1 = 1;
            int result = 0;

            for (int i = 1; i <= s.Length; i++)
            {
                result = 0;

                int code = s[i - 1] - '0';
                if (code >= 1 && code <= 9)
                {
                    result += result_1;
                }

                if (i >= 2)
                {
                    code = Int32.Parse(s.Substring(i - 2, 2));
                    if (code >= 10 && code <= 26)
                    {
                        result += result_2;
                    }
                }

                result_2 = result_1;
                result_1 = result;
            }

            return result;
        }
    }
}

