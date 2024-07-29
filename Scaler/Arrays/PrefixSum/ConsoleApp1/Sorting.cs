using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class Sorting
    {
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
            var frequenceArray = new int[100000];
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


    }
}
