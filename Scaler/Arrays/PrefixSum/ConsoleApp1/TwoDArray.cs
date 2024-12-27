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
    }
}
