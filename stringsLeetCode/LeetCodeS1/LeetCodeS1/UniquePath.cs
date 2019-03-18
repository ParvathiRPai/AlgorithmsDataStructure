using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class UniquePath
    {
        public int NumberofUniquePaths(int [][]arr)
        {
            int R = arr.Length;
            int C = arr[0].Length;
            if (arr[0][0] == 1)
                return 0;
            arr[0][0] =1;
            for(int i=0; i< R;i++)
            {
                arr[i][0] = (arr[i][0] == 0 && arr[i - 1][0] == 1) ? 1 : 0;
            }
            for(int j=0; j <C; j++)
            {
                arr[0][j] = (arr[0][j] == 0 && arr[0][j - 1] == 1) ? 1 : 0;
            }
            for(int i=1;i<R;i++)
            {
                for(int j=1;j<C;j++)
                {
                    if(arr[i][j]==0)
                    {
                        arr[i][j] = arr[i - 1][j] + arr[i][j - 1];
                    }
                    else
                    {
                        arr[i][j] = 0;
                    }
                }
            }
            return arr[R - 1][C - 1];

        }
    }
}
