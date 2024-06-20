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

        //https://www.scaler.com/academy/mentee-dashboard/class/223205/homework/problems/10748/submissions
        public static int CountOccurences(string A)
        {
            var matchTo = "bob";
            int counter = 0;
            int j = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != matchTo[j])
                {
                    if(j > 0)
                    {
                        i--;
                    }
                    j = 0;
                    continue;
                }
                else
                {
                    j++;
                    if(j == matchTo.Length)
                    {
                        i--;
                        j = 0;
                        counter++;
                    }
                }
            }

            return counter;

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223205/homework/problems/10695?navref=cl_tt_nv
        public static int IsAlphaNumeric(List<char> A)
        {
            int counter = 0;
            for(int i=0; i<A.Count; i++)
            {
                if(A[i] >= 65 &&  A[i] <= 90)
                {
                   counter++;
                }

               else if(A[i] >= 48 && A[i] <= 57)
                {
                    counter++;
                }
                else if(A[i] >= 97 && A[i] <= 122)
                {
                    counter++;
                }
            }
            var result = counter == A.Count ? 1 : 0;
            return result;
        }

        public static int Anagrams(string A, string B)
        {

            if (A.Length != B.Length) return 0;
            Dictionary<string, int> map = new Dictionary<string, int>();

            for(int i = 0; i < A.Length; i++)
            {
                if (map.ContainsKey(A[i].ToString()))
                {
                    map[A[i].ToString()]++;
                }
                else
                {
                    map.Add(A[i].ToString(), 1);
                }
            }

            for(int i = 0; i < B.Length; i++)
            {
                if (map.ContainsKey(B[i].ToString()))
                {
                    
                    map[B[i].ToString()]--;
                }
                else
                {
                    return 0;
                }
            }

            foreach(var dic in map) {
                if(dic.Value > 0)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
