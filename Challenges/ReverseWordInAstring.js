var reverseWords = function (s) {
  var arr = s.split(" ");
  var res = [];
  for (let i = arr.length - 1; i >= 0; i--) {
    let trimmed = arr[i].trim();
    if (!!trimmed) {
      res.push(trimmed);
    }
  }

  return res.join(" ");
};

//This can be solved in a better way also
//Reverse the words first and then the complete string
//Then check on the trailing spaces
/*
Source: https://leetcode.com/problems/reverse-words-in-a-string/description/

Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.
*/
