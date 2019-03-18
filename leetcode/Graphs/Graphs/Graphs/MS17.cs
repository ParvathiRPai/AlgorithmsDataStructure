using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS17
    {
        public Boolean wordBreak(String s, HashSet<String> dict)
        {
            // DFS
            HashSet<string> set = new HashSet<string>();
            return dfs(s, 0, dict, set);
        }

        private Boolean dfs(String s, int index, HashSet<String> dict, HashSet<string> set)
        {
            // base case
            if (index == s.Length) return true;
            // check memory
                   // recursion
            for (int i = index + 1; i <= s.Length; i++)
            {
                String t = s.Substring(index, i);
                if (dict.Contains(t))
                        set.Add(t);
            }
           

            return false;
        }

    }
}
