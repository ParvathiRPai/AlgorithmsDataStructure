using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class S4
    {
        public List<List<int>>TargetSum(int []arr, int target)
        {
            List<List<int>> res = new List<List<int>>();
            var l = new List<int>();
            TargetSum(arr, target, l,res,0);
            return res;
        }
        private void TargetSum(int []arr, int target, List<int> temp, List<List<int>>res, int start)
        {
            if (target < 0)
            { 
                return;
            }
            if (target == 0)
            {
                res.Add(new List<int> (temp));
            }
            
            for(int i=start; i<arr.Length;i++)
            {
                temp.Add(arr[i]);
                TargetSum(arr, target - arr[i], temp, res,i);
                temp.RemoveAt(temp.Count - 1);
            }
            
        }
    }
}
