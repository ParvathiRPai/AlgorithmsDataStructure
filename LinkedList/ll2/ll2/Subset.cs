using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ll2
{
    class Subset
    {
        public List<List<int>> FindSubsets(int []arr)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> item = new List<int>();
            FindAllSubsets(arr, result, item, 0);
                return result;
        }
        public void FindAllSubsets(int []arr, List<List<int>> result, List<int> item,int startIndex)
        {
            result.Add(item);
            for(int i=startIndex; i<arr.Length;i++)
            {
                item.Add(arr[i]);
                FindAllSubsets(arr, result, item, i + 1);

            }

        }
    }
}
