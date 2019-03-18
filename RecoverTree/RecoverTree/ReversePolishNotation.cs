using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoverTree
{
    class ReversePolishNotation
    {
        public int PolishNotation(int[] arr)
        {
            Stack<int> s = new Stack<int>();
            Stack<int> result = new Stack<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (IfInteger(arr[i]))
                {
                    s.Push(arr[i]);
                }
                else
                {
                    result.Push(PerformOperation(arr[i], s));
                }
            }
        }
        public bool IfInteger(int arr)
        {
            int[] cmp = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < cmp.Length; i++)
            {
                if (arr == cmp[i])
                {
                    return true;
                }
            }
            return false;
        }
        public int PerformOperation(int c, Stack<int> s)
        {
            int res;
            int a = s.Pop();
            
            if (c == '+')
            {
                res = a + a;
            }
            if (c == '*')
            {
                res = a * a;
            }
            return res;
        }
    }
}
