var searchMatrix = function(matrix, target) {
    let m = matrix.length;
    let n = matrix[0].length;
    let curr=0;
    let startRow = 0;
    let endCol = n-1;
    while(startRow<m && endCol >= 0){
        curr = matrix[startRow][endCol];

        if(curr === target){
            return true;
        }
        else if(target > curr){
            startRow++;
        }
        else if(target < curr){
            endCol--;
        }
    }

    return false;
};


/*

Source: https://leetcode.com/problems/search-a-2d-matrix/

You are given an m x n integer matrix matrix with the following two properties:

Each row is sorted in non-decreasing order.
The first integer of each row is greater than the last integer of the previous row.
Given an integer target, return true if target is in matrix or false otherwise.

You must write a solution in O(log(m * n)) time complexity.

The solution that i have used is the stair case approach and the time complexity is O(M+N) which is linear
https://tcsglobal.udemy.com/course/coding-interview-question-data-structures-algorithm/learn/lecture/18090003#overview
Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
Output: true
*/