using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class FindMissingElements
    {
        public List<int> FindMissingElement(int []arr1, int []arr2)
        {
            List<int> l = new List<int>();
            List<int> result = new List<int>();
            for(int i=0; i<arr2.Length; i++)
            {
                l.Add(arr2[i]);
            }
            for(int i=0; i<arr1.Length;i++)
            {
                if(!l.Contains(arr1[i]))
                {
                    result.Add(arr1[i]);
                }
            }
            return result;
        }
    }
}
