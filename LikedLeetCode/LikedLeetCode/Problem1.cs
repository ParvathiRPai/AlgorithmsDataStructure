using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class Problem1
    {
        public int[] EqualToTarget(int []arr, int target)
        {
            if(arr.Length==0)
            {
                return null;
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;i<arr.Length;i++)
                {
                    if(arr[j]==target-arr[i])
                    {
                        return new int[]{ i, j };
                    }
                }
            }
            throw new ArgumentException("not found");
        }
    }
}
