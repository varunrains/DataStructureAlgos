var removeDuplicates = function (s) {
  let temp = [];

  for (let i = 0; i < s.length; i++) {
    if (temp.length === 0) {
      temp.push(s[i]);
    } else {
      let top = temp.pop();
      if (top !== s[i]) {
        temp.push(top);
        temp.push(s[i]);
      }
    }
  }

  return temp.join("");
};

removeDuplicates("abbaca");
/*
Source: https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/

Input: s = "abbaca"
Output: "ca"
Explanation: 
For example, in "abbaca" we could remove "bb" since the letters 
are adjacent and equal, and this is the only possible move.  
The result of this move is that the string is "aaca", of which 
only "aa" is possible, so the final string is "ca".
*/
