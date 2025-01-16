using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    public static class TwoDArray
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/346243/assignment/problems/4092?navref=cl_tt_lst_nm
        public static int SearchInSortedMatrix(List<List<int>> A, int B)
        {

            int row = 0;
            int col = A[0].Count - 1;
            int res = int.MinValue;

            while (row < A.Count && col >= 0)
            {
                if (A[row][col] == B)
                {
                    //As it is 1 based indexing
                    res = (row + 1) * 1009 + col + 1;
                    col--;
                    continue;
                }
                else if (A[row][col] > B)
                {
                    col--;
                }
                else
                {
                    row++;
                }

                if (res > int.MinValue)
                {
                    return res;
                }

            }

            //Optimize this if condition as it has repeated two times
            if (res > int.MinValue)
            {
                return res;
            }

            return -1;

            
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/346243/assignment/problems/63?navref=cl_tt_lst_nm
        public static List<List<int>> GenerateSpiralMatrix(int A)
        {
            int[,] res = new int[A, A];
            var finalResult = new List<List<int>>();
            int size = A;
            int counter = 1;
            int row = 0;
            int col = 0;

            if(size == 1)
            {
                return new List<List<int>>() { new List<int>() { 1} };
            }

            while(size > 1)
            {
                for(int i=0;i< size-1; i++)
                {

                    res[row,col] = counter++;
                    col++;
                }
               
                for (int i = 0; i < size-1; i++)
                {
                    res[row, col] = counter++;
                    row++;
                }
               

                for (int i = 0; i < size-1; i++)
                {
                    res[row, col] = counter++;
                    col--;
                }
              

                for (int i = 0; i < size-1; i++)
                {
                    res[row, col] = counter++;
                    row--;
                }

                row++;
                col++;
                size -= 2;

                if (size == 1)
                {
                    res[row,col] = counter;
                }
            }

            
           
            for(int i = 0; i < res.GetLength(0); i++)
            {
                var list = new List<int>();
                for (int j = 0; j < res.GetLength(0); j++)
                {
                    list.Add(res[i, j]);
                }
                finalResult.Add(list);
            }


            return finalResult;

        }
    }
}
