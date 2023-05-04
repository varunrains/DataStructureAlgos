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
var preorderTraversal = function(root, ans=[]) {
    if(root === null) return ans;

    ans.push(root.val);
    preorderTraversal(root.left, ans);
    preorderTraversal(root.right,ans);

    return ans;
};


/*
Source: https://leetcode.com/problems/binary-tree-preorder-traversal/description/
Input: root = [1,null,2,3]
Output: [1,2,3]

*/