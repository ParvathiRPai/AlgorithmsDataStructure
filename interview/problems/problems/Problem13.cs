using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Problem13
    {
        public bool Isadjacent(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    count++;
                }

                if (count > 1)
                {
                    return false;
                }
            }
            return true;
        }
        public void ShortesChain(string start, string target, string[] dic)
        {
            Queue<string> q = new Queue<string>();
            List<string> res = new List<string>();
            q.Enqueue(start);
            res.Add(start);
            while (q.Count > 0)
            {
                string curr = q.Dequeue();
                for (int i = 0; i < dic.Length; i++)
                {
                    string temp = dic[i];
                    if (Isadjacent(curr, temp) == true)
                    {
                        q.Enqueue(temp);
                        res.Add(temp);
                    }
                }

            }
            for(int i=0; i<res.Count;i++)
            {
                Console.WriteLine(res[i]);
            }

        }

    }
}

