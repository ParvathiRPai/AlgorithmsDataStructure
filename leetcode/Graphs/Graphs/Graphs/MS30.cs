using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Interval
    {
        public int start;
        public int end;
        public Interval(int s, int e)
        {
            start = s;
            end = e;
        }
    }
    class MS30
    {
        public List<Interval> InsertInterval(List<Interval>intervals, Interval newInterval)
        {

            List<Interval> res = new List<Interval>();
            int i = 0;
            while (intervals.Count != 0 && intervals[i].end< newInterval.start) res.Add(intervals[i++]);
            int start = newInterval.start;
            int end = newInterval.end;
            while(i<intervals.Count && intervals[i].start<=end)
            {
                start = Math.Min(start, intervals[i].start);
                end = Math.Max(end, intervals[i].end);
            }
            res.Add(new Interval(start, end));
            while (i < intervals.Count) res.Add(intervals[i++]);
            return res;
        }
        public List<Interval> Merge(List<Interval>intervals)
        {
            List<Interval> res = new List<Interval>();
            List<Interval> sort = intervals.OrderBy(x => x.start).ToList();
            Interval pre = intervals[0];
            for(int i=0; i<intervals.Count;i++)
            {
                Interval curr = intervals[i];
                if(pre.end < curr.start)
                {
                    res.Add(pre);
                    pre = curr;
                }
                else
                {
                    Interval merged= new Interval(pre.start, Math.Max(pre.end, curr.start));
                    pre = merged;
                }
                
            }
            res.Add(pre);
            return res;

        }
        public int RemoveOverlaping(List<Interval> intervals)
        {
            int count = 0;
            List<Interval> sort = intervals.OrderBy(x => x.start).ToList();
            Interval pre = intervals[0];
            for(int i=1; i<sort.Count;i++)
            {
                Interval curr = intervals[i];
                if(pre.start>=curr.start && pre.end<=curr.end)
                {
                    count++;
                    pre = curr;
                }
                else
                {
                    pre = curr;
                }

            }
            return count;
        }

    }
}
