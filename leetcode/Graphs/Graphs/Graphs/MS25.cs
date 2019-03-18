using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS25
    {
        public List<List<string>> GroupAnagrams(string []strings)
        {
            Dictionary<string, List<string>> d = new Dictionary<string, List<string>>();
            foreach(string s in strings)
            {
                var anagram = s.ToCharArray();
                Array.Sort(anagram);
                var sorted = new string(anagram);
                if(d.ContainsKey(sorted))
                {
                    d[sorted].Add(s);
                }
                else
                {
                    d.Add(sorted, new List<string> { s });
                }

            }
            List<List<string>> res = d.Select(x => (List<string>)(x.Value)).ToList();
            return res;
        }
      
    }
}
