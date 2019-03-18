using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevesringKthNodeofLinkedList
{
    class Duplicate
    {
        public void AddSum(int []arr)
        {
            List<List<int>>res = new List<List<int>>();
            int n = arr.Length;
            for(int i=0; i<n; i++)
            {
                for(int j=1;j<n-1;j++)
                {
                    int tempres = arr[i] + arr[j] + arr[j + 1];
                    if(tempres==0)
                    {
                        
                        Console.WriteLine($"{arr[i]} , {arr[j]} , {arr[j + 1]}");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
