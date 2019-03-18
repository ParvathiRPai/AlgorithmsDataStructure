using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace LeetCodeS1
//{
//    class MaxMatrix
//    {
//        public int MaxMatrixSize(int[][] arr)
//        {
//            int rows = arr.Length;
//            int col = rows > 0 ? arr[0].Length : 0;
//            int[][] result = new int[rows + 1][col+1];
//            int max = 0;
//            for(int i=1;i<=rows;i++)
//            {
//                for(int j=1;j<=col;j++)
//                {
//                    if(arr[i-1][j-1]=='1')
//                    {
//                        result[i][j] = Math.Min(Math.Min(result[i][j - 1], result[i - 1][j]), result[i - 1][j - 1]) + 1;
//                        max = Math.Max(max, result[i][j]);
//                    }
//                }
//            }
//            return max * max;
//        }
//    }
//}
