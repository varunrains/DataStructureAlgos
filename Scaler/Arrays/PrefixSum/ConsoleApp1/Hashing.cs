using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class Hashing
    {
        public static List<int> FrequenceOfElementQuery(List<int> A, List<int> B)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            var res = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (map.ContainsKey(A[i]))
                {
                    map[A[i]]++;
                }
                else
                {
                    map.Add(A[i], 1);
                }
            }

            for (int i = 0; i < B.Count; i++)
            {
                var val = 0;
                map.TryGetValue(B[i], out val);
                res.Add(val);
            }

            return res;

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235844/assignment/problems/27502?navref=cl_tt_lst_nm
        public static int CountUniqueElements(List<int> A)
        {
            var hashSet = new HashSet<int>();

            for (int i = 0; i < A.Count; i++)
            {
                hashSet.Add(A[i]);
            }
            return hashSet.Count;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235844/assignment/problems/11882?navref=cl_tt_lst_nm
        public static int FirstRepeatingElement(List<int> A)
        {
            var hashMap = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (hashMap.ContainsKey(A[i]))
                {
                    hashMap[A[i]]++;
                }
                else
                {
                    hashMap.Add(A[i], 1);
                }
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (hashMap.ContainsKey(A[i]) && hashMap[A[i]] > 1)
                {
                    return A[i];
                }
            }
            return -1;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235844/assignment/problems/4202?navref=cl_tt_lst_nm
        public static int SubArrayWithSumZero(List<int> A)
        {
            //Just find the prefix sum of the array and if the prefix sum contains repeating numbers
            //Then it means that there is a sub-array with zero sum
            //Prefix sum = P[r] - P[l-1]
            //So P[r] = P[l-1]
            //As A[i] can be large 10^9 then the prefix sum will overflow so take long data type
            var prefixSum = new long[A.Count];
            var hashSet = new HashSet<long>();
            prefixSum[0] = A[0];
            if (prefixSum[0] == 0)
            {
                return 1;
            }
            hashSet.Add(prefixSum[0]);
            for (int i = 1; i < A.Count; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i];

                //In any step if there is a zero then the subarray sum will be zero return
                if (prefixSum[i] == 0)
                {
                    return 1;
                }
                hashSet.Add(prefixSum[i]);
            }

            if (hashSet.Count == A.Count)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235844/assignment/problems/10203?navref=cl_tt_lst_nm
        public static List<int> CommonElements(List<int> A, List<int> B)
        {
            var hasmap1 = new Dictionary<int, int>();
            var hasmap2 = new Dictionary<int, int>();
            var res = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (hasmap1.ContainsKey(A[i]))
                {
                    hasmap1[A[i]]++;
                }
                else
                {
                    hasmap1.Add(A[i], 1);
                }
            }

            for (int i = 0; i < B.Count; i++)
            {
                if (hasmap2.ContainsKey(B[i]))
                {
                    hasmap2[B[i]]++;
                }
                else
                {
                    hasmap2.Add(B[i], 1);
                }
            }

            foreach (var hash in hasmap1)
            {
                if (hasmap2.ContainsKey(hash.Key))
                {
                    var valueToRepeat = 0;
                    if (hasmap2[hash.Key] == hasmap1[hash.Key])
                    {
                        valueToRepeat = hasmap1[hash.Key];
                    }
                    else
                    {
                        valueToRepeat = hasmap1[hash.Key] > hasmap2[hash.Key] ? hasmap2[hash.Key] : hasmap1[hash.Key];
                    }
                    var temp = Enumerable.Range(0, valueToRepeat).Select(x => hash.Key);
                    res.AddRange(temp);
                }
            }
            return res;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235844/homework/problems/27543?navref=cl_tt_lst_nm
        public static int CountUniqueElementsContainingDuplicates(List<int> A)
        {
            var hashMap = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (hashMap.ContainsKey(A[i]))
                {
                    hashMap[A[i]]++;
                }
                else
                {
                    hashMap.Add(A[i], 1);
                }
            }

            int countOfUniqueElements = 0;
            foreach (var item in hashMap)
            {
                if(item.Value == 1)
                {
                    countOfUniqueElements++;
                }
            }

            return countOfUniqueElements;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235844/homework/problems/27776?navref=cl_tt_lst_nm
        public static int NumberOfSubArraysWithSumZero(List<int> A)
        {
            int subArraysWithSumZero = 0;
            int l = 0;
            int r = 0;
            int sum = 0;
            while (l <= r && r < A.Count)
            {
                if (A[l] == 0)
                {
                    subArraysWithSumZero++;
                }
                sum+= A[l];
            }
        }
    }
}
