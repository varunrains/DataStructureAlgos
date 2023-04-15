var sumOfDigitsInNumber = function (n) {
  if (n === 0) return 0;
  let lastDigit = n % 10;
  return sumOfDigitsInNumber(Math.floor(n / 10)) + lastDigit;
};

sumOfDigitsInNumber(12345);
/*
Didn't find in the leet code
This should be solved using recursion
Input = 1235
Output = 11

Input = 2
Ouput = 2

Basically we should add the digits individually and return the output
*/
