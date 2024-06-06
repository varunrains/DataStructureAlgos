using System;
using System.Collections.Generic;
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

                    //Column wise sum
                    sum += A[row][col];
                }
                list.Add(sum);
            }
            return list;
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
