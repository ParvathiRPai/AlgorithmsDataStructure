using System.Collections.Generic;

namespace problems
{
    class RemoveDuplicates
    {
        public void Remove(NodeLL start)
        {
            HashSet<int> h = new HashSet<int>();
            
            NodeLL prev = null;

            while (start!=null)
            {
                if(!h.Contains(start.data))
                {
                    h.Add(start.data);
                    prev = start;
                }
                else
                {
                    prev.next = start.next;
                }
                start = start.next;
            }
        }

    }
}
