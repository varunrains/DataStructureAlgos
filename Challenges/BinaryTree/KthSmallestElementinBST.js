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
 * @param {number} k
 * @return {number}
 */
var kthSmallest = function (root, k) {
    let ans = [];
    kthSmallestHelper(root, ans);
    return ans[k-1];
  };
  

var kthSmallestHelper = function (root, ans) {
  if (root === null) return ans;

  kthSmallestHelper(root.left, ans);
  ans.push(root.val);
  kthSmallestHelper(root.right, ans);
};

/*
Source: https://leetcode.com/problems/kth-smallest-element-in-a-bst/

Input: root = [3,1,4,null,2], k = 1
Output: 1

Do this problem without using array you can use IIFE in javascript
where you can maintain the count from the calling function
*/
