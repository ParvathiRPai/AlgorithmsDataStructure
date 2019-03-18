using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    public class Interval
    {
        public int start;
        public int end;
        public List<int>[] adj;
        public Interval(int start, int end)
        {
            start = start;
            end = end;

        }

        
        
    }
    class Problem56
    {
        public List<Interval> FindIntervals(List<Interval> intervals)
        {
          List<Interval> sortedList = intervals.OrderBy(x => x.start).ToList();
          List<Interval> Merged = new List<Interval>();
            int mergedIntervalStart = Merged[0].start;
            int MergedIntervalEnd = Merged[0].end;

            for(int i=1;  i< sortedList.Count;i++)
            {
                Interval currentInterval = sortedList[i];
                if(MergedIntervalEnd < currentInterval.start)
                {
                    // no overlapping
                    Merged.Add(new Interval(mergedIntervalStart, MergedIntervalEnd));
                    mergedIntervalStart = currentInterval.start;
                    MergedIntervalEnd = currentInterval.end;
                }
                else
                {
                    MergedIntervalEnd = Math.Max(MergedIntervalEnd, currentInterval.end);

                }
            }
            Merged.Add(new Interval(mergedIntervalStart, MergedIntervalEnd));
            return Merged;
        }
    }
}
