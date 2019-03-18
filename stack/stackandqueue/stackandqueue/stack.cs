using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackandqueue
{
    class stack
    {
        int max = 1000;
        int []s = new int[1000];
        int top; 
        public bool IsEmpty()
        {
            return (top < 0);
        }
        public stack()
        {
            top = -1;
        }
        public void push( int data)
        {
            if(top >= max)
            {
                Console.WriteLine("overflow");
            }
            else
            {
                s[top++] = data;
            }
        }
        public int Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("underflow");
                return 0;
            }
            else
            {
                int value = s[top--];
                return value;
            }

        }
        public void peek()
        {
            Console.WriteLine(s[top]);
        }
        public void PrintStack()
        {
            if(top <0)
            {
                Console.WriteLine("underflow");
            }
            else
            {
                for(int i=top;i>0; i--)
                {
                    Console.WriteLine(s[i]);
                }
            }
        }
        

    }
}
