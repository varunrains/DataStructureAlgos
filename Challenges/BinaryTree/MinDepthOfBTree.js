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
 * @return {number}
 */
var minDepth = function (root, level = 1) {
  if (root === null && level === 1) return 0;
  if (root === null) return Infinity;
  if (!root?.left && !root?.right) return level;
  
  level++;
  return Math.min(minDepth(root.left, level), minDepth(root.right, level));
};


/*
Source:https://leetcode.com/problems/minimum-depth-of-binary-tree/description/

Input: root = [3,9,20,null,null,15,7]
Output: 2

*/