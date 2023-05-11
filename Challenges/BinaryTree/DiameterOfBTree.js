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

class Pair {
  constructor(height, diameter) {
    this.height = height;
    this.diameter = diameter;
  }
}

var diameterOfBinaryTree = function (root) {
  return diameterOfBinaryTreeHelper(root).diameter;
};

var diameterOfBinaryTreeHelper = function (root) {
  if (root === null) {
    return new Pair(0, 0);
  }

  let leftAns = diameterOfBinaryTreeHelper(root.left);
  let rightAns = diameterOfBinaryTreeHelper(root.right);

  lh = leftAns.height;
  ld = leftAns.diameter;

  rh = rightAns.height;
  rd = rightAns.diameter;

  let height = 1 + Math.max(lh, rh);
  let diameter = Math.max(lh + rh, ld, rd);

  return new Pair(height, diameter);
};


/*
Source: https://leetcode.com/problems/diameter-of-binary-tree/

Input: root = [1,2,3,4,5]
Output: 3
Explanation: 3 is the length of the path [4,2,1,3] or [5,2,1,3].
*/