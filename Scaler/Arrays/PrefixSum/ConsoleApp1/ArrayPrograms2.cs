using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class ArrayPrograms2
    {
        public static List<List<int>> GenerateSubArrays(List<int> A)
        {
            var result = new List<List<int>>();

            for (int start = 0; start < A.Count; start++)
            {
                for (int end = start; end < A.Count; end++)
                {
                    var subArray = new List<int>();

                    for (int printer = start; printer <= end; printer++)
                    {
                        subArray.Add(A[printer]);
                    }
                    result.Add(subArray);
                }
            }
            return result;
        }

        public static List<int> GenerateSubArraysInRange(List<int> A, int B, int C)
        {
            var result = new List<int>();

            for (int start = B; start <= C; start++)
            {
                result.Add(A[start]);


            }
            return result;
        }

        public static int BestTimeToBuyStock(List<int> A)
        {
            int l_minIndex = 0;
            int l_maxIndex = A.Count - 1;
            if (A.Count <= 0) { return 0; }
            int maximumNumber = int.MinValue;
            int minimumNumber = int.MaxValue;

            for (int i = 0; i < A.Count; i++)
            {

                if (A[i] < minimumNumber)
                {

                    minimumNumber = A[i];
                    l_minIndex = i;
                }
                if (A[i] > maximumNumber)
                {

                    maximumNumber = A[i];
                    l_maxIndex = i;

                }
            }
            if (l_minIndex >= l_maxIndex) return 0;
            return maximumNumber - minimumNumber;
        }

        public static int CountUniqueSubarrays(List<int> A)
        {
            int left = 0, right = 0;
            int ans = 0;
            Dictionary<string, int> hashMap = new Dictionary<string, int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (hashMap.ContainsKey(A[i].ToString()))
                {
                    hashMap[A[i].ToString()]++;
                }
                else
                {
                    hashMap.Add(A[i].ToString(), 1);
                }
                ans += right - left + 1;
                right++;
            }

            return ans;


            //Dictionary<string, int> counterMap = new Dictionary<string, int>();
            //for (int i= 0; i < result.Count; i++)
            //{

            //    for (int j = 0; j < result[i].Count; j++)
            //    {
            //        if (!counterMap.ContainsKey(result[i][j].ToString()))
            //        {
            //            counterMap.Add(result[i][j].ToString(), 1);
            //        }
            //        else
            //        {
            //            counterMap[result[i][j].ToString()]++;
            //            break;
            //        }    
            //       if(j== result[i].Count - 1)
            //        {
            //            count++;
            //        }

            //    }

            //    counterMap.Clear();

            //}
            //Since the number of subarrays could be large, return value % 109 +7.
            //return result.Count % 1000000007;
        }

        public static int CountingSubArrays(List<int> A, int B)
        {
            int subArrayCount = 0;
            for (int l = 0; l < A.Count; l++)
            {
                int sum = 0;

                for (int r = l; r < A.Count; r++)
                {
                    sum += A[r];
                    if (sum < B)
                    {
                        subArrayCount++;

                    }
                }
            }
            return subArrayCount;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223211/homework/problems/4033?navref=cl_tt_lst_sl
        //This can be achieved through the sliding window
        public static int MinimumSwaps(List<int> A, int B)
        {
            int windowSize = 0;
            //First find the number of items less than or equal to B to get the window size
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] <= B)
                {
                    windowSize++;
                }
            }

            int greaterThanB = 0;
            //Check for the first window size
            for (int i = 0; i < windowSize; i++)
            {
                if (A[i] > B)
                {
                    greaterThanB++;
                }
            }
            int result = greaterThanB;
            //Check from the next window size -- slide the window
            for (int i = 1; i < A.Count - windowSize; i++)
            {
                if (A[i - 1] > B)
                {
                    //As this item is now removed from the window
                    greaterThanB--;
                }
                if (A[i + windowSize - 1] > B)
                {
                    //For the new element in the window add check if it is greater
                    greaterThanB++;
                }
                //As we need to find the minimum swaps, in each window check if it is minimum
                if (greaterThanB < result)
                {
                    result = greaterThanB;
                }

            }
            return result;
        }

        public static int SubArrayWithGivenSumAndLength(List<int> A, int B, int C)
        {
            //This can be solved by sliding window as the size of the sub-array is given to us

            //First find the first subarray sum
            if (A.Count == 1 && A[0] == C)
                return 1;

            int sum = 0;
            for (int i = 0; i < B; i++)
            {
                sum += A[i];

            }
            if (sum == C) return 1;

            //Actual sliding window starts

            for (int l = B; l < A.Count - 1; l++)
            {
                int r = l - B;
                sum = sum + (A[l] - A[r]);
                if (sum == C)
                {
                    return 1;
                }
            }
            return 0;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223211/homework/problems/12827?navref=cl_tt_lst_sl
        public static int SubarrayWithLeastAverage(List<int> A, int B)
        {
            int minSum = 0;
            int sum = 0;
            int returnMinIndex = 0;
            for (int l = 0; l < B; l++)
            {
                sum += A[l];
            }
            minSum = sum;

            for (int r = B; r < A.Count; r++)
            {
                int l = r - B;
                sum += A[r] - A[l];
                var result = Math.Min(minSum, sum);
                if (result != minSum)
                {
                    minSum = result;
                    //As the left index will be one behind
                    returnMinIndex = l + 1;
                }
            }

            return returnMinIndex;
        }

        public static int ClosestMinMax(List<int> A)
        {
            int maxElement = int.MinValue;
            int minElement = int.MaxValue;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] < minElement)
                {
                    minElement = A[i];
                }
                if (A[i] > maxElement)
                {
                    maxElement = A[i];
                }
            }

            //Minimum and maximum index will be always at the edge in a subarray
            //Go over an array and store the min and max index/ max and min index
            //whichever comes first and then calculate the length of the subarray
            //by formula R-L+1 to get the length

            int l_min = -1;
            int l_max = -1;
            int ans = int.MaxValue; //Minimum length of subarray
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == minElement)
                {
                    l_min = i;
                    if (l_max != -1)
                    {
                        ans = Math.Min(ans, l_min - l_max + 1);
                    }

                }

                if (A[i] == maxElement)
                {
                    l_max = i;
                    if (l_min != -1)
                    {
                        ans = Math.Min(ans, l_max - l_min + 1);
                    }
                }
            }

            return ans;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223211/homework/problems/16094?navref=cl_tt_lst_nm
        public static int GoodSubArrays(List<int> A, int B)
        {
            //find the prefix sum
            List<int> prefixSumArray = new List<int>
            {
                A[0]
            };
            int goodSubarrayCount = 0;
            var toAdd = 0;
            for (int i = 1; i < A.Count; i++)
            {
                toAdd = prefixSumArray[i - 1] + A[i];
                prefixSumArray.Add(toAdd);
            }

            for (int l = 0; l < A.Count; l++)
            {
                for (int r = l; r < A.Count; r++)
                {
                    var len = r - l + 1;
                    //even sub-array
                    if (len % 2 == 0)
                    {
                        var evenTotalValue = l == 0 ? prefixSumArray[r] : prefixSumArray[r] - prefixSumArray[l - 1];
                        if (evenTotalValue < B)
                        {
                            goodSubarrayCount++;
                        }
                    }
                    else
                    {
                        var oddTotalValue = l == 0 ? prefixSumArray[r] : prefixSumArray[r] -  prefixSumArray[l - 1];
                        if (oddTotalValue > B)
                        {
                            goodSubarrayCount++;
                        }
                    }
                }
            }

            return goodSubarrayCount;
        }
    }
}


