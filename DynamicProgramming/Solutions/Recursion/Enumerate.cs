using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions.Recursion
{
    class GenerateAll
    {
        public HashSet<string> GetAllSubsets(IList<int> arr)
        {
            //steps - depth of the recursion tree - length of the path - size of a final solution - at most number of elements in arr
            //choices - the elements that have not been chosen so far, which means we need to track the elements that have been chosen so far
            //so choices -> choices IList<int> and chosen IList<int>
            //and the usual results HashSet<IList<int>>
            return F(new List<int>(), arr, 0, new HashSet<string>());
        }
        public HashSet<string> F(IList<int> chosen, IList<int> choices, int currentStep, HashSet<string> resultSet)
        {
            foreach(var choice in choices)
            {
                //make a copy so you dont update the data passed to recursive calls for other choices
                var copyOfChosen = chosen.ToList();
                var copyOfChoices = choices.ToList();

                //(todo):conditions here
                //if(copyOfChosen.Last() == choice && choice ==1)
                //{
                //    continue;
                //}

                copyOfChosen.Add(choice);
                choices.Remove(choice);
                
                //(todo):check if need to add to result set and return
                if(copyOfChoices.Count == 0)
                {
                    copyOfChoices.Sort();
                    var checkString = string.Join(",", copyOfChoices);
                    if(!resultSet.Contains(checkString))
                    {
                        resultSet.Add(checkString);
                    }

                    continue;
                }

                F(copyOfChosen, choices, currentStep + 1, resultSet);
            }

            return resultSet;
        }
    }
}
