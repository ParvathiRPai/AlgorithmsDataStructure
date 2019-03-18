using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Isunique
    {
        public bool Isuni(string str)
        {
            bool[] charset = new bool[128];
            char[] c = str.ToCharArray();
            foreach(char ch in c)
            {
                if(charset[(int)ch])
                {
                    return false;
                }
                else
                {
                    charset[(int)ch] = true;
                }

            }
            return true;
        }

    }
}
