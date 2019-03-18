using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class CombinationalSum
    {
        public List<List<int>>FindCombinationalSum(int[] candidates, int target)
        {
            List<List<int>> results = new List<List<int>>();
            if(candidates==null || candidates.Length==0)
            {
                return results;
            }
            Array.Sort(candidates);

            List<int> combination = new List<int>();
            ToFindCombination(results, combination, candidates, target, 0);
            return results;
        }
        public void ToFindCombination(List<List<int>> results,List<int>combination,int [] candidates, int target, int startIndex)
        {
            if(target==0)
            {
                results.Add(combination);
                return;
            }
            for(int i=startIndex;i<candidates.Length;i++)
            {
                if(candidates[i] > target)
                {
                    break;
                }
                combination.Add(candidates[i]);
                ToFindCombination(results, combination, candidates, target - candidates[i], i);
                combination.Remove(combination.Count - 1);
            }
        }
    }
}
