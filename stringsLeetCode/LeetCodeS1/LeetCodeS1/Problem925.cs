using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class Problem925
    {
        public bool IsMatch(string name, string typed)
        {
            char[] nameA = name.ToCharArray();
            char[] typedA = typed.ToCharArray();
            int j = 0;
            for(int i=0; i<nameA.Length;i++)
            {
                if (j == typed.Length)
                    return false;
                if (nameA[i] != typedA[j])
                {
                    if (j == 0 || typedA[j - 1] != typedA[j])
                        return false;

                    char current = typedA[j];
                    while (j < typedA.Length && typedA[j] == current)
                        j++;
                    if (j == typed.Length || typedA[j] != nameA[i])
                        return false;
                }
                j++;
            }
            return true;
        }
       
    }
}
