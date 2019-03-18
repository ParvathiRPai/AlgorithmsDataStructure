using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    class Something
    {
        //used to store distinct requests - those with a currentTotal, and numDecisions, because the other 2 are not function specific - choicesPerDecision does not change ever, and allTotals is just used for record-keeping, it has no purpose in the recursion
        //so the cardinality (things that change for this function has 2 params) and each is finite.
        //If things are finite, you can use 1) memoization 2) DP
        private HashSet<Tuple<int, int>> Memo = new HashSet<Tuple<int, int>>();

        //Enumerate also means Find All
        //FindDeductive... or FindSubtractive... means currentTotal starts at a large number instead of 0, the number of decisions and choices per decisions does not change and its values depends on problem
        //all totals is a record-keeper - keeps track of all totals (additive or subtractive) that have been found so far, always starts empty
        //numDecisions is the number of decisions you will still have to do in the future, this will always be large in the beginning of the problem
        public void FindAdditiveResultsWithDecisionsAndChoices(int numDecisions, int[] choicesPerDecision, int currentTotal, HashSet<int> allTotals)
        {
            if(numDecisions == 0)
            {
                //check if value exists in allTotals
                if(!allTotals.Contains(currentTotal))
                {
                    allTotals.Add(currentTotal);
                    return;
                }

                return;
            }

            foreach(var choice in choicesPerDecision)
            {
                //optional memoization
                //memoization is basically storing requests (methods in a console app, or even web requests for static services, also known as static caching
                //1) add a HashSet to store requests in the class
                //recursively call but with fewer future decisions - allTotals and choicesPerDecision are references that do not change
                //check before recursion if that has already been called
                if(Memo.Contains(Tuple.Create(numDecisions - 1, currentTotal + choice)))
                {
                    continue;
                }
                else
                {
                    Memo.Add(Tuple.Create(numDecisions - 1, currentTotal + choice));
                }

                FindAdditiveResultsWithDecisionsAndChoices(numDecisions - 1, choicesPerDecision, currentTotal + choice, allTotals);
            }
        }
    }
}
