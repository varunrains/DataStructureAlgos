using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class Sorting
    {
        private const int MOD = 1000000007;

        //https://www.scaler.com/academy/mentee-dashboard/class/235858/assignment/problems/164/submissions
        public static List<int> MergeSortedArrays(List<int> A, List<int> B)
        {
            int i = 0;
            int j = 0;
            var res = new List<int>();
            while (i < A.Count && j < B.Count)
            {
                if (A[i] < B[j])
                {
                    res.Add(A[i]);
                    i++;
                }
                else
                {
                    res.Add(B[j]);
                    j++;
                }
            }

            while(i < A.Count)
            {
                res.Add(A[i]);
                i++;
            }

            while (j < B.Count)
            {
                res.Add(B[j]);
                j++;
            }

            return res;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235858/assignment/problems/21391?navref=cl_tt_nv
        public static List<int> SortUsingCountSort(List<int> A)
        {
            var frequenceArray = new int[1000001];
            var res = new List<int>();
            
            for(int i = 0; i < A.Count; i++)
            {
                frequenceArray[A[i]]++;
            }

            for(int i=0;i < frequenceArray.Length; i++)
            {
                for(int j = 0; j < frequenceArray[i]; j++)
                {
                    res.Add(i);
                }
            }

            //Time complexity of this one is still linear as the frequency array length is always constant
            return res;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235858/assignment/problems/4190?navref=cl_tt_lst_nm
        public static int InversionCountOfAnArray(List<int> A)
        {
            if (A == null || A.Count < 2)
            {
                return 0;
            }

            int[] temp = new int[A.Count];
            return MergeArrayRecWithCount(A, temp, 0, A.Count - 1);
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235858/assignment/problems/4192?navref=cl_tt_lst_nm
        public static int InversionCountWithReversePairs(List<int> A)
        {
            if (A == null || A.Count < 2)
            {
                return 0;
            }

            int[] temp = new int[A.Count];
            return MergeArrayRecWithCountReversePair(A, temp, 0, A.Count - 1);
        }

        private static int MergeSortedArrayWithCount(List<int> A, int[] temp, int l, int m, int r)
        {
            int i = l; int j = m + 1 ; int k = l;
            int count = 0;
            while (i <= m && j <= r)
            {
                if (A[i] <= A[j])
                {
                    temp[k] = A[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = A[j];
                    count += (m + 1 - i);
                    count %= MOD;
                    j++;
                    k++;
                }
            }

            while (i <= m)
            {
                temp[k++] = A[i++];
            }

            while (j <= r)
            {
                temp[k++] = A[j++];
            }

            for (i = l; i <= r; i++)
            {
                A[i] = temp[i];
            }
            return count;
        }

        private static int MergeSortedArrayWithCountReversePair(List<int> A, int[] temp, int l, int m, int r)
        {
            int i = l; int j = m + 1; int k = l;
            int count = 0;

            // Count important reverse pairs
            for (i = l; i <= m; i++)
            {
                while (j <= r && A[i] > 2L * A[j])
                {
                    j++;
                }
                count += j - (m + 1);
                count %= MOD;
            }

            // Reset pointers for merging
            i = l;
            j = m + 1;


            while (i <= m && j <= r)
            {
                if (A[i] > A[j])
                {
                   
                    temp[k] = A[j];
                    //count += (m + 1 - i);
                    //count %= MOD;
                    j++;
                    k++;
                }
                else
                {
                    temp[k] = A[i];
                    i++;
                    k++;
                }
            }

            while (i <= m)
            {
                temp[k++] = A[i++];
            }

            while (j <= r)
            {
                temp[k++] = A[j++];
            }

            for (i = l; i <= r; i++)
            {
                A[i] = temp[i];
            }
            return count;
        }

        private static int MergeArrayRecWithCountReversePair(List<int> A, int[] temp, int l, int r)
        {
            int mid, invCount = 0;
            if (l < r)
            {
                mid = (l + r) / 2;

                invCount += MergeArrayRecWithCountReversePair(A, temp, l, mid);
                invCount %= MOD;

                invCount += MergeArrayRecWithCountReversePair(A, temp, mid + 1, r);
                invCount %= MOD;

                invCount += MergeSortedArrayWithCountReversePair(A, temp, l, mid, r);
                invCount %= MOD;
            }
            return invCount;
        }

        private static int MergeArrayRecWithCount(List<int> A, int[] temp, int l, int r)
        {
            int mid, invCount = 0;
            if (l < r)
            {
                mid = (l + r) / 2;

                invCount += MergeArrayRecWithCount(A, temp, l, mid);
                invCount %= MOD;

                invCount += MergeArrayRecWithCount(A, temp, mid + 1, r);
                invCount %= MOD;

                invCount += MergeSortedArrayWithCount(A, temp, l, mid, r);
                invCount %= MOD;
            }
            return invCount;
        }

        private static List<int> MergeArrayRec(List<int> A, int l, int r)
        {
            if (l >= r) return new List<int>();
            var middle = (l + r) / 2;
            var firstHalf = MergeArrayRec(A, l, middle);
            var secondHalf = MergeArrayRec(A, middle + 1, r);
            return MergeSortedArrays(firstHalf, secondHalf);
        }


    }
}
