using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    //Complete notes for this class
    //https://scaler-production-new.s3.ap-southeast-1.amazonaws.com/attachments/attachments/000/203/126/original/Binary_Search_3.pdf?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAIDNNIRGHAQUQRWYA%2F20240906%2Fap-southeast-1%2Fs3%2Faws4_request&X-Amz-Date=20240906T033532Z&X-Amz-Expires=561600&X-Amz-SignedHeaders=host&X-Amz-Signature=f4f492af07b636cfbc15e935f1b7c096b251612d121bf07ba5528dc5036031d4
    internal static class BinarySearch2
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/236088/assignment/problems/271?navref=cl_tt_lst_nm
        public static int PainterPartion(int A, int B, List<int> C)
        {
            int mod_value = 10000003;
            //Define the search space
            long maxInArray = C[0];
            long sumofArray = C[0];
           

            for (int i = 1; i < C.Count; i++)
            {
                maxInArray = Math.Max(maxInArray, C[i]);
                sumofArray += C[i];
            }

            long ans = sumofArray;

            long l = maxInArray;
            long r = sumofArray % mod_value;

            while(l <= r)
            {
               long mid = (l + r) / 2;

                bool isPossibleToPaint = IsPossibleToPaint(C, mid, A);

                if (isPossibleToPaint)
                {
                    ans = mid % mod_value;
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }

            }

            return (int)(ans * B % mod_value) % mod_value;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236088/assignment/problems/4129?navref=cl_tt_nv
        public static int AgressiveCowsPlacing(List<int> A, int B)
        {
            //As the array is not sorted for few inputs
            A.Sort();
            //Define the address space
            int l = int.MaxValue;//This will be minimum distance between the cows in an entire array
            //maximum distance a cow can be placed.
            int r = A[A.Count - 1] - A[0];
            int ans = r;

            for (int i = 1; i < A.Count; i++)
            {
                l = Math.Min(l, A[i] - A[i-1]);
            }

            while(l <= r)
            {
                int mid = (l + r) / 2;

                var isPossibleToPlace = IsPossibleToPlaceTheCows(A,B,mid);

                if (isPossibleToPlace)
                {
                    ans = mid;
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return ans;
        }

        public static bool IsPossibleToPlaceTheCows(List<int> A, int B, int distance)
        {
            int cows = 1;
            int lastPosition = A[0];

            for(int i=1; i<A.Count; i++)
            {
                if (A[i] - lastPosition >= distance)
                {
                    cows++;
                    lastPosition = A[i];
                }
            }

            if(cows < B)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool IsPossibleToPaint(List<int> painterBoard, long totalTime, int painters)
        {
            int numberOfpainters = 1;
            int sum = 0;
            for (int i = 0; i < painterBoard.Count; i++)
            {
                sum += painterBoard[i];

                if(sum > totalTime)
                {
                    numberOfpainters++;
                    sum = painterBoard[i];
                }
            }

            if(numberOfpainters > painters)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
