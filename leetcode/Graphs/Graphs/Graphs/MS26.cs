using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS26
    {
        public bool Parenthesis(string s)
        {
            Stack<char> stack = new Stack<char>();
            for(int i=0; i<s.Length;i++)
            {
                if(s[i]=='(' || s[i]=='{'|| s[i]=='[')
                {
                    stack.Push(s[i]);
                }
                if(s[i] == ')' || s[i] == '}' || s[i] == ']')
                {
                    char s1=stack.Pop();

                    if(s1=='(' && s[i] == ')')
                    {
                        continue;
                    } else if(s1 == '{' && s[i] == '}')
                    {
                        continue;
                    }
                    else if (s1 == '[' && s[i] == ']')
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }
            return true; 
        }
    }
}
