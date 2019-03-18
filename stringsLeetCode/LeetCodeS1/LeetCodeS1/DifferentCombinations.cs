using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class DifferentCombinations
    {
        public void PrintCombinations(int []arr, int k)
        {
            int n = arr.Length;
            int[] data = new int[n];
            Combinations(arr, data, 0, n - 1, 0, k);
        }
        public void Combinations(int []arr, int []data, int start, int end , int index, int k)
        {
            List<List<int>> l = new List<List<int>>();
            List<int> l1 = new List<int>();
            if(index==k)
            {
                for(int i=0; i<k;i++)
                {
                    l1.Add(arr[i]);
                }
                l.Add(l1);
            }
            for(int i=start;i<=end && end-i+1 >= k-index;i++)
            {
                data[index] = arr[i];
                Combinations(arr, data, i + 1, end, index + 1, k);
            }
        }
    }
}
