using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1
{
    class WidthofTree
    {
        
        public int GetWidth(Node start)
        {
            int maxWidth = 0;
            int height = Height(start);
            for(int i=0; i<=height;i++)
            {
                int width = GetWidth(start, i);
                if(width >maxWidth)
                {
                    maxWidth = width;
                }
            }
            return maxWidth;
        }
        public int GetWidth(Node start, int i)
        {
            if(start ==null)
            {
                return 0;
            }

            if (i == 1)
            {
                return 1;
            }
            else
            {
                return GetWidth(start.left, i - 1) + GetWidth(start.right, i - 1);
            }
            
        }
        public int Height(Node start)
        {
            if (start == null)
            {
                return 0;
            }
            else
            {
                int leftHeight = Height(start.left);
                int rightHeight = Height(start.right);
                return leftHeight > rightHeight ? (leftHeight + 1) : (rightHeight + 1);
            }

        }
    }
}
