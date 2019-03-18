using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class MergeIntervals
    {

        public List<Interval> MergeInt(List<Interval> nonOverlapInt, Interval another)
        {
            List<Interval> merge = new List<Interval>();
            foreach (Interval current in nonOverlapInt)
            {
                if (current.end <= another.start || another.end <= current.start)
                {
                    merge.Add(current);
                }
                else
                {
                    another.start = (current.start < another.start) ? current.start : another.start;
                    another.end = (current.end > another.end) ? current.end : another.end;
                }
            }
            merge.Add(another);
            return merge;
        }
    }
}

