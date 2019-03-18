using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class StackDS
    {
        public int[] elem;
        public int top;
        public int max;
        public StackDS(int size)
        {
            elem= new int[size];
            top = -1;
            max = size;
        }
        public void Push(int data)
        {
            if(elem.Length==max-1)
            {
                Console.WriteLine("Overflow");
            }
            else
            {
                elem[++top] = data;
            }
        }
        public void Pop()
        {
            if(top==-1)
            {
                Console.WriteLine("underflow");
            }
            else
            {
                int res = elem[top--];
                Console.WriteLine("${res}");
            }
        }

    }
}
