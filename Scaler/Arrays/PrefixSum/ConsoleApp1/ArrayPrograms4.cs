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
                int startIndex = B[i][0] - 1;
                int endIndex = B[i][1] - 1;
                int value = B[i][2];

                res[startIndex] += value;

                if (endIndex + 1 < res.Length)
                {
                    res[endIndex + 1] -= value;
                }
            }

            //Apply the prefix sum so that you carry the value till the end of array

            for (int i = 1; i < res.Length; i++)
            {
                res[i] = res[i - 1] + res[i];
            }

            return res.ToList();
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/346254/assignment/problems/47?navref=cl_tt_lst_nm
        public static int RainWaterTrap(List<int> A)
        {
            int result = 0;
            int[] prefix = new int[A.Count];
            int[] suffix = new int[A.Count];

            //Initialization
            prefix[0] = A[0];
            suffix[A.Count - 1] = A[A.Count - 1];

            //find the max from left
            for (int i = 1; i < A.Count; i++)
            {
                prefix[i] = Math.Max(prefix[i - 1], A[i]);
            }

            //find the max from right
            for (int i = A.Count - 2; i >= 0; i--)
            {
                suffix[i] = Math.Max(suffix[i + 1], A[i]);
            }


            //calculate the trapped water
            for (int i = 0; i < A.Count; i++)
            {
                result += Math.Min(prefix[i], suffix[i]) - A[i];
            }

            return result;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/346253/assignment/problems/65?navref=cl_tt_lst_nm
        //Find the first missing integer
        public static int FirstMissingInteger(List<int> A)
        {
            //Use the dictionary which will take O(N) space with O(N) time complexity
            //This space complexity can be reduced to O(1) which will be dealt separately.

            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 1; i <= A.Count; i++)
            {
                result.Add(i, 0);
            }

            foreach (int i in A)
            {
                if (result.ContainsKey(i))
                {
                    result[i]++;
                }
            }

            foreach (var i in result)
            {
                if (i.Value == 0)
                {
                    return i.Key;
                }
            }

            return A.Count;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/346253/assignment/problems/94008?navref=cl_tt_lst_nm
        //It works but it is not optimal and have lot of edge case issues
        public static List<List<int>> MergeOverlappingInterval(List<List<int>> A)
        {
            int startInterval = A[0][0];
            int endInterval = A[0][1];

            var result = new List<List<int>>();

            for (int i = 1; i < A.Count; i++)
            {
                var res = new List<int>();
                if (endInterval >= A[i][0])
                {
                    //startInterval = A[i][0];
                    endInterval = Math.Max(A[i][1], endInterval);
                    if (i == A.Count - 1)
                    {
                        res = new List<int>() { startInterval, endInterval };
                        result.Add(res);
                    }
                    continue;
                }
                else
                {
                    res = new List<int>() { startInterval, endInterval};
                    startInterval = A[i][0];
                    endInterval = A[i][1];
                }

                result.Add(res);

                if (i == A.Count-1)
                {
                    res = new List<int>() { startInterval, endInterval };
                    result.Add(res);
                }
            }

            if (result.Count==0)
            {
                
                result.Add(new List<int>() { startInterval, endInterval });
            }

            return result;

        }
    }
}
