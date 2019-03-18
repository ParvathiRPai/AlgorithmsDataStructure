using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class validParenthesis
    {
        public bool IsValid(string s)
        {
            int open = 0;
            int closed = 0;
            for(int i=0; i<s.Length;i++)
            {
                if(s[i]=='('| s[i]=='{'| s[i]=='[')
                {
                    open++;
                }
                if(s[i] == ')' | s[i] == '}' | s[i] == ']')
                {
                    closed++;
                }
            }
            return open == closed ? true : false;

        }
        public bool IsValid1(string s)
        {
            Stack<char> st = new Stack<char>();
            for(int i=0; i<s.Length;i++)
            {
                var current = s[i];
                if(current== '(' || current == '{' || current == '[')
                {
                    st.Push(current);
                }
                else if (current == ')' | current == '}' | current == ']')
                {
                    if(st.Count==0)
                    {
                        return false;
                    }
                    var previous = (char)st.Pop();
                    if((previous == '(' && current==')') || (previous == '[' && current == ']') ||
                        (previous == '{' && current == '}'))
                    {
                        continue;
                    }
                    return false;
                }
                
            }
            return st.Count == 0;
        }
    }
}
