using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class WildCard
    {
        public string ReplacePattern(  string p)
        {
            
            char[] charP = p.ToCharArray();
            char[] result = new char[charP.Length];
            bool isFirst = true;
            int index = 0;
            for(int i=0;i<charP.Length;i++)
            {
                if(charP[i]=='*')
                {
                    if (isFirst)
                    {
                        result[index++] = charP[i];
                        isFirst = false;
                     
                    }
                    else
                    {
                        isFirst = true;
                    }
                }
                else
                {
                    result[index++] = charP[i];
                }
                
            }
            return result.ToString();
            
        }

    }
}
