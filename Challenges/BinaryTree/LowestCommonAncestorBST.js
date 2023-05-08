/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */

/**
 * @param {TreeNode} root
 * @param {TreeNode} p
 * @param {TreeNode} q
 * @return {TreeNode}
 */
var lowestCommonAncestor = function(root, p, q) {
    while(root != null){
        if(root.val > p.val && root.val > q.val){
            root = root.left;
        }
        else if(root.val < p.val && root.val < q.val){
            root = root.right;
        }
        else{
            return root;
        }
    }
    return null;
};


/*
Source:https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
Output: 6
Explanation: The LCA of nodes 2 and 8 is 6.

*/