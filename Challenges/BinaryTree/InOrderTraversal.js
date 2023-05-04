/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var inorderTraversal = function (root, ans = []) {
  if (!root) return ans;

  inorderTraversal(root.left, ans);
  ans.push(root.val);
  inorderTraversal(root.right, ans);

  return ans;
};


/*
Source: https://leetcode.com/problems/binary-tree-inorder-traversal/
Input: root = [1,null,2,3]
Output: [1,3,2]


*/