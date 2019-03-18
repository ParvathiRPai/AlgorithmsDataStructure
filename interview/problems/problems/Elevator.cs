using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public enum Direction
    {
        up,down
    }
    public enum Door
    {
        open, closed
    }
    public enum State
    {
        moving, stopped
    }
    public enum ElevatorName
    {
        A,B,C,D
    }
    public interface Elevator
    {
        int getMinFloor();
        int getMaxFloor();
        int getCurrentFloor();

    }
 
    public class Request
    {
        public long time;
        public int floor;
        public Direction direction;
        public Request(long time, int floor, Direction direction)
        {
            this.time = time;
            this.floor = floor;
            this.direction = direction;
        }

    }
    
}
