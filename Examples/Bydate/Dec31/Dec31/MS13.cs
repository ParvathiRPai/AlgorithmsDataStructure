using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS13
    {
        public string Rotate(string s)
        {
            var words = s.Split(' ');
            string output = string.Empty;
            foreach(string word in words)
            {
                output = output + Reverse(word) + " ";
            }
            return output;
        }
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }
    }
}
