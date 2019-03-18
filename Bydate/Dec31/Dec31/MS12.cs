using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS12
    {
       public List<List<int>> Permutation(int []arr)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> l = new List<int>();
            for(int i=0; i<arr.Length;i++)
            {
                FindPer(arr, i, result, l);
            }
            return result;
        }
        private void FindPer(int []arr, int index, List<List<int>> result, List<int> l)
        {
            List<int> temp = new List<int>(l);
            temp.Add(arr[index]);
            if(temp.Count==arr.Length && !result.Contains(temp))
            {

                result.Add(temp);
                return;
            }
            for(int i=0; i<arr.Length;i++)
            {
                if(!temp.Contains(arr[i]))
                {
                    FindPer(arr, i, result, temp);
                }
            }

        }
       
    }
}
