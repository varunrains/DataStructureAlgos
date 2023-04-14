var evalRPN = function (tokens) {
  let temp = [];
  let result;
  for (let i = 0; i < tokens.length; i++) {
    if (
      tokens[i] === "+" ||
      tokens[i] === "-" ||
      tokens[i] === "*" ||
      tokens[i] === "/"
    ) {
      let operand1 = temp.pop();
      let operand2 = temp.pop();
      // let result = Math.floor(eval(operand2 +tokens[i] + operand1));
      if (tokens[i] === "+") {
        result = operand2 + operand1;
      }
      if (tokens[i] === "-") {
        result = operand2 - operand1;
      }
      if (tokens[i] === "*") {
        result = operand2 * operand1;
      }
      if (tokens[i] === "/") {
        result = operand2 / operand1;
      }
      result = result < 0 ? Math.ceil(result)  : Math.floor(result);
      temp.push(result);
    } else {
      temp.push(parseInt(tokens[i]));
    }
  }
  return temp.pop();
};

/*
This problem is also called postpix
Source: https://leetcode.com/problems/evaluate-reverse-polish-notation/
Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Note: check about eval function before using as it didn't work 
if the second operand is negative and we the operator is subtraction
*/
