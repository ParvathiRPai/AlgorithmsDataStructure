using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class MinSum
    {
        public int[] FindMinSumOfTriangle(List<List<int>> val)
        {
            int[] res = new int[val.Count];
            int index = 0;
            for(int i=0; i< val.Count;i++)
            {
                List<int> temp = new List<int>();
                foreach(int j in val[i])
                {
                    temp.Add(j);
                }
                int min = FindMin(temp);
                res[index++] = min;
            }
            return res;
        }
        public int FindMinSum(int []arr)
        {
            int res = 0; 
            for(int i=0; i< arr.Length;i++)
            {
                res = res + arr[i];
            }
            return res;
        }
        public int FindMin(List<int> temp)
        {
            int min = 9999999;
            foreach(int i in temp)
            {
                if(min > i)
                {
                    min = i;
                }
            }
            return min;
        }
    }
}
