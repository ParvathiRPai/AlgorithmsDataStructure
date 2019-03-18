using System;
using System.Collections.Generic;
using System.Text;

namespace SparseMatrix
{
    class Sparse
    {
        public bool Sparsematr(int [,]arr )
        {
            int  i, j,r,c;
            int count = 0; 
            for(i=0;i<r;i++)
            {
                for(j=0;j<c;j++)
                {
                    if(arr[i,j]==0)
                    {
                        count++;
                    }
                }
            }
            if(count> (r*c)/2)
            {
                return true; 
            }
           

        }
    }
}
