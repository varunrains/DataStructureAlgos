using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class Scaler4thTest
    {
        public static List<int> NextWarmerTemperature(List<int> A)
        {
            int n = A.Count;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                // Pop elements from the stack until we find a day with a higher temperature
                while (stack.Count > 0 && A[i] > A[stack.Peek()])
                {
                    int index = stack.Pop();
                    result[index] = i - index;
                }
                // Push current day index to the stack
                stack.Push(i);
            }

            // The remaining elements in the stack don't have a warmer future day
            while (stack.Count > 0)
            {
                result[stack.Pop()] = 0;
            }

            return result.ToList();

        }


        public static int KthSmallestElement(TreeNode root, int B)
        {
            var res = new List<int>();

            KthSmallestInBST(root, B,res);

            return res[B - 1];
        }

        public static List<int> KthSmallestInBST(TreeNode root, int B, List<int> list)
        {
            if (root == null) return list;

            KthSmallestInBST(root.left, B, list);
            list.Add(root.val);
            KthSmallestInBST(root.right, B, list);

            return list;
        }


        //One more question on rotated sorted array by applying the binary search
        // //https://www.scaler.com/academy/mentee-dashboard/class/235860/assignment/problems/203?navref=cl_tt_lst_nm
    }
}
