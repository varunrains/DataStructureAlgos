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
var zigzagLevelOrder = function (root) {
  let queue = [root, null];
  let res = [];
  let level = [];
  let isOddLevel = true;
  while (queue.length > 0) {
    let current = queue.shift();
    console.log(current?.val);
    if (current) {
      if (isOddLevel) {
        level.unshift(current.val);
      } else {
        level.push(current.val);
      }
    }

    if (current?.right) queue.push(current.right);
    if (current?.left) queue.push(current.left);

    if (current === null && level.length !== 0) {
      res.push(level);
      level = [];
      queue.push(null);
      isOddLevel = !isOddLevel;
    }
  }

  return res;
};

/*
Source: https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
Go through other level order traversal algo's to understand this better;
Input: root = [3,9,20,null,null,15,7]
Output: [[3],[20,9],[15,7]]

*/
