using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace LeetCodeS1
//{
//    class MinPath
//    {
//        public int MinSumPath(int [][]arr)
//        {
           
//            int R = arr.Length;
//            int C = arr[0].Length;
//            int[][] res = new int[R][ C ];
//            res[0][0] = arr[0][0];
//            for (int i=1; i<C;i++)
//            {
//                arr[0][i] = res[0][i-1] + arr[0][i];
//            }
//            for(int j=1; j<R;j++)
//            {
//                arr[j][0] = res[j - 1][0] + res[j][0];
//            }
//            for(int i=1;i<R; i++)
//            {
//                for(int j=1;j<C;j++)
//                {
//                    if(res[i-1][j] < res[i][j-1])
//                    {
//                        res[i][j] = res[i - 1][j] + arr[i][j];
//                    }
//                    else
//                    {
//                        res[i][j] = res[i][j - 1] + arr[i][j];
//                    }
//                }
//            }

//        }
//    }
//}
