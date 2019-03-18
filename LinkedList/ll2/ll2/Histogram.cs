using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ll2
{
    class Histogram
    {
       public string RemoveDuplicates(string s)
        {
            List<char> l = new List<char>();
            foreach(char c in s)
            {
                if(!l.Contains(c))
                {
                    l.Add(c);
                }
                else
                {
                    continue;
                }
            }
            return l.ToString();
        }
            
    }
}
