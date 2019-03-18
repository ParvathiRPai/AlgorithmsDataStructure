using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionofStrings
{
    class BoardGame
    {
        public Boolean Search(char [,]board, string words, int i, int j, int k)
        {
            if(i<0 || j<0)
            {
                return false;
            }
            for(int a=0; a< words.Length;i++)
            { 
            if(board[i ,j]==words[a])
                {

                }
        }
    }
}
