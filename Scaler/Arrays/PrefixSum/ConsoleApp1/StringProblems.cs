using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class StringProblems
    {
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
    }
}
