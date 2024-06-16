using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class StringProblems
    {
        //
        public static string ReverseAString(string A)
        {
           
            //It is alway wise to use a stringbuilder in loops 
            //as strings are immutable
            //Internally StringBuilder will convert the string to a char array and will
            //perform the operation which will result in less time complexity O(N)
            //If you use normal string and append then it will be additional time complexity of O(N)
            StringBuilder result = new StringBuilder();
            for (int i = A.Length-1; i >=0; i--)
            {
                result.Append(A[i]);
            }

            return result.ToString();

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223205/assignment/problems/11468?navref=cl_tt_lst_sl
        //Convert to uppercase if lowercase and wiseversa
        public static string ToggleTheString(string A)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < A.Length; i++)
            {
                //If the character is lowercase
                if(A[i] >= 96 &&  A[i] <= 122)
                {
                    var toUpperCase = (char)(A[i] - 32);
                    result.Append(toUpperCase);
                }else if(A[i] >= 65 && A[i] <= 90)
                {
                    var toLowerCase = (char)(A[i] + 32);
                    result.Append(toLowerCase);
                }
            }
            return result.ToString();

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223205/assignment/problems/185
        public static string LongestPalindrome(string A)
        {
            //We will find the odd and even string's scenario's
            int oddAns = 0;
            //Length will be 1 as we are looking for odd length
            int oddLength = 1;
            string oddSubstring = string.Empty;
            int oddLeftIndex = 0;
            int evenLeftIndex = 0;
            for(int i=0; i<A.Length; i++)
            {
                int l;
                int r;
                l = r = i;
                oddLength = 1; //reset the length
                while(l >=0 && r < A.Length && A[l] == A[r])
                {

                    if(oddLength > oddAns)
                    {
                        oddAns = oddLength;
                        oddLeftIndex = l;
                    }
                    l--;
                    r++;
                    oddLength += 2; //Or you can use r-l+1 formula for calculating the length
                }
            }

            //For even scenario
            int evenAns = 0;
            //Length will be 1 as we are looking for odd length
            int evenLength = 2;
            string evenSubstring = string.Empty;
            for (int i = 1; i < A.Length; i++)
            {
                int l = i-1;
                int r;
                r = i;
                evenLength = 2; //reset the length
                while (l >= 0 && r < A.Length && A[l] == A[r])
                {

                    if (evenLength > evenAns)
                    {
                        evenAns = evenLength;
                        evenLeftIndex = l ;
                    }
                    l--;
                    r++;
                    evenLength += 2;//Or you can use r-l+1 formula for calculating the length
                }
            }

            var startIndex = oddAns > evenAns ? oddLeftIndex : evenLeftIndex;
            var substringLength = oddAns > evenAns ? oddAns : evenAns;

            return A.Substring(startIndex, substringLength);
        }
    }
}
