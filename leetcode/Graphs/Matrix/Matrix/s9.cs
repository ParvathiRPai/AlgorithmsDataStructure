using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Matrix
{
    class s9
    {
        public List<string> UnCommon(string A, string B)
        {
            List<string> result = new List<string>();
            List<string> AL = new List<string>();
            
            string s=string.Empty;
            foreach(char c in A)
            {
                if(c!=' ')
                {
                    s += c;
                }
                else
                {
                    AL.Add(s);
                    s = string.Empty;
                }

            }
            foreach (char c in B)
            {
                if (c != ' ')
                {
                    s += c;
                }
                else
                {
                    if (!AL.Contains(s))
                    {
                        result.Add(s);
                    }
                    s = string.Empty;
                }
            }
            return result;

        }

        public void Common(string []s, string []sentences)
        {
          
            foreach(string word in s)
            {
               foreach(string str in sentences)
                {
                    int i = str.ToLower().IndexOf(word.ToLower());
                    if(i==-1)
                    {
                        break;
                    }
                    string res=str.Substring(i, word.Length).ToLower();
                    if(res.ToLower()==word.ToLower())
                    {
                        Console.WriteLine(word);
                    }
                   
                }
            }
        }
        public void Common1(string []pattern,string []sentences)
        {
            foreach (string s in pattern)
            {
                foreach (string str in sentences)
                {
                    Regex r = new Regex(s.ToLower());
                    MatchCollection matches = r.Matches(str.ToLower());
                    if(matches.Count>=1)
                    {
                        Console.WriteLine("{0} matches found in:\n   {1}", matches.Count, str);
                    }
                }

            }
        }
        public string Reverse(String s)
        {
            char[] ch = s.ToCharArray();
            int i = 0;
            int index = ch.Length - 1;
            while(i<index)
            {
                char temp = ch[i];
                ch[i] = ch[index];
                ch[index] = temp;
                i++;
                index--;
            }

            return new string(ch);

        }

        public void Sort(int []arr, int []index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // While index[i] and arr[i] are not fixed 
                while (index[i] != i)
                {
                    // Store values of the target (or correct)  
                    // position before placing arr[i] there 
                    int oldTargetI = index[index[i]];
                    char oldTargetE = (char)arr[index[i]];

                    // Place arr[i] at its target (or correct) 
                    // position. Also copy corrected index for 
                    // new position 
                    arr[index[i]] = arr[i];
                    index[index[i]] = index[i];

                    // Copy old target values to arr[i] and 
                    // index[i] 
                    index[i] = oldTargetI;
                    arr[i] = oldTargetE;
                   
                }
            }
        }
    }
}
