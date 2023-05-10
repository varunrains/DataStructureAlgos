
 //* Definition for a binary tree node.
  class TreeNode {
    constructor(val, left, right){
      this.val = (val===undefined ? 0 : val)
     this.left = (left===undefined ? null : left)
     this.right = (right===undefined ? null : right)
    }
 }
 
/**
 * @param {number[]} preorder
 * @param {number[]} inorder
 * @return {TreeNode}
 */

var buildTree = function(preorder, inorder) {
    let len = preorder.length;
    return buildTreeHelper(preorder, inorder,0,len-1,0,len-1);
};

var buildTreeHelper = function(preorder, inorder,inS, inE, prS, prE){
    if(inS > inE) return null;
    let rootIndex = -1;
    let root = preorder[prS];
    let rootNode = new TreeNode(root);

    for(let i = 0;i<inorder.length;i++){
        if(inorder[i] === root){
            rootIndex = i;
            break;
        }
    }

    let leftInorderStart = inS;
    let leftInorderEnd = rootIndex - 1;
    let leftPreOrderStart = prS + 1;
    let leftPreOrderEnd = leftInorderEnd - leftInorderStart + leftPreOrderStart;

    let rightInorderStart = rootIndex + 1;
    let rightInOrderEnd = inE;
    let rightPreOrderStart = leftPreOrderEnd + 1;
    let rightPreOrderEnd = prE;


    rootNode.left = buildTreeHelper(preorder, inorder,leftInorderStart, leftInorderEnd, leftPreOrderStart, leftPreOrderEnd);
    rootNode.right = buildTreeHelper(preorder, inorder, rightInorderStart, rightInOrderEnd, rightPreOrderStart, rightPreOrderEnd);

    return rootNode;
}

/*
Source: https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
Output: [3,9,20,null,null,15,7]

*/