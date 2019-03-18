using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class printZig
    {
        public void PrintZigZag(string s, int n)
        {
            char[] ch = s.ToCharArray();
            string[] arr=new string[n];
            int top = 0;
            bool down = true;
            int len = ch.Length;
            for(int i=0; i<len;i++)
            {
                arr[top]+= (ch[i]);
                if(top==n-1)
                {
                    down = false;
                }
                else if(top==0)
                {
                    down = true;
                }

                if (down)
                    top++;
                else
                    top--;
            }
            for(int i=0; i <n;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int myAtoi(string str)
        {
            int res = 0; // Initialize result 

            // Iterate through all characters of  
            // input string and update result 
            for (int i = 0; i < str.Length; ++i)
                res = res * 10 + str[i] - '0';

            // return result. 
            return res;
        }
    }
}
