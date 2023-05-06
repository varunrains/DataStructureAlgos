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
 * @return {number[][]}
 */
var levelOrderBottom = function (root) {
  let queue = [root, null];
  let res = [];
  let level = [];

  while (queue.length > 0) {
    let current = queue.shift();

    if (current) {
      level.push(current.val);
    }

    if (current?.left) queue.push(current.left);
    if (current?.right) queue.push(current.right);

    if (current === null && level.length !== 0) {
      //To print in reverse order
      res.unshift(level);
      level = [];
      queue.push(null);
    }
  }
  return res;
};

/*
Source: https://leetcode.com/problems/binary-tree-level-order-traversal-ii/

Input: root = [3,9,20,null,null,15,7]
Output: [[15,7],[9,20],[3]]

*/
