using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class Problem893
    {
        public int GetEquivalentStrings(string []A)
        {
            Dictionary<string, int> ds = new Dictionary<string, int>();
            string[] res= new string[A.Length];
            int i = 0;
            foreach(string s in A)
            {
                char[] ch = s.ToArray();
                Array.Sort(ch);
                res[i++] = new string(ch);
            }
            
            int current=1;
            foreach(string s in res)
            {
              if(!ds.ContainsKey(s))
                {
                    ds.Add(s, current);
                }
              else
                {
                   ds[s]=current+1;
                }
            }
            var res1= ds.Count;
            return res1;
        }
    }
}
