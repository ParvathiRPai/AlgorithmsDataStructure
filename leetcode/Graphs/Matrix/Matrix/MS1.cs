using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MS1
    {
        public int [ , ] MatrixZero(int [ , ]input)
        {
            int r = input.GetLength(0);
            int c = input.GetLength(1);
            int[,] res = new int[r, c];
            for(int i=0; i<r;i++)
            {
                for(int j=0; j<c;j++)
                {
                    res[i, j] = 1;
                }
            }
            for(int i=0; i<r;i++)
            {
                for(int j=0; j<c;j++)
                {
                    if(input[i,j]==0)
                    {
                        for (int m = 0; m <= r; m++) 
                        res[r, m] = 0;

                        for (int n = 0; n <=c; n++)
                            res[n, c] = 0;

                    }
                }
            }
            return res;
        }
        
    }
}
