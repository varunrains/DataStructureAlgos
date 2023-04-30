var rotate = function (matrix) {
  let m = matrix.length; //rows
  let n = matrix[0].length; //cols

  //Transpose the matrix i.e. swap the rows and cols

  for (let row = 0; row < m; row++) {
    for (let col = row; col < n; col++) {
      let temp = matrix[row][col];
      matrix[row][col] = matrix[col][row];
      matrix[col][row] = temp;
    }
  }

  //Reverse the row to get the 90 degree rotation

  for (let row = 0; row < n; row++) {
    let start = 0;
    let end = n - 1;

    while (start <= end) {
      let temp = matrix[row][start];
      matrix[row][start] = matrix[row][end];
      matrix[row][end] = temp;

      start++;
      end--;
    }
  }
};

/*
Source: https://leetcode.com/problems/rotate-image/
Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [[7,4,1],[8,5,2],[9,6,3]]

This question can be asked in multiple ways
Rotate image
Rotate matrix by 90 degree, -90 degree, 180 degree, -180 degree
*/
