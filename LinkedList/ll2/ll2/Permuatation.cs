using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ll2
{
    class Permuatation
    {
        public void Permutation(string str, int s, int l)
        {
            if (l == s)
                Console.WriteLine(str);
            for(int i=s;i<l;i++)
            {
                Swap(str, s,i);
                Permutation(str, i + 1, l);
                Swap(str,s,i);
            }
        }
        public string Swap(string str, int s, int l)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[s];
            charArray[s] = charArray[l];
            charArray[l] = temp;
            string n = new string(charArray);
            return n;
        }
    }
}
