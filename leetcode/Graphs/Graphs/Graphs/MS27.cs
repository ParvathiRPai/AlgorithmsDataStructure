using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS27
    {
        public bool IsPalindrome(string s)
        {
            int low = 0;
            int high = s.Length-1;
            while(low<high)
            {
                if (!char.IsLetterOrDigit(s[low]))
                    low++;
                else if (!char.IsLetterOrDigit(s[high]))
                    high--;
                else if (char.ToLower(s[low++]) != char.ToLower(s[high--]))
                    return false;
            }
            return true;
        }
    }
}
