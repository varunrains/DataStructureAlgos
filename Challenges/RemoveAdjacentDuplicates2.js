var removeDuplicates = function (s, k) {
  let temp = [];
  let res = "";

  for (let i = 0; i < s.length; i++) {
    if (temp.length === 0) {
      let obj = {};
      obj[s[i]] = 1;
      temp.push(obj);
    } else {
      let top = temp.pop();
      if (top[s[i]]) {
        top[s[i]]++;
        if (top[s[i]] === k) {
          continue;
        }
        temp.push(top);
      } else {
        temp.push(top);
        let obj = {};
        obj[s[i]] = 1;
        temp.push(obj);
      }
    }
  }
  for (let v of temp) {
    let keyValue = Object.keys(v).toString();
    for (let i = 0; i < Object.values(v); i++) {
      res += keyValue;
    }
  }
  return res;
};

/*
Source: https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/
Solve it using the same approach as Remove adjacent duplicates but with hashmap 
this time as you need to equate it to K times.
(char,count) --> In a stack
Input: s = "deeedbbcccbdaa", k = 3
Output: "aa"
Explanation: 
First delete "eee" and "ccc", get "ddbbbdaa"
Then delete "bbb", get "dddaa"
Finally delete "ddd", get "aa"
*/
