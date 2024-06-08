using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class _2DArray
    {
        public static List<int> ColumnSum(List<List<int>> A)
        {
            List<int> list = new List<int>();
            for(int col = 0; col < A[0].Count; col++)
            {
                int sum = 0;
                for (int row = 0; row < A.Count; row++)
                {

                    //Column wise sum
                    sum += A[row][col];
                }
                list.Add(sum);
            }
            return list;
        }

        public static List<int> RowSum(List<List<int>> A)
        {
            List<int> list = new List<int>();
            for (int row = 0; row < A.Count; row++)
            {
                int sum = 0;
                for (int col = 0; col < A[0].Count; col++)
                {

                    //Row wise sum
                    sum += A[row][col];
                }
                list.Add(sum);
            }
            return list;
        }

        public static List<List<int>> MatrixTranspose(List<List<int>> A)
        {
            List<List<int>> result = new List<List<int>>();

            for(int col=0;col < A[0].Count; col++)
            {
                List<int> subArray = new List<int>();
                for(int row = 0; row < A.Count; row++)
                {
                    subArray.Add(A[row][col]);
                }
                result.Add(subArray);
            }

            return result;


        }

        public static void RotateMatrixBy90(List<List<int>> a)
        {
            for(int row=0;row < a.Count; row++)
            {
              
               for(int col = 0; col < a[0].Count; col++)
                {
                    if(row < col)
                    {
                        var temp = a[col][row];
                        a[col][row] = a[row][col];
                        a[row][col] = temp;
                    }
                }
            }
        }

            public static List<List<int>> PrintAntiDiagonals(List<List<int>> A)
        {
            int i = 0;
            int j= A[0].Count;
            List<int> rowItems = new List<int>();
            for(int row=0;row < A.Count; row++)
            {
                for(int col = 0; col < A[0].Count; col++)
                {

                }
            }

            return null;
        }

        public static int MainDiagnolSum(List<List<int>> A)
        {
            int col = 0;
            int sum = 0;
            for(int row = 0; row < A.Count ; row++)
            {
              if(row == col)
                {
                    sum+= A[row][row];
                }
              col++;
            }
            return sum;
        }
    }
}
