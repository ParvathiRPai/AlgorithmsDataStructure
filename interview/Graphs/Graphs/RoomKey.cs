using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class RoomKey
    {
        public bool CanVisitAllRooms(List<List<int>> rooms)
        {
            Stack<int> s = new Stack<int>();
            Boolean[] seen = new Boolean[rooms.Count];
            s.Push(0);
            while(s.Count !=0)
            {
                int node = s.Pop();
                foreach(int i in rooms[node])
                {
                    if (!seen[i])
                        seen[i] = true;
                   
                }
            }
            foreach (bool i in seen)
       
                if (!i) return false;
           
                return true; 
            
        }
    }
}
