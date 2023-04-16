var countZeroes = function (n, count = 0) {
  //base case
  if (n === 0) return count;
  //recursive case
  let lastDigit = n % 10;
  if (lastDigit === 0) {
    count++;
  }
  let smallAns = countZeroes(Math.floor(n / 10), count);

  //calculation
  return smallAns;
};

countZeroes(12003);

/*
Didn't find in the leet code
This should be solved using recursion without for / while loop 
Input = 1020
Output = 2

Input = 123
Ouput = 0

Basically we should count the number of zeroes in a given number and output the total
*/
