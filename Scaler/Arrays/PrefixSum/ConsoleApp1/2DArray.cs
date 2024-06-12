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

            for(int row = 0; row < a.Count; row++)
            {
                int i = 0;
                int j = a.Count - 1;
                while(i < j)
                {
                    var temp = a[row][i];
                    a[row][i] = a[row][j];
                    a[row][j] = temp;
                    i++;
                    j--;
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

        //https://www.scaler.com/academy/mentee-dashboard/class/223203/homework/problems/11466?navref=cl_tt_lst_sl
        public static int MinorDiagonalSum(List<List<int>> A)
        {
            int sum = 0;
            int j = A[0].Count - 1;
            for (int row=0; row < A.Count; row++)
            {

                sum+= A[row][j];
                j--;
            }

            return sum;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223203/homework/problems/11616?navref=cl_tt_lst_sl
        public static List<List<int>> AddTheMatrices(List<List<int>> A, List<List<int>> B)
        {
            List<List<int>> result = new List<List<int>>();

            for (int row = 0; row < A.Count; row++)
            {
                List<int> subArray = new List<int>();
                for(int col = 0; col < A[0].Count; col++)
                {
                    int sum = A[row][col] + B[row][col];
                    subArray.Add(sum);
                }
                result.Add(subArray);
            }

            return result;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223203/homework/problems/11613?navref=cl_tt_lst_sl
        public static List<List<int>> MatrixScalarProduct(List<List<int>> A, int B)
        {
            for(int row =  0; row < A.Count; row++)
            {
                for(int col = 0;col < A[0].Count; col++)
                {
                    A[row][col] = A[row][col] * B;
                }
            }

            return A;
        }


    }
}
