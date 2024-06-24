using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class ArrayPrograms3
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/223199/assignment/problems/2/hints?navref=cl_pb_nv_tb
        //We can use HashMap to get the frequency of element which will take O(N) space to optimize it we can use
        //moore's formula where we can find it using the frequency and reset
        public static int MajorityElement(List<int> A)
        {
            int majorityElement = int.MinValue;
            int frequency = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (frequency == 0)
                {
                    majorityElement = A[i];
                    frequency++;
                }
                else if (A[i] == majorityElement)
                {
                    frequency++;
                }
                else
                {
                    frequency--;
                }
            }

            frequency = 0;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == majorityElement)
                {
                    frequency++;
                }
            }

            if (frequency > A.Count / 2)
            {
                return majorityElement;
            }
            else return 0;
        }


        //https://www.scaler.com/academy/mentee-dashboard/class/223199/assignment/problems/4256?navref=cl_tt_lst_nm
        public static int LengthOfLongestConsecutiveOnes(string A)
        {
            int longestLength = 0;
            int totalOnes = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '1')
                {
                   totalOnes++;
                }

                if(A[i] == '0')
                {
                    int l = i-1;
                    int r = i+1;
                    int numberOfOnes = 1;
                    while (r < A.Length)
                    {
                       
                        if (A[r] == '1')
                        {
                            numberOfOnes++;
                        }
                        else
                        {
                            break;
                        }
                        r++;
                    }
                    while (l >= 0)
                    {
                        if(A[l] == '1')
                        {
                            numberOfOnes++;
                        }
                        else
                        {
                            break;
                        }
                        l--;
                    }
                    numberOfOnes = numberOfOnes == 1 ? --numberOfOnes : numberOfOnes;
                    longestLength = Math.Max(longestLength, numberOfOnes);
                }
            }

            if(totalOnes == A.Length)
            {
                return totalOnes;
            }

            longestLength = longestLength > totalOnes ? --longestLength: longestLength;
            return longestLength;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223199/assignment/problems/27363?navref=cl_tt_lst_nm
        public static int CountIncreasingTriplets(List<int> A)
        {
            int N = A.Count;
            if (N < 3) return 0;

            int[] leftSmaller = new int[N];
            int[] rightLarger = new int[N];

            //Calculate the smaller elements left to the current position
            for (int i = 1; i < A.Count; i++)
            {
                var left = i - 1;
                while (left >= 0)
                {
                    if (A[left] < A[i])
                    {
                        leftSmaller[i]++;
                    }
                    left--;
                }
            }

            //Calculate the bigger elements right to the current position
            for (int i = 0; i < A.Count; i++)
            {
                var right = i + 1;
                while (right < A.Count)
                {
                    if (A[i] < A[right])
                    {
                        rightLarger[i]++;
                    }
                    right++;
                }
            }

            // Calculate the number of valid triplets
            int tripletCount = 0;
            //First and the last element cannot be in a triplet calculation 
            for (int j = 1; j < N - 1; j++)
            {
                tripletCount += leftSmaller[j] * rightLarger[j];
            }

            return tripletCount;
        }

     

        //https://www.scaler.com/academy/mentee-dashboard/class/223199/homework/problems/275/hints?navref=cl_pb_nv_tb
        public static int ColorFulNumbers(int A)
        {
            string s = A.ToString();
            List<int> numbers = new List<int>();
            var isTrue = false;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < s.Length; i++)
            {
                int productValue = int.Parse(s[i].ToString())* 1;
                isTrue = map.TryAdd(productValue, 1);
                if (!isTrue) return 0;
                for (int j=i+1; j < s.Length && j-i == 1; j++)
                {
                    productValue *= int.Parse(s[j].ToString());
                    isTrue = map.TryAdd(productValue, 1);
                    if (!isTrue) return 0;
                }
            }

            return 1;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223199/homework/problems/67?navref=cl_tt_lst_nm


        public static int RepeatN3Numbers(List<int> a)
        {
            if (a.Count == 1) return a[0];
            Dictionary<int,int> map = new Dictionary<int,int>();
            int maxNumber = 0;
            int maxFrequency = 0;
            for(int i = 0; i < a.Count; i++)
            {
                if (map.ContainsKey(a[i]))
                {
                    map[a[i]]++;
                    if(maxFrequency < map[a[i]])
                    {
                        maxFrequency = map[a[i]];
                        maxNumber = a[i];
                    }
                }
                else
                {
                    map.Add((int)a[i], 1);
                }
            }
           

            var result = maxFrequency > a.Count / 3 ? maxNumber : -1;
            return result;
        }
    }



}
