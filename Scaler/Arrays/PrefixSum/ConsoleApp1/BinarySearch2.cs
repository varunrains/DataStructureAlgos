using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class BinarySearch2
    {
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
