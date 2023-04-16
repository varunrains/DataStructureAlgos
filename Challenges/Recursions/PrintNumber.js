//Print in ascending order
var printNumber = function (n) {
  //let output=[];
  if (n === 0) return;

  printNumber(n - 1);
  console.log(n);
};
printNumber(5);

//Print in Descending order
var printNumber2 = function (n) {
  //let output=[];
  if (n === 0) return;

  console.log(n);
  printNumber(n - 1);
};

printNumber2(5);

/*
This was not found on leetcode
Input = 3
Output = 1, 2,3

Input = 5
Output = 1,2,3,4,5

This can be executed using the for / while loop
But this solution should be written using recursion.
*/
