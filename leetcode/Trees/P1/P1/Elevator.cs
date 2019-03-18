using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    public interface IElevator
    {
        int getMinFloor();
        int getMaxFloor();
        int getCurrentFloor();
        Queue<int> GetDestinationqueue();
        void moveup();
        void movedown();
        void Destination(int floor);
        void queueDestionation(int floor);
        bool isPath(int floor);
        bool isFull();
        bool isIdle();
    }
    class Elevator : IElevator
    {
        private int minFloor;
        private int MaxFloor;
        private int MaxCapcity;
        public void Destination(int floor)
        {
            throw new NotImplementedException();
        }

        public int getCurrentFloor()
        {
            throw new NotImplementedException();
        }

        public Queue<int> GetDestinationqueue()
        {
            throw new NotImplementedException();
        }

        public int getMaxFloor()
        {
            throw new NotImplementedException();
        }

        public int getMinFloor()
        {
            throw new NotImplementedException();
        }

        public bool isFull()
        {
            throw new NotImplementedException();
        }

        public bool isIdle()
        {
            throw new NotImplementedException();
        }

        public bool isPath(int floor)
        {
            throw new NotImplementedException();
        }

        public void movedown()
        {
            throw new NotImplementedException();
        }

        public void moveup()
        {
            throw new NotImplementedException();
        }

        public void queueDestionation(int floor)
        {
            throw new NotImplementedException();
        }
    }
}
