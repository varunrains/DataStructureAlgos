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

        //https://www.scaler.com/academy/mentee-dashboard/class/235834/assignment/problems/5784?navref=cl_tt_lst_nm
        public static int FindtheNumberOfOnesInBinaryMatrix(List<List<int>> A)
        {
            int maxRowIndex = -1;
            int maxCount = 0;

            int row = 0, col = A[0].Count - 1;

            while (row < A[0].Count && col >= 0)
            {
                if (A[row][col] == 1)
                {
                    col--;
                    maxRowIndex = row;
                    maxCount++;
                }
                else
                {
                    row++;
                }
            }

            return maxRowIndex;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235834/assignment/problems/4092?navref=cl_tt_lst_nm
        public static int SearchInSortedMatrix(List<List<int>> A, int B)
        {
            int row = 0;
            int col = A[0].Count - 1;
            int result = int.MaxValue;
            while (row < A.Count && col >= 0)
            {
                if (A[row][col] == B)
                {
                    //Given in the question to return like this
                    result = Math.Min(((row + 1) * 1009) + col + 1, result);
                    col--;
                }
                else if (A[row][col] > B)
                {
                    col--;
                }
                else 
                {
                    row++;
                }

            }
            if(result != int.MaxValue)
            {
                return result;
            }
            return -1;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235834/homework/problems/4033?navref=cl_tt_lst_nm
        public static int MinimumSwaps(List<int> A, int B)
        {
            int windowSize = 0;
            int greaterThanB = 0;

            for (int i = 0; i < A.Count; i++)
            {
                if(A[i] <= B)
                {
                    windowSize++;
                }
            }

            //First window to find the minimumSwaps
            for(int i = 0; i < windowSize; i++)
            {
                if (A[i]>B)
                {
                    greaterThanB++;
                }
            }
            int minimumSwaps = greaterThanB;
            for (int i = 1; i < A.Count-windowSize; i++)
            {
                int l = i - 1;
                int r = windowSize + i -1;

                if (A[l] > B)
                {
                    greaterThanB--;
                }
                
                if (A[r] > B)
                {
                    greaterThanB++;
                }
                minimumSwaps = Math.Min(minimumSwaps, greaterThanB);

            }

            return minimumSwaps;

        }
    }
}
