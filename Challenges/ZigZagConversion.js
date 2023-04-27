var zigZag = function (str, nRows) {
  let ans = "";
  let res = new Array(nRows);
  let row = 0;
  let step = 1;
  
  if (nRows <= 1) {
    return str;
  }

  for (let i = 0; i < str.length; i++) {
    if (!res[row]) {
      res[row] = "";
    }

    res[row] += str[i];

    if (row === 0) step = 1;

    if (row === nRows - 1) step = -1;

    row = row + step;
  }

  for (let j = 0; j < res.length; j++) {
    ans += res[j] || "";
  }

  return ans;
};

/*
Source: 

https://leetcode.com/problems/zigzag-conversion/

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:
P     I    N
A   L S  I G
Y A   H R
P     I

*/
