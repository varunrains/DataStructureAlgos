var spiralOrder = function(matrix) {
    let res = [];
    
    let m = matrix.length;
    let n = matrix[0].length;

    if(m===0 || n===0) return res;

    let count = 0;
    let startRow = 0;
    let endRow = m -1;
    let startCol = 0;
    let endCol = n -1;

    while(startRow <= endRow && startCol <= endCol){
        //print start row
        for(let i = startCol;i<=endCol;i++){
            res.push(matrix[startRow][i]);
            count++;
        }
        startRow++;
        if(count === m *n){
            return res;
        }
       
        //Print end column
        for(let i = startRow;i<= endRow;i++){
            res.push(matrix[i][endCol]);
            count++;
        }
        endCol--;
        if(count === m *n){
            return res;
        }
       
        //Print end row
        for(let i= endCol; i>= startCol;i--){
            res.push(matrix[endRow][i]);
            count++;
        }
        endRow--;
        if(count === m *n){
            return res;
        }

        //Print start column
        for(let i= endRow; i>= startRow;i--){
            res.push(matrix[i][startCol]);
            count++;
        }
        startCol++;

        if(count === m *n){
            return res;
        }
    }
};


/*
Source: https://leetcode.com/problems/spiral-matrix/

Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]
*/