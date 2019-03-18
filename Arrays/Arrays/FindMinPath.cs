using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class FindMinPath
    {
        public int FindMinPathofTriangle(List<List<int>> triangle)
        {
            
            int[][] arr = triangle.Select(x => x.ToArray()).ToArray();
            int[] res = new int[arr.Length];
            int result = 0;
            int min = 0;
            for(int i=0; i<arr.Length;i++)
            {
                for(int j=0; j<arr[i].Length;j++)
                {
                    if(arr[i][j]<arr[i][min])
                    {
                        min = j;
                    }
                    res[i] = arr[i][min];
                }
            }

            for(int i=0; i<res.Length;i++)
            {
                result = result + res[i];
            }
            return result;
        }
       
        
    }
}
