using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class ArrayPrograms4
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/346254/assignment/problems/56?navref=cl_tt_lst_sl
        //This is also called kadane algorithm
        public static int MaxSubArraySum(List<int> A)
        {
            //if(A.Count == 1) return A[0];

            int ans = int.MinValue;
            int sum = 0;

            for (int i = 0; i < A.Count; i++)
            {
                sum += A[i];
                if (sum > ans)
                {
                    ans = sum;
                }
                if (sum < 0)
                {
                    sum = 0;
                }
               
            }

            return ans;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/346254/assignment/problems/440?navref=cl_tt_lst_nm
        public static List<int> ContinuousSumQuery(int A, List<List<int>> B)
        {
            int[] res = new int[A];
            //mark the points in the array
            for (int i = 0; i < B.Count; i++)
            {
                int startIndex = B[i][0] -1;
                int endIndex = B[i][1] -1;
                int value = B[i][2];

                res[startIndex] += value;

                if (endIndex +1 < res.Length)
                { 
                    res[endIndex +1] -= value;
                }
            }

            //Apply the prefix sum so that you carry the value till the end of array

            for(int i=1;i< res.Length; i++)
            {
                res[i] = res[i-1] + res[i];
            }

            return res.ToList();
        }

    }
}
