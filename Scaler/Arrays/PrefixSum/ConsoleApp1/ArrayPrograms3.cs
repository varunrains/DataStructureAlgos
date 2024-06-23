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
            int tripletCount = 0;
            int triplet = 2;
            int highestNumber;
            for (int i = 0; i < A.Count; i++)
            {
                int r = i + 1;
                triplet = 2;
                highestNumber = int.MinValue;
                while (A.Count - i >= 3 && r < A.Count)
                {
                    if (A[i] < A[r] && highestNumber == int.MinValue)
                    {
                        highestNumber = A[r];
                        triplet--;
                    }else if(highestNumber !=  int.MinValue && highestNumber < A[r])
                    {
                        triplet--;
                    }

                    if (triplet == 0)
                    {
                        tripletCount++;
                        triplet = 2;
                        //highestNumber = int.MinValue;
                    }
                    r++;
                }
            }

            return tripletCount;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223199/homework/problems/275/hints?navref=cl_pb_nv_tb
        public static int ColorFulNumbers(int A)
        {
            string s = A.ToString();
            List<int> numbers = new List<int>();
            Dictionary<string, int> map = new Dictionary<string, int>();
            for(int i = 0; i < s.Length; i++)
            {
                numbers.Add(int.Parse(s[i].ToString()));
                for (int j=i+1; j < s.Length; j++)
                {
                    map.Add(s[i].ToString(), 1);
                }
            }

            return 0;
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
