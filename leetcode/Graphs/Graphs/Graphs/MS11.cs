using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS11
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            int n = nums.Length - 1;
            var result = new List<List<int>>();
            Array.Sort(nums);
            for (int i=0; i< n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    for(int k=j+1;k<n;k++)
                    {
                        if(nums[i]+nums[j]+nums[k]==0)
                        {   
                            
                                result.Add(new List<int>(new int[] { nums[i], nums[j], nums[k] }));
                           
                        }
                    }
                }
                

            }
            result = result.Where((x, i) => !result.Skip(i + 1).Any(s => s.SequenceEqual(x))).ToList<List<int>>();
            return result;

            
        }
    }
}
