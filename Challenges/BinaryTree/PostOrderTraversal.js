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
var postorderTraversal = function(root, ans = []) {
    if(root === null) return ans;

    postorderTraversal(root.left, ans);
    postorderTraversal(root.right, ans);
    ans.push(root.val);

    return ans;
};

/*
Source:https://leetcode.com/problems/binary-tree-postorder-traversal/
Input: root = [1,null,2,3]
Output: [3,2,1]

*/