using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<int> RecursionTraversal(TreeNode A, List<int> list)
        {
            if (A == null) { return list; }
            RecursionTraversal(A.left, list);
            list.Add(A.val);
            RecursionTraversal(A.right, list);

            return list;
        }
    }
}
