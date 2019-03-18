using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    class EvenOddLinkedList
    {
        public void EvenOdd(Node start)
        {
            Node EvenStart = null;
            Node OddStart = null;
            Node EvenEnd = null;
            Node OddEnd = null;
            Node current = start;
            while(current != null)
            {
                int currentElement = current.data;
                if(currentElement %2==0)
                {
                    EvenStart = current;
                    
                }
                else
                {

                }
                current = current.next;
            }
        }
    }
}
