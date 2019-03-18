using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ll2
{
    class Combination
    {
        public List<List<int>> Combine(int n, int k)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> item = new List<int>();
            DFS(n, k, 1, item, result);
            return result;

        }
        public void DFS(int n, int k,int start, List<int> item, List<List<int>> result )
        {
            if(item.Count==k)
            {
                result.Add(item);
                return;
            }
            for(int i=start; i<=n;i++)
            {
                item.Add(i);
                DFS(n, k, i + 1, item, result);
                item.Remove(item.Count - 1);
            }

        }
    }
}
