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

                if (A[i] == '0')
                {
                    int l = i - 1;
                    int r = i + 1;
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
                        if (A[l] == '1')
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

            if (totalOnes == A.Length)
            {
                return totalOnes;
            }

            longestLength = longestLength > totalOnes ? --longestLength : longestLength;
            return longestLength;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223199/assignment/problems/27363?navref=cl_tt_lst_nm
        //same approach can be used to find out the rain water trap problem
        //Pre-process the data in the array and then use it to obtain the solution in linear time complexity
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
            for (int i = 0; i < s.Length; i++)
            {
                int productValue = int.Parse(s[i].ToString()) * 1;
                isTrue = map.TryAdd(productValue, 1);
                if (!isTrue) return 0;
                for (int j = i + 1; j < s.Length && j - i == 1; j++)
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
            Dictionary<int, int> map = new Dictionary<int, int>();
            int maxNumber = 0;
            int maxFrequency = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (map.ContainsKey(a[i]))
                {
                    map[a[i]]++;
                    if (maxFrequency < map[a[i]])
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

        //https://www.scaler.com/academy/mentee-dashboard/class/235836/assignment/problems/56?navref=cl_tt_lst_nm
        //This approach to find the maximum subarray is also called kadane's algorithm
        public static int MaximumSubArray(List<int> A)
        {
            //Just to find the find the indexes of the largest subarray
            int L = 0;
            int R = 0;
            int result = int.MinValue;
            int sum = 0;

            if (A.Count == 1)
            {
                return A[0];
            }

            for (int i = 0; i < A.Count; i++)
            {
                sum += A[i];

                if (result < sum)
                {
                    result = sum;
                    R = i;
                }

                if (sum < 0)
                {
                    L = i + 1;
                    sum = 0;
                }
            }

            return result;

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235836/assignment/problems/440?navref=cl_tt_lst_nm
        public static List<int> ContinuousSumQuery(int A, List<List<int>> B)
        {
            int[] beggarPot = new int[A];

            for (int i = 0; i < B.Count; i++)
            {
                //to make it zero based index
                var l = B[i][0] - 1;
                var r = B[i][1] - 1;
                var donation = B[i][2];
                beggarPot[l] += donation;

                if (r != A - 1)
                {
                    beggarPot[r + 1] -= donation;
                }
            }

            for (int i = 1; i < A; i++)
            {
                beggarPot[i] = beggarPot[i - 1] + beggarPot[i];
            }
            return beggarPot.ToList();
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235836/assignment/problems/47
        public static int RainWaterTrap(List<int> A)
        {
            int trap = 0;
            var maxArrayRight = new int[A.Count];
            var maxArrayLeft = new int[A.Count];
            //Precompute maximum and minimum array

            maxArrayLeft[0] = A[0];
            maxArrayRight[A.Count - 1] = A[A.Count - 1];

            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] > maxArrayLeft[i - 1])
                {
                    maxArrayLeft[i] = A[i];
                }
                else
                {
                    maxArrayLeft[i] = maxArrayLeft[i - 1];
                }
            }

            for (int j = A.Count - 2; j >= 0; j--)
            {
                if (A[j] > maxArrayRight[j + 1])
                {
                    maxArrayRight[j] = A[j];
                }
                else
                {
                    maxArrayRight[j] = maxArrayRight[j + 1];
                }
            }

            //Rain water traps between buildings
            for (int i = 0; i < A.Count; i++)
            {
                trap += Math.Min(maxArrayLeft[i], maxArrayRight[i]) - A[i];
            }

            return trap;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235836/homework/problems/66?navref=cl_tt_lst_nm
        public static List<int> AddOneToNumber(List<int> A)
        {
            int i = 0;
            //Remove leading zeros
            while (i < A.Count)
            {

                if (A[i] == 0 && i - 1 < 0)
                {
                    A.RemoveAt(i);
                    i = 0;
                }
                else
                {
                    break;
                }
                
            }
            i = 0;
            int j = A.Count - 1;
            //Reverse the array so that it will become easy for the carry to add
            while (i < j)
            {
                var temp = A[i];
                A[i] = A[j]; 
                A[j] = temp;
                i++;
                j--;
            }
            int carryforward = 1;
            for(int k = 0; k < A.Count; k++)
            {
                A[k] = carryforward + A[k];

                if (A[k] != 0 && (A[k] % 10 == 0))
                {
                    A[k] = 0;
                }
                else
                {
                    carryforward = 0;
                }
            }

            if(carryforward != 0)
            {
                A.Add(carryforward);
            }

            i = 0;
            j = A.Count - 1;
            //Again reverse the array
            while (i < j)
            {
                var temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i++;
                j--;
            }

            return A;
        }
    }
}
