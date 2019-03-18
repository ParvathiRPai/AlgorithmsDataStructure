using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackandqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            stack s = new stack();
            s.push(1);
            s.push(2);
            s.push(3);
            s.push(4);
            s.push(5);
            s.PrintStack();
            s.peek();
          
        }
    }
}
