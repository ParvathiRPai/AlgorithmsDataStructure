using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class Problem54
    {
        public List<int> SpiralMatrix(int[][] arr)
        {
            List<int> ans = new List<int>();
            if (arr.Length == 0)
                return ans;

            int r1 = 0, r2 = arr.Length - 1;
            int c1 = 0, c2 = arr[0].Length - 1;
            while(r1 <= r2 && c1 <= c2)
            {
                for(int c=c1; c <=c2;c++)
                {
                    ans.Add(arr[r1][c]);
                }
                for(int r=r1+1;r <=r2;r++)
                {
                    ans.Add(arr[r][c2]);
                }
                if(r1 < r2 && c1 <c2)
                {
                    for(int c=c2-1;c>c1;c--)
                    {
                        ans.Add(arr[r2][c]);
                    }
                    for(int r=r2;r>r1;r--)
                    {
                        ans.Add(arr[r][c1]);
                    }
                }
                r1++;
                r2--;
                c1++;
                c2--;
            }
            return ans;
        }
            
    }
}
