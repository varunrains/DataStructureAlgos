using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{

    
 //Definition for binary tree
 class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
        public TreeNode(int x) { this.val = x; this.left = this.right = null; }
 }
 

    internal class Trees
    {
        public List<int> InorderTraversal(TreeNode A)
        {
            var list = new List<int>();
            RecursionTraversal(A, list);
            return list;
        }

        private List<int> RecursionTraversal(TreeNode A, List<int> list)
        {
            if (A == null) { return list; }
            RecursionTraversal(A.left, list);
            list.Add(A.val);
            RecursionTraversal(A.right, list);

            return list;
        }

        public List<int> PreOrderTraversal(TreeNode A)
        {
            var list = new List<int>();
            PreOrderRecursionTraversal(A, list);
            return list;
        }

        public List<int> PreOrderRecursionTraversal(TreeNode A, List<int> list)
        {
            if (A == null) { return list; }
            list.Add(A.val);
            PreOrderRecursionTraversal(A.left, list);
            PreOrderRecursionTraversal(A.right, list);

            return list;
        }


        //https://www.scaler.com/academy/mentee-dashboard/class/236126/assignment/problems/206?navref=cl_tt_lst_nm
        public static List<List<int>> LevelOrderOfATree(TreeNode A)
        {
            var res = new List<List<int>>();

            var queue = new Queue<TreeNode>();
            queue.Enqueue(A);

            while(queue.Count > 0)
            {
                var list = new List<int>();
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var curr = queue.Dequeue();
                    list.Add(curr.val);

                    if(curr.left != null)
                    queue.Enqueue(curr.left);

                    if(curr.right != null)
                     queue.Enqueue(curr.right);

                }
                res.Add(list);
            }

            return res;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236126/assignment/problems/5714?navref=cl_tt_lst_nm
        public static List<int> RightViewOfTheTree(TreeNode A)
        {
            var res = new List<int>();
            
            var queue = new Queue<TreeNode>();
            queue.Enqueue(A);

            while(queue.Count > 0)
            {
                int size = queue.Count;

                for(int i=0; i < size; i++)
                {
                    var curr = queue.Dequeue();

                    if(i == size - 1)
                    {
                        res.Add(curr.val);
                    }

                    if(curr.left != null)
                        queue.Enqueue(curr.left);

                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                }
            }

            return res;

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236126/assignment/problems/224?navref=cl_tt_lst_nm
        public static TreeNode BuildATreeFromInorderAndPostOrder(List<int> A, List<int> B)
        {
            var hashMap = new Dictionary<int, int>();
            for(int i = 0; i < A.Count; i++)
            {
                hashMap[A[i]] = i;
            }

            return ConstructTree(A, B, 0, A.Count-1,0,B.Count-1,hashMap);
        }

        public static TreeNode ConstructTree(List<int> inOrder, List<int> postOrder, int isi, int iei, int psi, int pei, Dictionary<int,int> map)
        {

            if(isi == iei) { return new TreeNode(inOrder[isi]); }

            var root = new TreeNode(postOrder[pei]);
            var idx = map[postOrder[pei]];

            root.left = ConstructTree(inOrder, postOrder, isi, idx - 1, psi, psi + idx -isi - 1, map);
            root.right = ConstructTree(inOrder, postOrder, idx + 1, iei, psi + idx - isi, pei - 1, map);

            return root;
        }




        //https://www.scaler.com/academy/mentee-dashboard/class/236126/assignment/problems/225?navref=cl_tt_lst_nm
        public static int BalancedBinaryTree(TreeNode A)
        {
            bool ans = true;
            HeightOfATreeRec(A, ref ans);
            if (!ans)
                return 0;
            else
                return 1;
        }

        private static int HeightOfATreeRec(TreeNode A, ref bool ans)
        {
            
            if (A == null) return -1;

            int leftSubTree = HeightOfATreeRec(A.left, ref ans);
            int rightSubTree = HeightOfATreeRec(A.right, ref ans);

            if(Math.Abs(leftSubTree - rightSubTree) > 1)
            {
                ans = false;
            }

            return Math.Max(leftSubTree, rightSubTree) + 1;

        }

      



        //https://www.scaler.com/academy/mentee-dashboard/class/236128/assignment/problems/234?navref=cl_tt_lst_nm
        public static int HasPathSum(TreeNode A, int B)
        {

            return HasPathSumRec(A, B) ? 1 : 0;

        }

        private static bool HasPathSumRec(TreeNode A, int remainingSum)
        {
            if (A == null) { return false; }

            remainingSum = remainingSum - A.val;

            if (remainingSum == 0 && A.left == null && A.right == null)
            {
                return true;
            }

            bool leftPathSum = A.left != null && HasPathSumRec(A.left, remainingSum);
            bool rightPathSum = A.right != null && HasPathSumRec(A.right, remainingSum);

            return leftPathSum || rightPathSum;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236130/assignment/problems/35476?navref=cl_tt_lst_nm
        public static int SearchinValidBST(TreeNode A, int B)
        {
            int ans = 0;
            SearchinValidBSTRec(A, B, ref ans);
            return ans;
        }

        public static void SearchinValidBSTRec(TreeNode A, int B, ref int ans)
        {
            if(A == null) { return; }
           
            if (A.val == B)
            {
                ans = 1;
            }

            if (B < A.val)
            {
                SearchinValidBSTRec(A.left, B, ref ans);
            }
            else
            {
                SearchinValidBSTRec(A.right, B, ref ans);
            }
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236130/assignment/problems/221?navref=cl_tt_lst_nm
        public static int IsValidBST(TreeNode A)
        {
            int ans = 1;
            int prev = int.MinValue;
            IsValidBSTRec(A, ref prev, ref ans);

            return ans;
        }


        public static void IsValidBSTRec(TreeNode A, ref int prev, ref int ans)
        {
            if(A == null) { return; }
            
            IsValidBSTRec(A.left, ref prev, ref ans);
            if(prev > A.val) 
            {
                ans = 0;
            }
            prev = A.val;
            IsValidBSTRec(A.right, ref prev, ref ans);
        }



        public TreeNode SortedArrayToBST(List<int> A)
        {
            int low = 0;
            int high = A.Count - 1;
            var root = SortedArrayToBSTRec(A, low,high);
            return root;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236130/assignment/problems/226?navref=cl_tt_lst_nm
        private static TreeNode SortedArrayToBSTRec(List<int> A,int low, int high)
        {
            if (low > high) { return null;  }
            var mid = (low+high)/2;
            var root = new TreeNode(A[mid]);


            root.left = SortedArrayToBSTRec(A,low, mid-1);
            root.right = SortedArrayToBSTRec(A, mid+1, high);

            return root;
        }


        public static int EqualTreePartition(TreeNode A)
        {
           long sum = SumOfTree(A);
           
            if(sum % 2 == 1) return 0;

            var ds = CheckIfWeCanHavePartition(A, sum/2);
            if (ds == true)
            {
                return 1;
            }
            return 0;
        }

        private static bool CheckIfWeCanHavePartition(TreeNode A, long target)
        {

            if(A == null) return false;
            long leftSum = SumOfTree(A.left);
            long rightSum = SumOfTree(A.right);

            if (leftSum == target || rightSum == target)
            {
                return true;
            }

            return (CheckIfWeCanHavePartition(A.left, target) || CheckIfWeCanHavePartition(A.right,target));
        }


        private static long SumOfTree(TreeNode A)
        {
            if(A == null) { return 0; }

            long totalSum = A.val +  SumOfTree(A.left) + SumOfTree(A.right);

            return totalSum;
        }
    }
}
