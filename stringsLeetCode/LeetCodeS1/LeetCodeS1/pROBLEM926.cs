using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class pROBLEM926
    {
        public List<string>Expand(string s)
        {
            List<string> result = new List<string>();
            int n = s.Length;
            int j = 0;
            var sb = new StringBuilder();
          
                for(int i=0; i<n;i++)
                {
                    sb.Append(1);
                    result.Add(sb.ToString());
                }
            
            return result;
        }
        public List<string> FindMinFlip(List<string> str, string s)
        {
            List<string> resultxor = new List<string>();
            int i = 0;
        
            while(i<str.Count)
            {
                int[] temp1 = ConvertStringToArray(str[i]);
                int[] temp2 = ConvertStringToArray(s);
                int[] result = XORArray(temp1, temp2);
                string temp = result.ToString();
                resultxor.Add(temp);
            }
            return resultxor;
    
        }
        public int GetMinOnes(List<string> Xor)
        {
            List<int> res = new List<int>();
            int count = 0;
            foreach( string s in Xor)
            {
                for(int i=0; i<s.Length;i++)
                {
                    if(s[i]==1)
                    {
                        count++;
                    }
                }
                res.Add(count);
            }
            return res.Min();
        }
        public int[] XORArray(int []temp1, int []temp2)
        {
            int[] res = new int[temp1.Length];
            int i = 0, j = 0;
            int index = 0; 
            while(i< temp1.Length && j<temp2.Length)
            {
                res[index] = temp1[i] ^ temp2[i];
                index++;
                i++;
                j++;
            }
            return res;
        }
        public int [] ConvertStringToArray(string s)
        {
            int[] res = new int[s.Length];
            for(int i=0; i<s.Length;i++)
            {
                if(s[i]==1)
                {
                    res[i] = 1;
                }
            }
            return res;
        }
    }
}
