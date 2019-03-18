using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class S5
    {
        public int[] Merge(int []arr1, int []arr2)
        {
            int n = arr1.Length-1;
            int m = arr2.Length-1;
            int LastIndex = n + m ;
            while(m>=0)
            {
                if(n>= 0 && arr1[n]<arr2[m])
                {
                    arr1[LastIndex] = arr2[m];
                    m--;
                }
                else
                {
                    arr1[LastIndex] = arr1[n];
                    n--;
                }
                LastIndex--;
            }

            return arr1;
        }


        public int[] sortedMerge(int[] a, int[] b,
                                 int n, int m)
        {
            int i = n - 1;
            int j = m - 1;

            int lastIndex = n + m - 1;

            // Merge a and b, starting  
            // from last element in each  
            while (j >= 0)
            {

                /* End of a is greater than  
                end of b */
                if (i >= 0 && a[i] > b[j])
                {

                    // Copy Element 
                    a[lastIndex] = a[i];
                    i--;
                }

                else
                {

                    // Copy Element 
                    a[lastIndex] = b[j];
                    j--;
                }

                // Move indices 
                lastIndex--;
            }
            return a;
        }
    }
}
